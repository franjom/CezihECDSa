using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_1
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.SoapNs11)]
    [XmlRoot("Fault", Namespace = XmlNamespaces.SoapNs11)]
    public class Fault11
    {
        [XmlElement(ElementName = "faultcode", Namespace = "")]
        public string FaultCode { get; set; }

        [XmlElement(ElementName = "faultstring", Namespace = "")]
        public string FaultString { get; set; }

        [XmlElement(ElementName = "detail", Namespace = "")]
        public FaultDetail11 Detail { get; set; }
    }
}