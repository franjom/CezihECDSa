using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("OtkazivanjePrijavaZainteresiranih", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WOtkazivanjePrijavaZainteresiranihRequest
    {
        public WOtkazivanjePrijavaZainteresiranihRequest()
        {
        }

        public WOtkazivanjePrijavaZainteresiranihRequest(OtkazivanjePrijavaZainteresiranihOtkazivanjePrijavaZainteresiranihRequest request)
        {
            Request = request;
        }

        [XmlElement("OtkazivanjePrijavaZainteresiranihRequest", Order = 0)]
        public OtkazivanjePrijavaZainteresiranihOtkazivanjePrijavaZainteresiranihRequest Request { get; set; }
    }
}