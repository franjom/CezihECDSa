using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("SlanjeNarudzbenicaResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WSlanjeNarudzbenicaResponse
    {
        public WSlanjeNarudzbenicaResponse()
        {
        }

        public WSlanjeNarudzbenicaResponse(
            SlanjeNarudzbenicaResponseSlanjeNarudzbenicaResult result)
        {
            Result = result;
        }

        [XmlElement("SlanjeNarudzbenicaResult", Order = 0)]
        public SlanjeNarudzbenicaResponseSlanjeNarudzbenicaResult Result { get; set; }
    }
}