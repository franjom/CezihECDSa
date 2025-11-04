using ECDSa.Helper;
using ECDSa.Helper.Soap;
using ECDSa.Helper.Soap.Security;
using ECDSa.Helper.Soap.Security.DigitalSignature;
using ECDSa.Helper.Soap.Security.XAdES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;

namespace ECDSa.Fiskalizacija;

public static class FiskalDigSignatureHelper
{
    public static string GenerateZki(string value, X509Certificate2 certificate)
    {
        if (value == null)
        {
            throw new ArgumentNullException("Vrijednost za potpisivanje je prazna!");
        }

        if (certificate == null)
        {
            throw new ArgumentNullException("Certifikat je null!");
        }

        var b = Encoding.ASCII.GetBytes(value);

        using var provider = certificate.GetRSAPrivateKey();
        if (provider == null)
        {
            throw new ArgumentNullException("Certifikat nema privatni ključ popunjen!");
        }

        var signData = provider.SignData(b, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);

        using var md5 = MD5.Create();
        var hash = md5.ComputeHash(signData);
        var result = BitConverter.ToString(hash).Replace("-", "").ToLower();
        return result;
    }

    public static XmlElement CreateSignatureElement(X509Certificate2 certificate, XmlDocument doc, string id,
        bool isXAdES = false)
    {
        var (signatureMethod, digestMethod, hashAlg) = certificate.SignatureAlgorithm.Value switch
        {
            SignatureAlgorithm.Sha1Rsa => (SignedXml.XmlDsigRSASHA1Url, SignedXml.XmlDsigSHA1Url,
                HashAlgorithmName.SHA1),
            SignatureAlgorithm.Sha256Rsa => (SignedXml.XmlDsigRSASHA256Url, SignedXml.XmlDsigSHA256Url,
                HashAlgorithmName.SHA256),
            SignatureAlgorithm.Sha384Rsa => (SignedXml.XmlDsigRSASHA384Url, SignedXml.XmlDsigSHA384Url,
                HashAlgorithmName.SHA384),
            SignatureAlgorithm.Sha512Rsa => (SignedXml.XmlDsigRSASHA512Url, SignedXml.XmlDsigSHA512Url,
                HashAlgorithmName.SHA512),
            _ => throw new NotSupportedException("Unsupported certificate algorithm")
        };

        using var pk = certificate.GetRSAPrivateKey();
        if (pk == null)
        {
            throw new Exception("Private key not found");
        }

        var signatureElement = isXAdES
            ? SignXmlXAdES(certificate, doc, id, pk, signatureMethod, digestMethod, hashAlg)
            : SignXml(certificate, doc, id, pk, signatureMethod, digestMethod);

        return signatureElement;
    }

    private static XmlElement SignXml(X509Certificate2 cert, XmlDocument doc, string part,
        AsymmetricAlgorithm privateKey, string signatureMethod, string digestMethod)
    {
        var keyInfo = new KeyInfo();
        keyInfo.AddClause(new RSAKeyValue(cert.GetRSAPublicKey()!));

        var keyInfoX509Data = new KeyInfoX509Data(cert);
        keyInfoX509Data.AddIssuerSerial(cert.Issuer, cert.GetSerial());
        keyInfoX509Data.AddSubjectName(cert.Subject);
        keyInfo.AddClause(keyInfoX509Data);

        var signedXml = new SignedXml(doc)
        {
            SigningKey = privateKey,
            KeyInfo = keyInfo,
            SignedInfo =
            {
                SignatureMethod = signatureMethod,
                CanonicalizationMethod = SignedXml.XmlDsigExcC14NTransformUrl
            }
        };

        var signatureId = $"xmldsig-{Guid.NewGuid():N}";

        signedXml.Signature.Id = signatureId;

        var uri = string.IsNullOrWhiteSpace(part) ? "" : $"#{part}";
        var rootReference = new Reference
        {
            Id = $"{signatureId}-ref0",
            Uri = uri,
            DigestMethod = digestMethod
        };
        rootReference.AddTransform(new XmlDsigEnvelopedSignatureTransform(false));
        rootReference.AddTransform(new XmlDsigExcC14NTransform(false));

        signedXml.AddReference(rootReference);

        signedXml.ComputeSignature();

        return signedXml.GetXml();
    }

