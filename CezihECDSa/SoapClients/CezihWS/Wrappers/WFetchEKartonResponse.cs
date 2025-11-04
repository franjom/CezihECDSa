using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchEKartonResponse", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchEKartonResponse
    {
        public WFetchEKartonResponse() { }
        public WFetchEKartonResponse(EKartonResponse output) => Output = output;

        [XmlElement("fetchEKartonResult", Order = 0)]
        public EKartonResponse Output { get; set; }
    }
}