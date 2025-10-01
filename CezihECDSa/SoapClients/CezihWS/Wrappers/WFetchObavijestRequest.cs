using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchObavijest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchObavijestRequest
    {
        public WFetchObavijestRequest() { }

        public WFetchObavijestRequest(ObavijestRequest obavijestRequest)
        {
            ObavijestRequest1 = obavijestRequest;
        }

        [XmlElement("ObavijestRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public ObavijestRequest ObavijestRequest1 { get; set; }
    }
}