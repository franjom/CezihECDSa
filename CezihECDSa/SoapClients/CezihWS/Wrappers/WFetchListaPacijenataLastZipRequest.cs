using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ListaPacijenataLastZipRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchListaPacijenataLastZipRequest
    {
        public WFetchListaPacijenataLastZipRequest() { }

        public WFetchListaPacijenataLastZipRequest(object listaPacijenataLastZipRequest)
        {
            this.Podatak = listaPacijenataLastZipRequest;
        }

        [XmlAnyElement]
        public object Podatak { get; set; }
    }
}