using ECDSa.Helper;
using ECDSa.Interfaces;
using System;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace ECDSa
{
    public sealed class XmlDigitalSignatureProvider : IXmlDigitalSignatureProviderExt
    {
        public X509Certificate2 Certificate { get; set; }

        public XmlDocument SignXml(XmlDocument doc, string part)
        {
            if (Certificate.IsEcdsaCertificate())
            {
                return SignXmlWithECDSA(Certificate, doc, part);
            }

            return SignXmlWithRSA(Certificate, doc, part);
        }

        /// <summary>
        /// Signs the given XML document using RSA and an X.509 certificate.
        /// Automatically selects SHA1 or SHA384 based on the certificate's signature algorithm.
        /// </summary>
        /// <param name="cert">The X.509 certificate containing the RSA private key.</param>
        /// <param name="doc">The XML document to sign.</param>
        /// <param name="part">The ID of the XML element to reference in the signature.</param>
        /// <returns>A new <see cref="XmlDocument"/> containing the RSA-based XML digital signature.</returns>
        private static XmlDocument SignXmlWithRSA(X509Certificate2 cert, XmlDocument doc, string part)
        {
            using (var pk = cert.GetRSAPrivateKey())
            {
                var isLegacyCard = cert.SignatureAlgorithm.Value == SignatureAlgorithm.Sha1Rsa;
                var signatureMethod = isLegacyCard ? SignedXml.XmlDsigRSASHA1Url : SignedXml.XmlDsigRSASHA384Url;
                var digestMethod = isLegacyCard ? SignedXml.XmlDsigSHA1Url : SignedXml.XmlDsigSHA384Url;

                var rsaKeyValue = new RSAKeyValue(pk);
                return SignXml(cert, doc, part, pk, signatureMethod, digestMethod, rsaKeyValue);
            }
        }

        /// <summary>
        /// Signs the given XML document using ECDSA (SHA384) and an X.509 certificate.
        /// </summary>
        /// <param name="cert">The X.509 certificate containing the ECDSA private key.</param>
        /// <param name="doc">The XML document to sign.</param>
        /// <param name="part">The ID of the XML element to reference in the signature.</param>
        /// <returns>A new <see cref="XmlDocument"/> containing the ECDSA-based XML digital signature.</returns>
        private static XmlDocument SignXmlWithECDSA(X509Certificate2 cert, XmlDocument doc, string part)
        {
            using (var pk = cert.GetECDsaPrivateKey())
            {
                const string signatureMethod = SignatureAlgorithm.XmlDsigECDSaSha384Url;
                const string digestMethod = SignedXml.XmlDsigSHA384Url;

                return SignXml(cert, doc, part, pk, signatureMethod, digestMethod);
            }
        }

        /// <summary>
        /// Signs the given XML document using the specified private key and signature settings.
        /// </summary>
        /// <param name="cert">The X.509 certificate used to provide signature metadata and validation.</param>
        /// <param name="doc">The XML document to be signed.</param>
        /// <param name="part">The ID of the XML element (as URI fragment) that should be referenced by the signature.</param>
        /// <param name="privateKey">The asymmetric private key used for signing.</param>
        /// <param name="signatureMethod">The URI of the signature method algorithm (e.g., RSA-SHA384, ECDSA-SHA384).</param>
        /// <param name="digestMethod">The URI of the digest method algorithm used to hash the referenced element.</param>
        /// <param name="extraKeyInfoClause">
        /// Optional additional <see cref="KeyInfoClause"/> to include in the signature's KeyInfo block
        /// (e.g., <see cref="RSAKeyValue"/> for RSA-based signatures).
        /// </param>
        /// <returns>A new <see cref="XmlDocument"/> instance containing the XML digital signature.</returns>
        private static XmlDocument SignXml(X509Certificate2 cert, XmlDocument doc, string part,
            AsymmetricAlgorithm privateKey, string signatureMethod, string digestMethod,
            KeyInfoClause extraKeyInfoClause = null)
        {
            var serialBytes = cert.GetSerialNumber();
            Array.Reverse(serialBytes);

            var unsignedSerialBytes = serialBytes.Concat(new byte[] { 0 }).ToArray();

            var serialNumber = new BigInteger(unsignedSerialBytes);

            var keyInfo = new KeyInfo();
            if (extraKeyInfoClause != null)
            {
                keyInfo.AddClause(extraKeyInfoClause);
            }

            var keyInfoX509Data = new KeyInfoX509Data();
            keyInfoX509Data.AddCertificate(cert);
            keyInfoX509Data.AddIssuerSerial(cert.Issuer, serialNumber.ToString());
            keyInfoX509Data.AddSubjectName(cert.Subject);
            keyInfo.AddClause(keyInfoX509Data);

            var signedXml = new SignedXml(doc)
            {
                SigningKey = privateKey,
                KeyInfo = keyInfo,
                SignedInfo =
                {
                    SignatureMethod = signatureMethod,
                    CanonicalizationMethod = SignedXml.XmlDsigCanonicalizationUrl
                }
            };

            var reference = new Reference
            {
                Uri = $"#{part}",
                DigestMethod = digestMethod
            };
            reference.AddTransform(new XmlDsigEnvelopedSignatureTransform());

            signedXml.AddReference(reference);
            signedXml.ComputeSignature();

            var xmlDocument = new XmlDocument
            {
                InnerXml = signedXml.GetXml().OuterXml
            };
            return xmlDocument;
        }
    }
}