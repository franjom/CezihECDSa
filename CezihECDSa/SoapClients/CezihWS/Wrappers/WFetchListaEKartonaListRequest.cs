using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ListaEKartonaListRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchListaEKartonaListRequest
    {
        public WFetchListaEKartonaListRequest() { }

        public WFetchListaEKartonaListRequest(string listaEKartonaListRequest)
        {
            this.Podatak = listaEKartonaListRequest;
        }

        [XmlText]
        public string Podatak { get; set; }
    }
}