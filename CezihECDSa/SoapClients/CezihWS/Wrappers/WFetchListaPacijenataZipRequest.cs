using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ListaPacijenataZipRequest", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WFetchListaPacijenataZipRequest
    {
        public WFetchListaPacijenataZipRequest() { }

        public WFetchListaPacijenataZipRequest(string listaPacijenataZipRequest)
        {
            this.Podatak = listaPacijenataZipRequest;
        }

        [XmlText]
        public string Podatak { get; set; }
    }
}