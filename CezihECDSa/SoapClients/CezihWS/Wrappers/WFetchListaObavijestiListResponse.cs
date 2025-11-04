using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ListaObavijestiListResponse", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WFetchListaObavijestiListResponse
    {
        public WFetchListaObavijestiListResponse() { }

        public WFetchListaObavijestiListResponse(string[] imeDatoteke)
        {
            this.imeDatoteke = imeDatoteke;
        }

        [XmlElement("imeDatoteke")]
        public string[] imeDatoteke { get; set; }
    }
}