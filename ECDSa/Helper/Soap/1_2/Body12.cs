using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_2
{
    public class Body12
    {
        [XmlElement(ElementName = "Fault", Namespace = SoapEnvelopeHelper.SoapNs12)]
        public Fault12 Fault { get; set; }
    }
}