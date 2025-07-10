using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("PreuzimanjeZipResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WPreuzimanjeZipResponse
    {
        public WPreuzimanjeZipResponse()
        {
        }

        public WPreuzimanjeZipResponse(
            PreuzimanjeZipResponsePreuzimanjeZipResult result)
        {
            Result = result;
        }

        [XmlElement("PreuzimanjeZipResult", Order = 0)]
        public PreuzimanjeZipResponsePreuzimanjeZipResult Result { get; set; }
    }
}