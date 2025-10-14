using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ListaPacijenataListResponse", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WFetchListaPacijenataListResponse
    {

        public WFetchListaPacijenataListResponse() { }

        public WFetchListaPacijenataListResponse(string[] imeMape)
        {
            this.imeMape = imeMape;
        }

        [XmlElement("imeMape")]
        public string[] imeMape { get; set; }
    }
}