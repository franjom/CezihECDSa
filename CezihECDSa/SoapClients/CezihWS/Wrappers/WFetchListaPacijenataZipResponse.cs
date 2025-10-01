using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchListaPacijenataZipResponse", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchListaPacijenataZipResponse
    {
        public WFetchListaPacijenataZipResponse() { }
        public WFetchListaPacijenataZipResponse(ListaPacijenataZipResponse output) => Output = output;

        [XmlElement("fetchListaPacijenataZipResult", Order = 0)]
        public ListaPacijenataZipResponse Output { get; set; }
    }
}