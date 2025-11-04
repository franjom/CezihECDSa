using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchListaPacijenataLastZipResponse", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchListaPacijenataLastZipResponse
    {
        public WFetchListaPacijenataLastZipResponse() { }
        public WFetchListaPacijenataLastZipResponse(ListaPacijenataLastZipResponse output) => Output = output;

        [XmlElement("fetchListaPacijenataLastZipResult", Order = 0)]
        public ListaPacijenataLastZipResponse Output { get; set; }
    }
}