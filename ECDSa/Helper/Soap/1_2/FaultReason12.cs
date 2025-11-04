using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_2
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.SoapNs12)]
    [XmlRoot("FaultReason", Namespace = XmlNamespaces.SoapNs12)]
    public class FaultReason12
    {
        [XmlElement("Text", Namespace = XmlNamespaces.SoapNs12)]
        public List<Soap12FaultText> Text { get; set; } = new();
    }
}