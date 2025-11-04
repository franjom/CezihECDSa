using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_2
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.SoapNs12)]
    [XmlRoot(ElementName = "Envelope", Namespace = XmlNamespaces.SoapNs12, IsNullable = false)]
    public class Envelope12
    {
        [XmlElement(ElementName = "Header", Namespace = XmlNamespaces.SoapNs12)]
        public Header12? Header { get; set; }

        [XmlElement(ElementName = "Body", Namespace = XmlNamespaces.SoapNs12)]
        public Body12 Body { get; set; }
    }
}