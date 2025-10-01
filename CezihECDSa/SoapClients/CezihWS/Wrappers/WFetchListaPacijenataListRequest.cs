using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchListaPacijenataList", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchListaPacijenataListRequest
    {
        public WFetchListaPacijenataListRequest() { }

        public WFetchListaPacijenataListRequest(string listaPacijenataListRequest)
        {
            ListaPacijenataListRequest = listaPacijenataListRequest;
        }

        [XmlElement("ListaPacijenataListRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public string ListaPacijenataListRequest { get; set; }
    }
}