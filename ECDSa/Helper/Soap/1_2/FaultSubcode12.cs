using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_2
{
    public class FaultSubcode12
    {
        [XmlElement(ElementName = "Value", Namespace = SoapEnvelopeHelper.SoapNs12)]
        public string Value { get; set; }
    }
}