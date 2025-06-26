using System.Xml.Serialization;

namespace ECDSa.Helper.Soap
{
    public class FaultReason
    {
        [XmlElement(ElementName = "Text", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public string Text { get; set; }
    }
}