using System.Collections.Generic;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap
{
    public class FaultDetail
    {
        public FaultDetail()
        {
            Errors = new List<WsError>();
        }

        [XmlElement(ElementName = "error", Namespace = "http://ws.cezih.hr/error")]
        public List<WsError> Errors { get; set; }
    }
}