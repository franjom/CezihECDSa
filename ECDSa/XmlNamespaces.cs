using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace ECDSa
{
    public sealed class XmlNamespaces
    {
        private static readonly Lazy<XmlNamespaces> _instance =
            new Lazy<XmlNamespaces>(() => new XmlNamespaces());

        private static readonly Dictionary<string, string> _prefixes = new Dictionary<string, string>();

        public static XmlNamespaces Instance => _instance.Value;

        // @formatter:off
        public const string AddressingNs = "http://www.w3.org/2005/08/addressing";
        public const string SoapNs12 = "http://www.w3.org/2003/05/soap-envelope";
        public const string SoapNs11 = "http://schemas.xmlsoap.org/soap/envelope/";
        public const string WsSecurityUtilityNs = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd";
        public const string WsSecuritySecextNs = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd";
        public const string ValueType = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-x509-token-profile-1.0#X509v3";
        public const string B64Encoding = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#Base64Binary";
        public const string XmlDsigNs = "http://www.w3.org/2000/09/xmldsig#";
        public const string EtsiNs = "http://uri.etsi.org/01903/v1.3.2#";
        public const string UblInvoice = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2";
        public const string UblCommonAggComp = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2";
        public const string UblCommonBasComp = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
        public const string UblCommonExtComp = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2";
        public const string UblSigAggComp = "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2";
        public const string UblSigBasComp = "urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2";
        public const string UblCommonSigComp = "urn:oasis:names:specification:ubl:schema:xsd:CommonSignatureComponents-2";
        public const string HrExtAggComp = "urn:mfin.gov.hr:schema:xsd:HRExtensionAggregateComponents-1";
        public const string UblUnqDataTypes = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2";
        public const string UblCoreCompTypes = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2";
        // @formatter:on

        public static readonly List<string> UblNamespaces = new List<string>
        {
            UblInvoice,
            UblCommonAggComp,
            UblCommonBasComp,
            UblCommonExtComp,
            UblSigAggComp,
            UblSigBasComp,
            UblCommonSigComp,
            HrExtAggComp,
            UblCoreCompTypes,
            UblUnqDataTypes,
        };


        private XmlNamespaces()
        {
            _prefixes.Add(AddressingNs, "wsa");
            _prefixes.Add(SoapNs12, "s");
            _prefixes.Add(SoapNs11, "s");
            _prefixes.Add(WsSecurityUtilityNs, "wsu");
            _prefixes.Add(WsSecuritySecextNs, "wsse");
            _prefixes.Add(XmlDsigNs, "ds");
            _prefixes.Add(EtsiNs, "xades");
            _prefixes.Add(UblInvoice, "inv");
            _prefixes.Add(UblCommonAggComp, "cac");
            _prefixes.Add(UblCommonBasComp, "cbc");
            _prefixes.Add(UblCommonExtComp, "ext");
            _prefixes.Add(UblSigAggComp, "sac");
            _prefixes.Add(UblSigBasComp, "sbc");
            _prefixes.Add(UblCommonSigComp, "sig");
        }

        public string GetPrefixByNamespace(string ns)
        {
            return _prefixes.FirstOrDefault(o => o.Key == ns).Value;
        }
        
        public XmlSerializerNamespaces GetNamespaces(List<string> namespaces)
        {
            var ns = new XmlSerializerNamespaces();
            foreach (var ns1 in namespaces)
            {
                var pfx = GetPrefixByNamespace(ns1);
                if (!string.IsNullOrWhiteSpace(pfx))
                {
                    ns.Add(pfx, ns1);
                }
            }

            return ns;
        }
    }
}