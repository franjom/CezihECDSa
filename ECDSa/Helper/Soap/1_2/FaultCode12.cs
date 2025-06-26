using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_2
{
    public class FaultCode12
    {
        [XmlElement(ElementName = "Value", Namespace = SoapEnvelopeHelper.SoapNs12)]
        public string Value { get; set; }

        [XmlElement(ElementName = "Subcode", Namespace = SoapEnvelopeHelper.SoapNs12)]
        public FaultSubcode12 Subcode { get; set; }
    }
}