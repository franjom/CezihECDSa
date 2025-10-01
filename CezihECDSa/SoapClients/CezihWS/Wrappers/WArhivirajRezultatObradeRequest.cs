using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ArhivirajRezultatObradeRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WArhivirajRezultatObradeRequest
    {
        public WArhivirajRezultatObradeRequest() { }

        public WArhivirajRezultatObradeRequest(string arhivirajRezultatObradeRequest)
        {
            this.Podatak = arhivirajRezultatObradeRequest;
        }

        [XmlText]
        public string Podatak { get; set; }
    }
}