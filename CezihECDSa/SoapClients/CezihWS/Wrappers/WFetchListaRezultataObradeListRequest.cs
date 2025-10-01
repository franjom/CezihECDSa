using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchListaRezultataObradeList", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchListaRezultataObradeListRequest
    {
        public WFetchListaRezultataObradeListRequest() { }

        public WFetchListaRezultataObradeListRequest(string listaRezultataListRequest)
        {
            ListaRezultataListRequest = listaRezultataListRequest;
        }

        [XmlElement("ListaRezultataListRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public string ListaRezultataListRequest { get; set; }
    }
}