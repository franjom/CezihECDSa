using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchOtisliPacijentiListResponse", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchOtisliPacijentiListResponse
    {
        public WFetchOtisliPacijentiListResponse() { }
        public WFetchOtisliPacijentiListResponse(ListaOtisliPacijentiListResponse output) => Output = output;

        [XmlElement("fetchOtisliPacijentiListResult", Order = 0)]
        public ListaOtisliPacijentiListResponse Output { get; set; }
    }
}