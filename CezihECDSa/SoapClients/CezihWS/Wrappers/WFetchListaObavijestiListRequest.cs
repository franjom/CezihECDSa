using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchListaObavijestiList", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchListaObavijestiListRequest
    {
        public WFetchListaObavijestiListRequest() { }

        public WFetchListaObavijestiListRequest(string listaObavijestiListRequest)
        {
            ListaObavijestiListRequest = listaObavijestiListRequest;
        }

        [XmlElement("ListaObavijestiListRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public string ListaObavijestiListRequest { get; set; }
    }
}