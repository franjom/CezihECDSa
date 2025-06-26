using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_1
{
    [XmlRoot(ElementName = "Envelope", Namespace = SoapEnvelopeHelper.SoapNs11)]
    public class Envelope11
    {
        [XmlNamespaceDeclarations] 
        public XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();

        public Envelope11()
        {
            xmlns.Add("env", SoapEnvelopeHelper.SoapNs11);
        }

        [XmlElement(ElementName = "Body", Namespace = SoapEnvelopeHelper.SoapNs11)]
        public Body11 Body { get; set; }
    }
}