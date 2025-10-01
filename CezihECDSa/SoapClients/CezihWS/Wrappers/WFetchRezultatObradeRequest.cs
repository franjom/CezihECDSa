using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchRezultatObrade", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchRezultatObradeRequest
    {
        public WFetchRezultatObradeRequest() { }

        public WFetchRezultatObradeRequest(string rezultatObradeRequest)
        {
            RezultatObradeRequest = rezultatObradeRequest;
        }

        [XmlElement("RezultatObradeRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public string RezultatObradeRequest { get; set; }
    }
}