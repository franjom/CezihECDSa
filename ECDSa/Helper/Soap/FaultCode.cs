using System.Xml.Serialization;

namespace ECDSa.Helper.Soap
{
    public class FaultCode
    {
        [XmlElement(ElementName = "Value", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public string Value { get; set; }

        [XmlElement(ElementName = "Subcode", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public FaultSubcode Subcode { get; set; }
    }
}