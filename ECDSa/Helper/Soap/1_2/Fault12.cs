using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_2
{
    public class Fault12
    {
        [XmlElement(ElementName = "Code", Namespace = SoapEnvelopeHelper.SoapNs12)]
        public FaultCode12 Code { get; set; }

        [XmlElement(ElementName = "Reason", Namespace = SoapEnvelopeHelper.SoapNs12)]
        public FaultReason12 Reason { get; set; }

        [XmlElement(ElementName = "Detail", Namespace = SoapEnvelopeHelper.SoapNs12)]
        public FaultDetail12 Detail { get; set; }
    }
}