    private static XmlElement SignXmlXAdES(X509Certificate2 cert, XmlDocument doc, string part,
        AsymmetricAlgorithm privateKey, string signatureMethod, string digestMethod, HashAlgorithmName hashAlg)
    {
        var signatureId = $"xmldsig-{Guid.NewGuid():N}";
        var keyInfoId = $"{signatureId}-keyinfo";

        var keyInfo = new KeyInfo
        {
            Id = keyInfoId
        };
        keyInfo.AddClause(new RSAKeyValue(cert.GetRSAPublicKey()!));

        var keyInfoX509Data = new KeyInfoX509Data();
        keyInfoX509Data.AddCertificate(cert);
        keyInfo.AddClause(keyInfoX509Data);

        var signedXml = new XadesSignedXml(doc)
        {
            SigningKey = privateKey,
            KeyInfo = keyInfo,
            SignedInfo =
            {
                SignatureMethod = signatureMethod,
                CanonicalizationMethod = SignedXml.XmlDsigExcC14NTransformUrl
            },
            Signature =
            {
                Id = signatureId
            }
        };

        var nsList = XmlNamespaces.UblNamespaces;

        var pfxes = string.Join(" ", nsList.Select(item => XmlNamespaces.Instance.GetPrefixByNamespace(item)));

        var uri = string.IsNullOrWhiteSpace(part) ? "" : $"#{part}";
        var rootReference = new Reference(uri)
        {
            Id = $"{signatureId}-ref0",
            DigestMethod = digestMethod
        };
        rootReference.AddTransform(new XmlDsigEnvelopedSignatureTransform());
        rootReference.AddTransform(new XmlDsigExcC14NTransform(false, pfxes));

        var signedPropsId = $"{signatureId}-signedprops";
        var qpXml = BuildQualifyingPropertiesXml(signatureId, signedPropsId, digestMethod, hashAlg, cert);

        var fragment = doc.CreateDocumentFragment();
        fragment.InnerXml = qpXml;

        var objectId = $"xades-object-{Guid.NewGuid():N}";
        var dataObject = new DataObject
        {
            Data = fragment.ChildNodes,
            Id = objectId
        };
        signedXml.AddObject(dataObject);

        var signedPropsReference = new Reference($"#{signedPropsId}")
        {
            Id = $"{signedPropsId}-ref1",
            DigestMethod = digestMethod,
            Type = "http://uri.etsi.org/01903#SignedProperties"
        };
        signedPropsReference.AddTransform(new XmlDsigExcC14NTransform(false));

        signedXml.AddReference(rootReference);
        signedXml.AddReference(signedPropsReference);

        signedXml.ComputeSignature();

        return signedXml.GetXml();
    }

    private static string BuildQualifyingPropertiesXml(string signatureId, string signedPropsId, string digestMethod,
        HashAlgorithmName hashAlg, X509Certificate2 cert)
    {
        var qp = new QualifyingPropertiesType
        {
            Id = $"qual-props-{Guid.NewGuid():N}",
            Target = $"#{signatureId}",
            SignedProperties = new SignedPropertiesType
            {
                Id = signedPropsId,
                SignedSignatureProperties = new SignedSignaturePropertiesType
                {
                    SigningTime = DateTime.Now,
                    SigningTimeSpecified = true,
                    SigningCertificate = new[]
                    {
                        new CertIDType
                        {
                            CertDigest = new DigestAlgAndValueType
                            {
                                DigestMethod = new DigestMethodType { Algorithm = digestMethod },
                                DigestValue = cert.GetCertHash()
                            },
                            IssuerSerial = new X509IssuerSerialType
                            {
                                X509IssuerName = cert.Issuer,
                                X509SerialNumber = cert.GetSerial()
                            }
                        }
                    }
                },
                SignedDataObjectProperties = new SignedDataObjectPropertiesType
                {
                    DataObjectFormat = new[]
                    {
                        new DataObjectFormatType
                        {
                            ObjectReference = $"{signatureId}-ref0",
                            MimeType = "application/xml",
                            Encoding = Encoding.UTF8.WebName
                        }
                    },
                    CommitmentTypeIndication = new[]
                    {
                        new CommitmentTypeIndicationType
                        {
                            CommitmentTypeId = new ObjectIdentifierType
                            {
                                Identifier = new IdentifierType
                                {
                                    Value = "http://uri.etsi.org/01903/v1.2.2#ProofOfOrigin"
                                },
                            },
                            Items = new[] { new object() },
                        },
                        new CommitmentTypeIndicationType
                        {
                            CommitmentTypeId = new ObjectIdentifierType
                            {
                                Identifier = new IdentifierType
                                {
                                    Value = "http://uri.etsi.org/01903/v1.2.2#ProofOfSender"
                                }
                            },
                            Items = new[] { new object() },
                        }
                    }
                }
            }
        };

        List<string> nsList = new List<string>
        {
            XmlNamespaces.EtsiNs,
            XmlNamespaces.XmlDsigNs,
        };

        var ns = XmlNamespaces.Instance.GetNamespaces(nsList);
        return SoapSerializer.Instance.Serialize(qp, ns, omitXmlDeclaration: true);
    }
}