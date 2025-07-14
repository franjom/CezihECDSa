using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("SlanjeNarudzbenica", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WSlanjeNarudzbenicaRequest
    {
        public WSlanjeNarudzbenicaRequest()
        {
        }

        public WSlanjeNarudzbenicaRequest(SlanjeNarudzbenicaSlanjeNarudzbenicaRequest request)
        {
            Request = request;
        }

        [XmlElement("SlanjeNarudzbenicaRequest", Order = 0)]
        public SlanjeNarudzbenicaSlanjeNarudzbenicaRequest Request { get; set; }
    }
}