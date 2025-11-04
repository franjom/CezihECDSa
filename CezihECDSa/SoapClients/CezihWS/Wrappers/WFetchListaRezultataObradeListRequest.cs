using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ListaRezultataListRequest", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WFetchListaRezultataObradeListRequest
    {
        public WFetchListaRezultataObradeListRequest() { }

        public WFetchListaRezultataObradeListRequest(string listaRezultataListRequest)
        {
            this.Podatak = listaRezultataListRequest;
        }

        [XmlText]
        public string Podatak { get; set; }
    }
}