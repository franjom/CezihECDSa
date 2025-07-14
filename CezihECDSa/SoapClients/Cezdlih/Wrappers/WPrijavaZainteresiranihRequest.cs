using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("PrijavaZainteresiranih", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WPrijavaZainteresiranihRequest
    {
        public WPrijavaZainteresiranihRequest() { }

        public WPrijavaZainteresiranihRequest(PrijavaZainteresiranihPrijavaZainteresiranihRequest request)
        {
            Request = request;
        }

        [XmlElement("PrijavaZainteresiranihRequest", Order = 0)]
        public PrijavaZainteresiranihPrijavaZainteresiranihRequest Request { get; set; }
    }
}