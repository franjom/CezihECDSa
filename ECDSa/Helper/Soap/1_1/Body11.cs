using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_1
{
    public class Body11
    {
        [XmlElement(ElementName = "Fault", Namespace = SoapEnvelopeHelper.SoapNs11)]
        public Fault11 Fault { get; set; }
    }
}