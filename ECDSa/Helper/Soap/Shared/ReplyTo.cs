using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Shared
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.AddressingNs)]
    [XmlRoot("ReplyTo", Namespace = XmlNamespaces.AddressingNs)]
    public sealed class ReplyTo
    {
        [XmlElement("Address", Namespace = XmlNamespaces.AddressingNs)]
        public string Address { get; set; }
    }
}