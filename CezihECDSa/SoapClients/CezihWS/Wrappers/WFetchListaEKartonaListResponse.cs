using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ListaEKartonaListResponse", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WFetchListaEKartonaListResponse
    {
        public WFetchListaEKartonaListResponse() { }

        public WFetchListaEKartonaListResponse(string[] imeDatoteke)
        {
            this.imeDatoteke = imeDatoteke;
        }

        [XmlElement("imeDatoteke")]
        public string[] imeDatoteke { get; set; }
    }
}