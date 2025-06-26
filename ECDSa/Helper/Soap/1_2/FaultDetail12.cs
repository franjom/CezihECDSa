using System.Collections.Generic;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_2
{
    public class FaultDetail12
    {
        public FaultDetail12()
        {
            Errors = new List<WsError>();
        }

        [XmlElement(ElementName = "error", Namespace = "http://ws.cezih.hr/error")]
        public List<WsError> Errors { get; set; }
    }
}