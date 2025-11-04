using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ObavijestRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchObavijestRequest
    {
        public WFetchObavijestRequest() { }

        public WFetchObavijestRequest(ObavijestRequest obavijestRequest)
        {
            this.ImeDatoteke = obavijestRequest.imeDatoteke;
        }

        [XmlElement("imeDatoteke")]
        public string[] ImeDatoteke { get; set; }
    }
}