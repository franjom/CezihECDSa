using CezihECDSa.Wsdl;
using CezihECDSa.Wsdl.OsigInfo;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("StatusLijecenjaPacijentaResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public sealed class WStatusLijecenjaPacijentaResponse
    {
        public WStatusLijecenjaPacijentaResponse() { }

        public WStatusLijecenjaPacijentaResponse(StatusLijecenjaPacijentaResponseStatusLijecenjaPacijentaResult result)
        {
            Result = result;
        }

        [XmlElement("StatusLijecenjaPacijentaResult", Order = 0)]
        public StatusLijecenjaPacijentaResponseStatusLijecenjaPacijentaResult Result { get; set; }
    }
}