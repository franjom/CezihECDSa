using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_2
{
    public class WsError
    {
        [XmlElement(ElementName = "code", Namespace = "")]
        public string Code { get; set; }

        [XmlElement(ElementName = "description", Namespace = "")]
        public string Description { get; set; }
    }
}