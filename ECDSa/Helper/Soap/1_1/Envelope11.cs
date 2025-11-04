using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_1
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.SoapNs11)]
    [XmlRoot(ElementName = "Envelope", Namespace = XmlNamespaces.SoapNs11, IsNullable = false)]
    public class Envelope11
    {
        [XmlElement(ElementName = "Header", Namespace = XmlNamespaces.SoapNs11)]
        public Header11? Header { get; set; }

        [XmlElement(ElementName = "Body", Namespace = XmlNamespaces.SoapNs11)]
        public Body11 Body { get; set; }
    }
}