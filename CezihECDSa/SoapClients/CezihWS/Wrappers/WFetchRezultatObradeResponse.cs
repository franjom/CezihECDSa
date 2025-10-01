using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchRezultatObradeResponse", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchRezultatObradeResponse
    {
        public WFetchRezultatObradeResponse() { }
        public WFetchRezultatObradeResponse(RezultatObradeResponse output) => Output = output;

        [XmlElement("fetchRezultatObradeResult", Order = 0)]
        public RezultatObradeResponse Output { get; set; }
    }
}