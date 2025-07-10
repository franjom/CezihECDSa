using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("SlanjeZip", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WSlanjeZipRequest
    {
        public WSlanjeZipRequest()
        {
        }

        public WSlanjeZipRequest(SlanjeZipSlanjeZipRequest request)
        {
            Request = request;
        }

        [XmlElement("SlanjeZipRequest", Order = 0)]
        public SlanjeZipSlanjeZipRequest Request { get; set; }
    }
}