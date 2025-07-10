using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("OtkazivanjePrijavaZainteresiranihResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WOtkazivanjePrijavaZainteresiranihResponse
    {
        public WOtkazivanjePrijavaZainteresiranihResponse()
        {
        }

        public WOtkazivanjePrijavaZainteresiranihResponse(
            OtkazivanjePrijavaZainteresiranihResponseOtkazivanjePrijavaZainteresiranihResult result)
        {
            Result = result;
        }

        [XmlElement("OtkazivanjePrijavaZainteresiranihResult", Order = 0)]
        public OtkazivanjePrijavaZainteresiranihResponseOtkazivanjePrijavaZainteresiranihResult Result { get; set; }
    }
}