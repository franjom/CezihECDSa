using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Shared
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.WsSecuritySecextNs)]
    [XmlRoot("BinarySecurityToken", Namespace = XmlNamespaces.WsSecuritySecextNs)]
    public sealed class SecurityToken
    {
        [XmlAttribute("EncodingType")]
        public string EncodingType { get; set; }

        [XmlAttribute("ValueType")]
        public string ValueType { get; set; }

        [XmlAttribute("Id", Namespace = XmlNamespaces.WsSecurityUtilityNs)]
        public string? Id { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}