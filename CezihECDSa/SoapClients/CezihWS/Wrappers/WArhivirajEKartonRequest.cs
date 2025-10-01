using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ArhivirajEKartonRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WArhivirajEKartonRequest
    {
        public WArhivirajEKartonRequest() { }

        public WArhivirajEKartonRequest(string arhivirajEKartonRequest)
        {
            this.Podatak = arhivirajEKartonRequest;
        }

        [XmlText]
        public string Podatak { get; set; }
    }
}