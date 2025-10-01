using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchOtisliPacijentiResponse", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchOtisliPacijentiResponse
    {
        public WFetchOtisliPacijentiResponse() { }
        public WFetchOtisliPacijentiResponse(OtisliPacijentiResponse output) => Output = output;

        [XmlElement("fetchOtisliPacijentiResult", Order = 0)]
        public OtisliPacijentiResponse Output { get; set; }
    }
}