using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_2
{
    public class FaultReason12
    {
        [XmlElement(ElementName = "Text", Namespace = SoapEnvelopeHelper.SoapNs12)]
        public string Text { get; set; }
    }
}