using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchListaRezultataObradeListResponse", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchListaRezultataObradeListResponse
    {
        public WFetchListaRezultataObradeListResponse() { }
        public WFetchListaRezultataObradeListResponse(ListaRezultataListResponse output) => Output = output;

        [XmlElement("fetchListaRezultataObradeListResult", Order = 0)]
        public ListaRezultataListResponse Output { get; set; }
    }
}