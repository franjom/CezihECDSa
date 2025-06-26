using System.Xml.Serialization;

namespace ECDSa.Helper.Soap
{
    [XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public class Envelope
    {
        [XmlNamespaceDeclarations] 
        public XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();

        public Envelope()
        {
            xmlns.Add("env", "http://www.w3.org/2003/05/soap-envelope");
            xmlns.Add("ws", "http://ws.cezih.hr/error");
        }

        [XmlElement(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public Body Body { get; set; }
    }
}