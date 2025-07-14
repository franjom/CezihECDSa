using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("PreuzimanjeOtpremniceResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WPreuzimanjeOtpremniceResponse
    {
        public WPreuzimanjeOtpremniceResponse()
        {
        }

        public WPreuzimanjeOtpremniceResponse(
            PreuzimanjeOtpremniceResponsePreuzimanjeOtpremniceResult result)
        {
            Result = result;
        }

        [XmlElement("PreuzimanjeOtpremniceResult", Order = 0)]
        public PreuzimanjeOtpremniceResponsePreuzimanjeOtpremniceResult Result { get; set; }
    }
}