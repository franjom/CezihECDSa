using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_1
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.SoapNs11)]
    [XmlRoot("FaultDetil", Namespace = XmlNamespaces.SoapNs11)]
    public class FaultDetail11
    {
        [XmlElement(ElementName = "errorcode", Namespace = "")]
        public string ErrorCode { get; set; }
    }
}