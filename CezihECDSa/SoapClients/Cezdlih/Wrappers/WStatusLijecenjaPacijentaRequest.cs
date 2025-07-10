using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("StatusLijecenjaPacijenta", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public sealed class WStatusLijecenjaPacijentaRequest
    {
        public WStatusLijecenjaPacijentaRequest() { }

        public WStatusLijecenjaPacijentaRequest(StatusLijecenjaPacijentaZahtjevZaStatusLijecenjaPacijenta request)
        {
            Zahtjev = request;
        }

        [XmlElement("ZahtjevZaStatusLijecenjaPacijenta", Order = 0)]
        public StatusLijecenjaPacijentaZahtjevZaStatusLijecenjaPacijenta Zahtjev { get; set; }
    }
}