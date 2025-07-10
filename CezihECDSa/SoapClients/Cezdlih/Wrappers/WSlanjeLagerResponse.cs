using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("SlanjeLagerResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WSlanjeLagerResponse
    {
        public WSlanjeLagerResponse()
        {
        }

        public WSlanjeLagerResponse(
            SlanjeLagerResponseSlanjeLagerResult result)
        {
            Result = result;
        }

        [XmlElement("SlanjeLagerResult", Order = 0)]
        public SlanjeLagerResponseSlanjeLagerResult Result { get; set; }
    }
}