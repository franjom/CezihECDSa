using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ListaOtisliPacijentiListResponse", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WFetchListaOtisliPacijentiListResponse
    {
        public WFetchListaOtisliPacijentiListResponse() { }

        public WFetchListaOtisliPacijentiListResponse(string[] imeDatoteke)
        {
            this.imeDatoteke = imeDatoteke;
        }

        [XmlElement("imeDatoteke")]
        public string[] imeDatoteke { get; set; }
    }
}