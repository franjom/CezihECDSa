using System.Xml.Serialization;

namespace ECDSa.Helper.Soap
{
    public class Fault
    {
        [XmlElement(ElementName = "Code", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public FaultCode Code { get; set; }

        [XmlElement(ElementName = "Reason", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public FaultReason Reason { get; set; }

        [XmlElement(ElementName = "Detail", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public FaultDetail Detail { get; set; }
    }
}