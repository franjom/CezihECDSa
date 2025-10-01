using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchListaObavijestiListResponse", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchListaObavijestiListResponse
    {
        public WFetchListaObavijestiListResponse() { }
        public WFetchListaObavijestiListResponse(ListaObavijestiListResponse output) => Output = output;

        [XmlElement("fetchListaObavijestiListResult", Order = 0)]
        public ListaObavijestiListResponse Output { get; set; }
    }
}