using ECDSa.Helper.Soap;
using ECDSa.Helper.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        public const string WsSecurityNs = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd";
        private const string ValueType = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-x509-token-profile-1.0#X509v3";
        private const string B64Encoding = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#Base64Binary";
        // @formatter:on

        private static Dictionary<string, string> _namesapces = new Dictionary<string, string>
        {
            { "s11", SoapNs11 },
            { "s12", SoapNs12 },
            { "wsa10", "http://www.w3.org/2005/08/addressing" },
            { "wsse", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" },
            { "wsu", WsSecurityNs },
            { "xsd", "http://www.w3.org/2001/XMLSchema" },
            { "xsi", "http://www.w3.org/2001/XMLSchema-instance" }
        };

        private static readonly XmlWriterSettings CompactXmlWriterSettings = new XmlWriterSettings
        {
            Encoding = new UTF8Encoding(false),
            OmitXmlDeclaration = false,
            Indent = false,
        };

        public static string CreateSoap11Envelope(SoapOptions opts)
        {
            opts.XmlString = Regex.Replace(opts.XmlString, @"<\?xml[^>]+\?>", "").TrimStart('\uFEFF').Trim();

            var s11ns = _namesapces.Keys.FirstOrDefault(k => _namesapces[k] == SoapNs11);
            var addrNs = _namesapces["wsa10"];

            var soapDoc = new XmlDocument { PreserveWhitespace = true };

            var envelope = soapDoc.CreateElement(s11ns, "Envelope", SoapNs11);
            foreach (var kv in _namesapces.Where(o => o.Value != SoapNs12))
            {
                envelope.SetAttribute($"xmlns:{kv.Key}", kv.Value);
            }

            soapDoc.AppendChild(envelope);

            var header = soapDoc.CreateElement(s11ns, "Header", SoapNs11);
            envelope.AppendChild(header);


            var action = soapDoc.CreateElement("wsa10", "Action", addrNs);
            action.InnerText = opts.SoapAction;
            header.AppendChild(action);

            if (opts.MessageId != Guid.Empty)
            {
                var addr = _namesapces["wsa10"];
                var msgId = soapDoc.CreateElement("wsa10", "MessageID", addr);
                msgId.InnerText = $"urn:uuid:{Guid.NewGuid():D}";
                header.AppendChild(msgId);
            }

            var body = soapDoc.CreateElement(s11ns, "Body", SoapNs11);
            body.InnerXml = opts.XmlString;

            envelope.AppendChild(body);
            var sb = new StringBuilder();
            using (var writer = XmlWriter.Create(sb, CompactXmlWriterSettings))
            {
                soapDoc.WriteTo(writer);
                writer.Flush();

                return sb.ToString();
            }
        }

        public static string CreateSoap12Envelope(SoapOptions opts)
        {
            opts.XmlString = Regex.Replace(opts.XmlString, @"<\?xml[^>]+\?>", "").TrimStart('\uFEFF').Trim();

            var s12ns = _namesapces.Keys.FirstOrDefault(k => _namesapces[k] == SoapNs12);
            var addrNs = _namesapces["wsa10"];

            var soapDoc = new XmlDocument { PreserveWhitespace = true };

            var envelope = soapDoc.CreateElement(s12ns, "Envelope", SoapNs12);
            foreach (var kv in _namesapces.Where(o => o.Value != SoapNs11))
            {
                envelope.SetAttribute($"xmlns:{kv.Key}", kv.Value);
            }

            soapDoc.AppendChild(envelope);

            var header = soapDoc.CreateElement(s12ns, "Header", SoapNs12);

            var mustUnderstandAttr = soapDoc.CreateAttribute(s12ns, "mustUnderstand", SoapNs12);
            mustUnderstandAttr.Value = "1";

            var action = soapDoc.CreateElement("wsa10", "Action", addrNs);
            action.Attributes.Append(mustUnderstandAttr);
            action.InnerText = opts.SoapAction;
            header.AppendChild(action);

            if (opts.ReplyTo != null)
            {
                var to = soapDoc.CreateElement("wsa10", "To", addrNs);
                to.Attributes.Append(mustUnderstandAttr);
                to.InnerText = opts.ReplyTo.ToString();
                header.AppendChild(to);
            }

            if (opts.MessageId != Guid.Empty)
            {
                var addr = _namesapces["wsa10"];
                var msgId = soapDoc.CreateElement("wsa10", "MessageID", addr);
                msgId.InnerText = $"urn:uuid:{Guid.NewGuid():D}";
                header.AppendChild(msgId);
            }

            var body = soapDoc.CreateElement("soap", "Body", SoapNs12);
            body.InnerXml = opts.XmlString;

            envelope.AppendChild(header);
            envelope.AppendChild(body);

            var sb = new StringBuilder();
            using (var writer = XmlWriter.Create(sb, CompactXmlWriterSettings))
            {
                soapDoc.WriteTo(writer);
                writer.Flush();

                return sb.ToString();
            }
        }

        public static string CreateSoap11SignedEnvelope(SoapOptions opts)
        {
            return CreateSignedSoapEnvelope(opts, SoapNs11, "s11", SoapNs12);
        }

        public static string CreateSoap12SignedEnvelope(SoapOptions opts)
        {
            return CreateSignedSoapEnvelope(opts, SoapNs12, "s12", SoapNs11);
        }

        private static string CreateSignedSoapEnvelope(
            SoapOptions opts,
            string soapNs,
            string soapPrefix,
            string excludeNs)
        {
            opts.XmlString = Regex.Replace(opts.XmlString, @"<\?xml[^>]+\?>", "").TrimStart('\uFEFF').Trim();

            var wsuns = _namesapces["wsu"];
            var wssens = _namesapces["wsse"];

            var soapDoc = new XmlDocument { PreserveWhitespace = true };

            var envelope = soapDoc.CreateElement(soapPrefix, "Envelope", soapNs);
            foreach (var kv in _namesapces.Where(o => o.Value != excludeNs))
            {
                envelope.SetAttribute($"xmlns:{kv.Key}", kv.Value);
            }

            soapDoc.AppendChild(envelope);

            var header = soapDoc.CreateElement(soapPrefix, "Header", soapNs);
            envelope.AppendChild(header);

            var id = $"id-{Guid.NewGuid():N}";
            var body = soapDoc.CreateElement(soapPrefix, "Body", soapNs);
            var bodyId = soapDoc.CreateAttribute("wsu", "Id", wsuns);
            bodyId.Value = id;
            body.Attributes.Append(bodyId);

            var importedNode = soapDoc.CreateDocumentFragment();
            importedNode.InnerXml = opts.XmlString;
            body.AppendChild(importedNode);

            envelope.AppendChild(body);

            var security = soapDoc.CreateElement("wsse", "Security", wssens);
            var mustUnderstandAttr = soapDoc.CreateAttribute(soapPrefix, "mustUnderstand", soapNs);
            mustUnderstandAttr.Value = "1";
            security.Attributes.Append(mustUnderstandAttr);

            if (opts.IncludeTimestamp)
            {
                var timestamp = CreateTimestamp(soapDoc);
                security.AppendChild(timestamp);
            }

            var token = soapDoc.CreateElement("wsse", "BinarySecurityToken", wssens);
            token.SetAttribute("EncodingType", B64Encoding);
            token.SetAttribute("ValueType", ValueType);
            var bstId = soapDoc.CreateAttribute("wsu", "Id", wsuns);
            bstId.Value = "_kt";
            token.Attributes.Append(bstId);
            token.InnerText = Convert.ToBase64String(opts.Certificate.RawData);
            security.AppendChild(token);

            var addrNs = _namesapces["wsa10"];
            var action = soapDoc.CreateElement("wsa10", "Action", addrNs);
            //action.Attributes.Append(mustUnderstandAttr);
            action.InnerText = opts.SoapAction;

            header.AppendChild(security);
            header.AppendChild(action);

            if (opts.ReplyTo != null)
            {
                var to = soapDoc.CreateElement("wsa10", "To", addrNs);
                to.Attributes.Append(mustUnderstandAttr);
                to.InnerText = opts.ReplyTo.ToString();
                header.AppendChild(to);
            }

            if (opts.MessageId != Guid.Empty)
            {
                var addr = _namesapces["wsa10"];
                var msgId = soapDoc.CreateElement("wsa10", "MessageID", addr);
                msgId.InnerText = $"urn:uuid:{Guid.NewGuid():D}";
                header.AppendChild(msgId);
            }

            XmlElement signature;
            if (opts.Certificate.IsEcdsaCertificate())
            {
                signature = SignWithECDSA(opts.Certificate, soapDoc, id);
            }
            else
            {
                signature = SignWithRsa(opts.Certificate, soapDoc, id);
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

            var wssens = _namesapces["wsse"];
            var strElement = soapDoc.CreateElement("wsse", "SecurityTokenReference", wssens);
            var refElement = soapDoc.CreateElement("wsse", "Reference", wssens);

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
            nsmgr.AddNamespace("s12", SoapNs12);

            var bodyNode = soapDoc.SelectSingleNode("/s12:Envelope/s12:Body", nsmgr);

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
            nsmgr.AddNamespace("s11", SoapNs11);

            var bodyNode = soapDoc.SelectSingleNode("/s11:Envelope/s11:Body", nsmgr);

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
            var wsuns = _namesapces["wsu"];

            var timestamp = doc.CreateElement("wsu", "Timestamp", wsuns);
            var tsId = doc.CreateAttribute("wsu", "Id", wsuns);
            tsId.Value = "_0";
            timestamp.Attributes.Append(tsId);

            var created = doc.CreateElement("wsu", "Created", wsuns);
            created.InnerText = XmlConvert.ToString(DateTime.UtcNow, XmlDateTimeSerializationMode.Utc);
            timestamp.AppendChild(created);

            var expires = doc.CreateElement("wsu", "Expires", wsuns);
            expires.InnerText = XmlConvert.ToString(DateTime.UtcNow.AddMinutes(5), XmlDateTimeSerializationMode.Utc);
            timestamp.AppendChild(expires);

            return timestamp;
        }
    }
}