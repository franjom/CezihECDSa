using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("arhivirajEKarton", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WArhivirajEKartonRequest
    {
        public WArhivirajEKartonRequest() { }

        public WArhivirajEKartonRequest(string arhivirajEKartonRequest)
        {
            ArhivirajEKartonRequest = arhivirajEKartonRequest;
        }

        [XmlElement("ArhivirajEKartonRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public string ArhivirajEKartonRequest { get; set; }
    }
}