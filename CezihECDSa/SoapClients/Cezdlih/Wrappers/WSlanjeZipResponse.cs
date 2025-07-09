using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("SlanjeZipResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WSlanjeZipResponse
    {
        public WSlanjeZipResponse()
        {
        }

        public WSlanjeZipResponse(
            SlanjeZipResponseSlanjeZipResult result)
        {
            Result = result;
        }

        [XmlElement("SlanjeZipResult", Order = 0)]
        public SlanjeZipResponseSlanjeZipResult Result { get; set; }
    }
}