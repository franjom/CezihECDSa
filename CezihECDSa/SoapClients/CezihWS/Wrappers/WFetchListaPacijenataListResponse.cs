using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchListaPacijenataListResponse", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchListaPacijenataListResponse
    {
        public WFetchListaPacijenataListResponse() { }
        public WFetchListaPacijenataListResponse(ListaPacijenataListResponse output) => Output = output;

        [XmlElement("fetchListaPacijenataListResult", Order = 0)]
        public ListaPacijenataListResponse Output { get; set; }
    }
}