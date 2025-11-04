using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;
using ECDSa.Helper.Soap.Security;

namespace ECDSa.Helper.Soap
{
    internal static class SoapEnvelopeHelper
    {
        public static XmlElement Sign(SoapOptions opts, DigitalSignatureIds ids, XmlDocument soapDoc)
        {
            var signature = opts.Certificate.IsEcdsaCertificate()
                ? SignWithECDSA(opts, ids, soapDoc)
                : SignWithRsa(opts, ids, soapDoc);

            return signature;
        }

        private static XmlElement SignWithRsa(SoapOptions opts, DigitalSignatureIds ids, XmlDocument soapDoc)
        {
            string signatureMethod;
            string digestMethod;

            switch (opts.Certificate.SignatureAlgorithm.Value)
            {
                case SignatureAlgorithm.Sha1Rsa:
                    signatureMethod = SignatureAlgorithm.XmlDsigRSASHA1Url;
                    digestMethod = SignedXml.XmlDsigSHA1Url;
                    break;
                case SignatureAlgorithm.Sha256Rsa:
                    signatureMethod = SignatureAlgorithm.XmlDsigRSASHA256Url;
                    digestMethod = SignedXml.XmlDsigSHA256Url;
                    break;
                case SignatureAlgorithm.Sha384Rsa:
                    signatureMethod = SignatureAlgorithm.XmlDsigRSASHA384Url;
                    digestMethod = SignedXml.XmlDsigSHA384Url;
                    break;
                case SignatureAlgorithm.Sha512Rsa:
                    signatureMethod = SignatureAlgorithm.XmlDsigRSASHA512Url;
                    digestMethod = SignedXml.XmlDsigSHA512Url;
                    break;
                default:
                    throw new NotSupportedException("Unsupported certificate algorithm");
            }

            using var pk = opts.Certificate.GetRSAPrivateKey();
            return SignXml(soapDoc, ids, pk, signatureMethod, digestMethod, opts.IncludeTimestamp);
        }

        private static XmlElement SignWithECDSA(SoapOptions opts, DigitalSignatureIds ids, XmlDocument soapDoc)
        {
            string signatureMethod;
            string digestMethod;

            switch (opts.Certificate.SignatureAlgorithm.Value)
            {
                case SignatureAlgorithm.Sha256Ecdsa:
                    signatureMethod = SignatureAlgorithm.XmlDsigECDSaSha256Url;
                    digestMethod = SignedXml.XmlDsigSHA256Url;
                    break;
                case SignatureAlgorithm.Sha384Ecdsa:
                    signatureMethod = SignatureAlgorithm.XmlDsigECDSaSha384Url;
                    digestMethod = SignedXml.XmlDsigSHA384Url;
                    break;
                case SignatureAlgorithm.Sha512Ecdsa:
                    signatureMethod = SignatureAlgorithm.XmlDsigECDSaSha512Url;
                    digestMethod = SignedXml.XmlDsigSHA512Url;
                    break;
                default:
                    throw new NotSupportedException("Unsupported certificate algorithm");
            }

            using var pk = opts.Certificate.GetECDsaPrivateKey();
            return SignXml(soapDoc, ids, pk, signatureMethod, digestMethod, opts.IncludeTimestamp);
        }

        private static XmlElement SignXml(XmlDocument soapDoc, DigitalSignatureIds ids,
            AsymmetricAlgorithm pk, string signatureMethod, string digestMethod, bool includeTimestamp)
        {
            var signedXml = new WsSignedXml(soapDoc)
            {
                SigningKey = pk,
                SignedInfo =
                {
                    SignatureMethod = signatureMethod,
                    CanonicalizationMethod = SignedXml.XmlDsigExcC14NTransformUrl,
                }
            };

            var signatureId = $"xmldsig-{Guid.NewGuid():N}";

            signedXml.Signature.Id = signatureId;

            var rootReference = new Reference($"#{ids.RootElementId}")
            {
                Id = $"{signatureId}-ref0",
                DigestMethod = digestMethod
            };

            rootReference.AddTransform(new XmlDsigEnvelopedSignatureTransform(false));
            rootReference.AddTransform(new XmlDsigExcC14NTransform(false));
            signedXml.AddReference(rootReference);

            if (includeTimestamp)
            {
                var timestampReference = new Reference($"#{ids.TimeStampElementId}")
                {
                    Id = $"{signatureId}-ref1",
                    DigestMethod = digestMethod
                };
                timestampReference.AddTransform(new XmlDsigEnvelopedSignatureTransform(false));
                timestampReference.AddTransform(new XmlDsigExcC14NTransform(false));
                signedXml.AddReference(timestampReference);
            }

            var pfx = XmlNamespaces.Instance.GetPrefixByNamespace(XmlNamespaces.WsSecuritySecextNs);
            if (string.IsNullOrWhiteSpace(pfx))
            {
                throw new ArgumentNullException(nameof(pfx));
            }

            var keyInfo = new KeyInfo
            {
                Id = $"{signatureId}-ki"
            };

            var strElement = soapDoc.CreateElement(pfx, "SecurityTokenReference", XmlNamespaces.WsSecuritySecextNs);
            var refElement = soapDoc.CreateElement(pfx, "Reference", XmlNamespaces.WsSecuritySecextNs);

            refElement.SetAttribute("Id", XmlNamespaces.WsSecurityUtilityNs, $"{signatureId}-str");
            refElement.SetAttribute("ValueType", XmlNamespaces.ValueType);
            refElement.SetAttribute("URI", $"#{ids.SecurityTokenId}");
            strElement.AppendChild(refElement);
            keyInfo.AddClause(new KeyInfoNode(strElement));
            signedXml.KeyInfo = keyInfo;

            signedXml.ComputeSignature();
            return signedXml.GetXml();
        }
    }
}