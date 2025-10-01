using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("RezultatObradeRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchRezultatObradeRequest
    {
        public WFetchRezultatObradeRequest() { }

        public WFetchRezultatObradeRequest(string rezultatObradeRequest)
        {
            this.Podatak = rezultatObradeRequest;
        }

        [XmlText]
        public string Podatak { get; set; }
    }
}