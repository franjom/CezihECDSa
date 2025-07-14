using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("SlanjeLager", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WSlanjeLagerRequest
    {
        public WSlanjeLagerRequest()
        {
        }

        public WSlanjeLagerRequest(SlanjeLagerSlanjeLagerRequest request)
        {
            Request = request;
        }

        [XmlElement("SlanjeLagerRequest", Order = 0)]
        public SlanjeLagerSlanjeLagerRequest Request { get; set; }
    }
}