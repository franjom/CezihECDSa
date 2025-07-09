using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("PreuzimanjeOtpremnice", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WPreuzimanjeOtpremniceRequest
    {
        public WPreuzimanjeOtpremniceRequest()
        {
        }

        public WPreuzimanjeOtpremniceRequest(PreuzimanjeOtpremnicePreuzimanjeOtpremniceRequest request)
        {
            Request = request;
        }

        [XmlElement("PreuzimanjeOtpremniceRequest", Order = 0)]
        public PreuzimanjeOtpremnicePreuzimanjeOtpremniceRequest Request { get; set; }
    }
}