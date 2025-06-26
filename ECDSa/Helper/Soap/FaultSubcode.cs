using System.Xml.Serialization;

namespace ECDSa.Helper.Soap
{
    public class FaultSubcode
    {
        [XmlElement(ElementName = "Value", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public string Value { get; set; }
    }
}