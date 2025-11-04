using System;
using System.Xml.Serialization;
using ECDSa.Helper.Soap.Shared;

namespace ECDSa.Helper.Soap._1_2
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.SoapNs12)]
    [XmlRoot("Header", Namespace = XmlNamespaces.SoapNs12, IsNullable = false)]
    public class Header12
    {
        [XmlElement("Action", Namespace = XmlNamespaces.AddressingNs)]
        public SoapAction12 Action { get; set; }

        [XmlElement("Security", Namespace = XmlNamespaces.WsSecuritySecextNs)]
        public SoapSecurity Security { get; set; }

        [XmlElement("MessageID", Namespace = XmlNamespaces.AddressingNs)]
        public string MessageId { get; set; }

        [XmlElement("To", Namespace = XmlNamespaces.AddressingNs)]
        public string To { get; set; }

        [XmlElement("ReplyTo", Namespace = XmlNamespaces.AddressingNs)]
        public ReplyTo ReplyTo { get; set; }
    }

    public class SoapAction12
    {
        [XmlAttribute("mustUnderstand", Namespace = XmlNamespaces.SoapNs12)]
        public string MustUnderstand { get; set; } = "1";

        [XmlText]
        public string Value { get; set; }
    }
}