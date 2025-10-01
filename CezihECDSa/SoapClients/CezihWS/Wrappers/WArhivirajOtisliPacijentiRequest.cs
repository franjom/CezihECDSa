using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("arhivirajOtisliPacijenti", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WArhivirajOtisliPacijentiRequest
    {
        public WArhivirajOtisliPacijentiRequest() { }

        public WArhivirajOtisliPacijentiRequest(string arhivirajOtisliPacijentiRequest)
        {
            ArhivirajOtisliPacijentiRequest = arhivirajOtisliPacijentiRequest;
        }

        [XmlElement("ArhivirajOtisliPacijentiRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public string ArhivirajOtisliPacijentiRequest { get; set; }
    }
}