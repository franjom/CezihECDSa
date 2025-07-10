using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("PreuzimanjePrijavaZainteresiranihResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WPreuzimanjePrijavaZainteresiranihResponse
    {
        public WPreuzimanjePrijavaZainteresiranihResponse()
        {
        }

        public WPreuzimanjePrijavaZainteresiranihResponse(
            PreuzimanjePrijavaZainteresiranihResponsePreuzimanjePrijavaZainteresiranihResult result)
        {
            Result = result;
        }

        [XmlElement("PreuzimanjePrijavaZainteresiranihResult", Order = 0)]
        public PreuzimanjePrijavaZainteresiranihResponsePreuzimanjePrijavaZainteresiranihResult Result { get; set; }
    }
}