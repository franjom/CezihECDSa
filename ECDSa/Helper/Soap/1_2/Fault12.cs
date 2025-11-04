using System;
using System.Xml;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_2
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.SoapNs12)]
    [XmlRoot("Fault", Namespace = XmlNamespaces.SoapNs12)]
    public class Fault12
    {
        [XmlElement(ElementName = "Code", Namespace = XmlNamespaces.SoapNs12)]
        public FaultCode12 Code { get; set; }

        [XmlElement(ElementName = "Reason", Namespace = XmlNamespaces.SoapNs12)]
        public FaultReason12 Reason { get; set; }

        [XmlElement("Node")]
        public string Node { get; set; }

        [XmlElement("Role")]
        public string Role { get; set; }

        [XmlElement("Detail")]
        public XmlElement Detail { get; set; }
    }
}