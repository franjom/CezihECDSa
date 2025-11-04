using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("EKartonRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchEKartonRequest
    {
        public WFetchEKartonRequest() { }

        public WFetchEKartonRequest(string eKartonRequest)
        {
            this.Podatak = eKartonRequest;
        }

        [XmlText]
        public string Podatak { get; set; }
    }
}