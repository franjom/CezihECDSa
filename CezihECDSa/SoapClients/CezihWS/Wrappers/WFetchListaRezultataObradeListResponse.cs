using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ListaRezultataListResponse", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WFetchListaRezultataListResponse
    {
        public WFetchListaRezultataListResponse() { }

        public WFetchListaRezultataListResponse(string[] imeDatoteke)
        {
            this.imeDatoteke = imeDatoteke;
        }

        [XmlElement("imeDatoteke")]
        public string[] imeDatoteke { get; set; }
    }
}