using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchListaPacijenataZip", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchListaPacijenataZipRequest
    {
        public WFetchListaPacijenataZipRequest() { }

        public WFetchListaPacijenataZipRequest(string listaPacijenataZipRequest)
        {
            ListaPacijenataZipRequest = listaPacijenataZipRequest;
        }

        [XmlElement("ListaPacijenataZipRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public string ListaPacijenataZipRequest { get; set; }
    }
}