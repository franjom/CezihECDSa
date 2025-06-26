using System.Xml.Serialization;

namespace ECDSa.Helper.Soap
{
    public class Body
    {
        [XmlElement(ElementName = "Fault", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public Fault Fault { get; set; }
    }
}