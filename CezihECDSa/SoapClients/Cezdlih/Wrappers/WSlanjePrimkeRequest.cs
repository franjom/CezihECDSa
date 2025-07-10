using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("SlanjePrimke", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WSlanjePrimkeRequest
    {
        public WSlanjePrimkeRequest()
        {
        }

        public WSlanjePrimkeRequest(SlanjePrimkeSlanjePrimkeRequest request)
        {
            Request = request;
        }

        [XmlElement("SlanjePrimkeRequest", Order = 0)]
        public SlanjePrimkeSlanjePrimkeRequest Request { get; set; }
    }
}