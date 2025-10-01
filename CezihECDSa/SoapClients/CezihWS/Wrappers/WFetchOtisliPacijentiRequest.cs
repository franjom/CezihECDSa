using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchOtisliPacijenti", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchOtisliPacijentiRequest
    {
        public WFetchOtisliPacijentiRequest() { }

        public WFetchOtisliPacijentiRequest(string otisliPacijentiRequest)
        {
            OtisliPacijentiRequest = otisliPacijentiRequest;
        }

        [XmlElement("OtisliPacijentiRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public string OtisliPacijentiRequest { get; set; }
    }
}