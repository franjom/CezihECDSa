using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_2
{
    [XmlRoot(ElementName = "Envelope", Namespace = SoapEnvelopeHelper.SoapNs12)]
    public class Envelope12
    {
        [XmlNamespaceDeclarations] 
        public XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();

        public Envelope12()
        {
            xmlns.Add("env", SoapEnvelopeHelper.SoapNs12);
            xmlns.Add("ws", "http://ws.cezih.hr/error");
        }

        [XmlElement(ElementName = "Body", Namespace = SoapEnvelopeHelper.SoapNs12)]
        public Body12 Body { get; set; }
    }
}