using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchObavijestResponse", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchObavijestResponse
    {
        public WFetchObavijestResponse() { }
        public WFetchObavijestResponse(ObavijestResponse output) => Output = output;

        [XmlElement("fetchObavijestResult", Order = 0)]
        public ObavijestResponse Output { get; set; }
    }
}