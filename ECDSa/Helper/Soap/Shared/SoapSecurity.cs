using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Shared
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.WsSecuritySecextNs)]
    [XmlRoot("Security", Namespace = XmlNamespaces.WsSecuritySecextNs)]
    public sealed class SoapSecurity
    {
        [XmlNamespaceDeclarations] 
        public XmlSerializerNamespaces Namespaces = new XmlSerializerNamespaces();

        public SoapSecurity()
        {
            var pfx = XmlNamespaces.Instance.GetPrefixByNamespace(XmlNamespaces.WsSecuritySecextNs);
            Namespaces.Add(pfx, XmlNamespaces.WsSecuritySecextNs);
        }

        [XmlAttribute("mustUnderstand", Namespace = XmlNamespaces.SoapNs11)]
        public string MustUnderstand { get; set; } = "1";

        [XmlElement("BinarySecurityToken", Namespace = XmlNamespaces.WsSecuritySecextNs, Order = 2)]
        public SecurityToken Token { get; set; }

        [XmlElement("Timestamp", Namespace = XmlNamespaces.WsSecurityUtilityNs, Order = 1)]
        public SoapTimestamp? Timestamp { get; set; }
    }
}