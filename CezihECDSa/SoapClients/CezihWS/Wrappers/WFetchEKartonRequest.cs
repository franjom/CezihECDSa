using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchEKarton", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchEKartonRequest
    {
        public WFetchEKartonRequest() { }

        public WFetchEKartonRequest(string eKartonRequest)
        {
            EKartonRequest = eKartonRequest;
        }

        [XmlElement("EKartonRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public string EKartonRequest { get; set; }
    }
}