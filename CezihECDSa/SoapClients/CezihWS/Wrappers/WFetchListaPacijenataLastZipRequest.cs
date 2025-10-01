using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchListaPacijenataLastZip", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchListaPacijenataLastZipRequest
    {
        public WFetchListaPacijenataLastZipRequest() { }

        public WFetchListaPacijenataLastZipRequest(object listaPacijenataLastZipRequest)
        {
            ListaPacijenataLastZipRequest = listaPacijenataLastZipRequest;
        }

        [XmlElement("ListaPacijenataLastZipRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public object ListaPacijenataLastZipRequest { get; set; }
    }
}