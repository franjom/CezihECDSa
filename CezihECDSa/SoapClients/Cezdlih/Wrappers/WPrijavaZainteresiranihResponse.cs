using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("PrijavaZainteresiranihResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WPrijavaZainteresiranihResponse
    {
        public WPrijavaZainteresiranihResponse() { }

        public WPrijavaZainteresiranihResponse(PrijavaZainteresiranihResponsePrijavaZainteresiranihResult result)
        {
            Result = result;
        }

        [XmlElement("PrijavaZainteresiranihResult", Order = 0)]
        public PrijavaZainteresiranihResponsePrijavaZainteresiranihResult Result { get; set; }
    }
}