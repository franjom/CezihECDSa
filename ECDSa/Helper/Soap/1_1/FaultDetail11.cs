using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_1
{
    public class FaultDetail11
    {
        [XmlElement(ElementName = "errorcode", Namespace = "")]
        public string ErrorCode { get; set; }
    }
}