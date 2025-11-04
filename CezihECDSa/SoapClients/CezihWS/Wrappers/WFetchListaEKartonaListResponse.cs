using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchListaEKartonaListResponse", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchListaEKartonaListResponse
    {
        public WFetchListaEKartonaListResponse() { }
        public WFetchListaEKartonaListResponse(ListaEKartonaListResponse output) => Output = output;

        [XmlElement("fetchListaEKartonaListResult", Order = 0)]
        public ListaEKartonaListResponse Output { get; set; }
    }
}