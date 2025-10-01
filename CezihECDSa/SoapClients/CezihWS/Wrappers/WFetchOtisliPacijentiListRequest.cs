using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchOtisliPacijentiList", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchOtisliPacijentiListRequest
    {
        public WFetchOtisliPacijentiListRequest() { }

        public WFetchOtisliPacijentiListRequest(string listaOtisliPacijentiListRequest)
        {
            ListaOtisliPacijentiListRequest = listaOtisliPacijentiListRequest;
        }

        [XmlElement("ListaOtisliPacijentiListRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public string ListaOtisliPacijentiListRequest { get; set; }
    }
}