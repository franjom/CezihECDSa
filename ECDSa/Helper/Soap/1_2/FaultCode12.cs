using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_2
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.SoapNs12)]
    [XmlRoot("FaultCode", Namespace = XmlNamespaces.SoapNs12)]
    public class FaultCode12
    {
        [XmlElement(ElementName = "Value", Namespace = XmlNamespaces.SoapNs12)]
        public string Value { get; set; }

        [XmlElement(ElementName = "Subcode", Namespace = XmlNamespaces.SoapNs12)]
        public FaultSubcode12 Subcode { get; set; }
    }
}