using System;
using System.Xml.Serialization;
using ECDSa.Helper.Soap.Shared;

namespace ECDSa.Helper.Soap._1_1
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.SoapNs11)]
    [XmlRoot("Header", Namespace = XmlNamespaces.SoapNs11, IsNullable = false)]
    public class Header11
    {
        [XmlElement("Action", Namespace = XmlNamespaces.AddressingNs, Order = 2)]
        public SoapAction11? Action { get; set; }

        [XmlElement("Security", Namespace = XmlNamespaces.WsSecuritySecextNs, Order = 5)]
        public SoapSecurity? Security { get; set; }

        [XmlElement("MessageID", Namespace = XmlNamespaces.AddressingNs, Order = 1)]
        public string? MessageId { get; set; }

        [XmlElement("To", Namespace = XmlNamespaces.AddressingNs, Order = 3)]
        public string? To { get; set; }

        [XmlElement("ReplyTo", Namespace = XmlNamespaces.AddressingNs, Order = 4)]
        public ReplyTo? ReplyTo { get; set; }
    }

    [Serializable]
    [XmlType(Namespace = XmlNamespaces.SoapNs11)]
    [XmlRoot("Action", Namespace = XmlNamespaces.SoapNs11)]
    public class SoapAction11
    {
        [XmlAttribute("mustUnderstand", Namespace = XmlNamespaces.SoapNs11)]
        public string MustUnderstand { get; set; } = "1";

        [XmlText]
        public string Value { get; set; }
    }
}