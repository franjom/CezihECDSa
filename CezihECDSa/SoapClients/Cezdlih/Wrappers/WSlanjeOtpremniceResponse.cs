using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("SlanjeOtpremniceResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WSlanjeOtpremniceResponse
    {
        public WSlanjeOtpremniceResponse()
        {
        }

        public WSlanjeOtpremniceResponse(
            SlanjeOtpremniceResponseSlanjeOtpremniceResult result)
        {
            Result = result;
        }

        [XmlElement("SlanjeOtpremniceResult", Order = 0)]
        public SlanjeOtpremniceResponseSlanjeOtpremniceResult Result { get; set; }
    }
}