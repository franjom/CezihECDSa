using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("SlanjeOtpremnice", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WSlanjeOtpremniceRequest
    {
        public WSlanjeOtpremniceRequest()
        {
        }

        public WSlanjeOtpremniceRequest(SlanjeOtpremniceSlanjeOtpremniceRequest request)
        {
            Request = request;
        }

        [XmlElement("SlanjeOtpremniceRequest", Order = 0)]
        public SlanjeOtpremniceSlanjeOtpremniceRequest Request { get; set; }
    }
}