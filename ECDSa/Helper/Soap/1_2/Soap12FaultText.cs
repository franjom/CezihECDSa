using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_2
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.SoapNs12)]
    public class Soap12FaultText
    {
        [XmlAttribute("lang", Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Lang { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}