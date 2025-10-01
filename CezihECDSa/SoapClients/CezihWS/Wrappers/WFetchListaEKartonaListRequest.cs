using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchListaEKartonaList", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchListaEKartonaListRequest
    {
        public WFetchListaEKartonaListRequest() { }

        public WFetchListaEKartonaListRequest(string listaEKartonaListRequest)
        {
            ListaEKartonaListRequest = listaEKartonaListRequest;
        }

        [XmlElement("ListaEKartonaListRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public string ListaEKartonaListRequest { get; set; }
    }
}