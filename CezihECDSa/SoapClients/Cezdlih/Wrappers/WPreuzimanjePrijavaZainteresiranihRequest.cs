using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("PreuzimanjePrijavaZainteresiranih", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WPreuzimanjePrijavaZainteresiranihRequest
    {
        public WPreuzimanjePrijavaZainteresiranihRequest()
        {
        }

        public WPreuzimanjePrijavaZainteresiranihRequest(PreuzimanjePrijavaZainteresiranihPreuzimanjePrijavaZainteresiranihRequest request)
        {
            Request = request;
        }

        [XmlElement("PreuzimanjePrijavaZainteresiranihRequest", Order = 0)]
        public PreuzimanjePrijavaZainteresiranihPreuzimanjePrijavaZainteresiranihRequest Request { get; set; }
    }
}