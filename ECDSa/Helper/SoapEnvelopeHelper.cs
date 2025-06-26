using ECDSa.Helper.Xml;
using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace ECDSa.Helper
{
    public static class SoapEnvelopeHelper
    {
        // @formatter:off
        public const string SoapNs12 = "http://www.w3.org/2003/05/soap-envelope";
        public const string SoapNs11 = "http://schemas.xmlsoap.org/soap/envelope/";
        private static readonly string SoapAddr = "http://www.w3.org/2005/08/addressing";
        private static readonly string WsseNs = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd";
        private static readonly string WsuNs = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd";
        private static readonly string ValueType = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-x509-token-profile-1.0#X509v3";
        private static readonly string B64Encoding = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#Base64Binary";
        // @formatter:on

        private static readonly XmlWriterSettings CompactXmlWriterSettings = new XmlWriterSettings
        {
            Encoding = Encoding.UTF8,
            OmitXmlDeclaration = false,
            Indent = false
        };

        public static string CreateSoap11Envelope(string innerXml)
        {
            innerXml = Regex.Replace(innerXml, @"<\?xml[^>]+\?>", "").TrimStart('\uFEFF').Trim();
            var soapDoc = new XmlDocument { PreserveWhitespace = true };

            var envelope = soapDoc.CreateElement("soap", "Envelope", SoapNs11);
            envelope.SetAttribute("xmlns:soap", SoapNs11);
            envelope.SetAttribute("xmlns:xsd", "http://www.w3.org/2001/XMLSchema");
            envelope.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            soapDoc.AppendChild(envelope);

            var header = soapDoc.CreateElement("soap", "Header", SoapNs11);
            envelope.AppendChild(header);

            var body = soapDoc.CreateElement("soap", "Body", SoapNs11);
            body.InnerXml = innerXml;

            envelope.AppendChild(body);
            var sb = new StringBuilder();
            using (var writer = XmlWriter.Create(sb, CompactXmlWriterSettings))
            {
                soapDoc.WriteTo(writer);
                writer.Flush();
                return sb.ToString();
            }
        }

        public static string CreateSoap12SignedEnvelope(string innerXml, string soapAction, string url,
            X509Certificate2 cert)
        {
            innerXml = Regex.Replace(innerXml, @"<\?xml[^>]+\?>", "").TrimStart('\uFEFF').Trim();

            var soapDoc = new XmlDocument { PreserveWhitespace = true };

            var envelope = soapDoc.CreateElement("soap", "Envelope", SoapNs12);
            envelope.SetAttribute("xmlns:soap", SoapNs12);
            envelope.SetAttribute("xmlns:addr", SoapAddr);
            envelope.SetAttribute("xmlns:xsd", "http://www.w3.org/2001/XMLSchema");
            envelope.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            envelope.SetAttribute("xmlns:wsse", WsseNs);
            envelope.SetAttribute("xmlns:wsu", WsuNs);
            soapDoc.AppendChild(envelope);

            var header = soapDoc.CreateElement("soap", "Header", SoapNs12);
            envelope.AppendChild(header);

            var id = $"id-{Guid.NewGuid():N}";
            var body = soapDoc.CreateElement("soap", "Body", SoapNs12);
            var bodyId = soapDoc.CreateAttribute("wsu", "Id", WsuNs);
            bodyId.Value = id;
            body.Attributes.Append(bodyId);

            var importedNode = soapDoc.CreateDocumentFragment();
            importedNode.InnerXml = innerXml;
            body.AppendChild(importedNode);

            envelope.AppendChild(body);

            var security = soapDoc.CreateElement("wsse", "Security", WsseNs);
            var mustUnderstandAttr = soapDoc.CreateAttribute("soap", "mustUnderstand", SoapNs12);
            mustUnderstandAttr.Value = "1";
            security.Attributes.Append(mustUnderstandAttr);

            var timestamp = CreateTimestamp(soapDoc);
            security.AppendChild(timestamp);

            var token = soapDoc.CreateElement("wsse", "BinarySecurityToken", WsseNs);
            token.SetAttribute("EncodingType", B64Encoding);
            token.SetAttribute("ValueType", ValueType);
            var bstId = soapDoc.CreateAttribute("wsu", "Id", WsuNs);
            bstId.Value = "_kt";
            token.Attributes.Append(bstId);
            token.InnerText = Convert.ToBase64String(cert.RawData);
            security.AppendChild(token);

            var action = soapDoc.CreateElement("addr", "Action", SoapAddr);
            action.Attributes.Append(mustUnderstandAttr);
            action.InnerText = soapAction;

            var to = soapDoc.CreateElement("addr", "To", SoapAddr);
            to.Attributes.Append(mustUnderstandAttr);
            to.InnerText = url;

            var msgId = soapDoc.CreateElement("addr", "MessageID", SoapAddr);
            msgId.InnerText = $"urn:uuid:{Guid.NewGuid():N}";

            header.AppendChild(security);
            header.AppendChild(action);
            header.AppendChild(to);
            header.AppendChild(msgId);

            XmlElement signature;
            if (cert.IsEcdsaCertificate())
            {
                signature = SignWithECDSA(cert, soapDoc, id);
            }
            else
            {
                signature = SignWithRsa(cert, soapDoc, id);
            }

            var importedSignature = soapDoc.ImportNode(signature, true);
            security.AppendChild(importedSignature);

            var sb = new StringBuilder();
            using (var writer = XmlWriter.Create(sb, CompactXmlWriterSettings))
            {
                soapDoc.WriteTo(writer);
                writer.Flush();

                return sb.ToString();
            }
        }

        private static XmlElement SignWithRsa(X509Certificate2 cert, XmlDocument soapDoc, string id)
        {
            using (var pk = cert.GetRSAPrivateKey())
            {
                var isLegacy = cert.SignatureAlgorithm.Value == SignatureAlgorithm.Sha1Rsa;
                var signatureMethod = isLegacy ? SignedXml.XmlDsigRSASHA1Url : SignedXml.XmlDsigRSASHA384Url;
                var digestMethod = isLegacy ? SignedXml.XmlDsigSHA1Url : SignedXml.XmlDsigSHA384Url;

                return SignXml(soapDoc, id, pk, signatureMethod, digestMethod);
            }
        }

        private static XmlElement SignWithECDSA(X509Certificate2 cert, XmlDocument soapDoc, string id)
        {
            using (var pk = cert.GetECDsaPrivateKey())
            {
                const string signatureMethod = SignatureAlgorithm.XmlDsigECDSaSha384Url;
                const string digestMethod = SignedXml.XmlDsigSHA384Url;

                return SignXml(soapDoc, id, pk, signatureMethod, digestMethod);
            }
        }

        private static XmlElement SignXml(XmlDocument soapDoc, string id, AsymmetricAlgorithm pk,
            string signatureMethod, string digestMethod)
        {
            var signedXml = new WsSignedXml(soapDoc)
            {
                SigningKey = pk
            };

            var reference = new Reference($"#{id}")
            {
                DigestMethod = digestMethod
            };
            reference.AddTransform(new XmlDsigExcC14NTransform());
            signedXml.AddReference(reference);

            var keyInfo = new KeyInfo();

            var strElement = soapDoc.CreateElement("wsse", "SecurityTokenReference", WsseNs);
            var refElement = soapDoc.CreateElement("wsse", "Reference", WsseNs);

            refElement.SetAttribute("URI", "#_kt");
            refElement.SetAttribute("ValueType", ValueType);
            strElement.AppendChild(refElement);
            keyInfo.AddClause(new KeyInfoNode(strElement));
            signedXml.KeyInfo = keyInfo;

            signedXml.SignedInfo.CanonicalizationMethod = SignedXml.XmlDsigExcC14NTransformUrl;
            signedXml.SignedInfo.SignatureMethod = signatureMethod;

            signedXml.ComputeSignature();
            return signedXml.GetXml();
        }

        public static XmlDocument GetSoapBody12Contents(string soapResponseString)
        {
            var soapDoc = new XmlDocument();
            soapDoc.LoadXml(soapResponseString);

            var nsmgr = new XmlNamespaceManager(soapDoc.NameTable);
            nsmgr.AddNamespace("soapenv", SoapNs12);

            var bodyNode = soapDoc.SelectSingleNode("/soapenv:Envelope/soapenv:Body", nsmgr);

            if (bodyNode == null)
            {
                throw new InvalidOperationException("SOAP body not found in the response.");
            }

            var bodyDoc = new XmlDocument();
            bodyDoc.LoadXml(bodyNode.InnerXml);
            return bodyDoc;
        }

        public static XmlDocument GetSoapBody11Contents(string soapResponseString)
        {
            var soapDoc = new XmlDocument();
            soapDoc.LoadXml(soapResponseString);

            var nsmgr = new XmlNamespaceManager(soapDoc.NameTable);
            nsmgr.AddNamespace("soapenv", SoapNs11);

            var bodyNode = soapDoc.SelectSingleNode("/soapenv:Envelope/soapenv:Body", nsmgr);

            if (bodyNode == null)
            {
                throw new InvalidOperationException("SOAP body not found in the response.");
            }

            var bodyDoc = new XmlDocument();
            bodyDoc.LoadXml(bodyNode.InnerXml);
            return bodyDoc;
        }

        private static XmlElement CreateTimestamp(XmlDocument doc)
        {
            var timestamp = doc.CreateElement("wsu", "Timestamp", WsuNs);
            var tsId = doc.CreateAttribute("wsu", "Id", WsuNs);
            tsId.Value = "_0";
            timestamp.Attributes.Append(tsId);

            var created = doc.CreateElement("wsu", "Created", WsuNs);
            created.InnerText = XmlConvert.ToString(DateTime.UtcNow, XmlDateTimeSerializationMode.Utc);
            timestamp.AppendChild(created);

            var expires = doc.CreateElement("wsu", "Expires", WsuNs);
            expires.InnerText = XmlConvert.ToString(DateTime.UtcNow.AddMinutes(5), XmlDateTimeSerializationMode.Utc);
            timestamp.AppendChild(expires);

            return timestamp;
        }
    }
}