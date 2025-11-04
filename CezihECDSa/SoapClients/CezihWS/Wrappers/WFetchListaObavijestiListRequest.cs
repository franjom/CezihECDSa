using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ListaObavijestiListRequest", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WFetchListaObavijestiListRequest
    {
        public WFetchListaObavijestiListRequest() { }

        public WFetchListaObavijestiListRequest(string listaObavijestiListRequest)
        {
            this.Podatak = listaObavijestiListRequest;
        }

        [XmlText]
        public string Podatak { get; set; }
    }
}