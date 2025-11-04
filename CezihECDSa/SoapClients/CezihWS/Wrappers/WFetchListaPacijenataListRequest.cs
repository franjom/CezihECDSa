using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ListaPacijenataListRequest", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WFetchListaPacijenataListRequest
    {
        public WFetchListaPacijenataListRequest() { }

        public WFetchListaPacijenataListRequest(string listaPacijenataListRequest)
        {
            this.Podatak = listaPacijenataListRequest;
        }

        [XmlText]
        public string Podatak { get; set; }
    }
}