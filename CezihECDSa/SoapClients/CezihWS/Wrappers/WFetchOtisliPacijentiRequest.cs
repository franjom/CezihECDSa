using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("OtisliPacijentiRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchOtisliPacijentiRequest
    {
        public WFetchOtisliPacijentiRequest() { }

        public WFetchOtisliPacijentiRequest(string otisliPacijentiRequest)
        {
            this.Podatak = otisliPacijentiRequest;
        }

        [XmlText]
        public string Podatak { get; set; }
    }
}