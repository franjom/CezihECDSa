using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ArhivirajOtisliPacijentiRequest", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WArhivirajOtisliPacijentiRequest
    {
        public WArhivirajOtisliPacijentiRequest() { }

        public WArhivirajOtisliPacijentiRequest(string arhivirajOtisliPacijentiRequest)
        {
            this.Podatak = arhivirajOtisliPacijentiRequest;
        }

        [XmlText]
        public string Podatak { get; set; }
    }
}