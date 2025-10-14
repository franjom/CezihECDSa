using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ListaPacijenataLastZipRequest", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WFetchListaPacijenataLastZipRequest
    {
        public WFetchListaPacijenataLastZipRequest() { }

        public WFetchListaPacijenataLastZipRequest(string listaPacijenataLastZipRequest)
        {
            this.Podatak = listaPacijenataLastZipRequest;
        }

        [XmlText]
        public string Podatak { get; set; }
    }
}