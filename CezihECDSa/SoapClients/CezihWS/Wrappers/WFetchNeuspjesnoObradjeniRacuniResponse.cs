using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchNeuspjesnoObradjeniRacuniResponse", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchNeuspjesnoObradjeniRacuniResponse
    {
        public WFetchNeuspjesnoObradjeniRacuniResponse() { }
        public WFetchNeuspjesnoObradjeniRacuniResponse(NeuspjesnoObradjeniRacuniResponse output) => Output = output;

        [XmlElement("fetchNeuspjesnoObradjeniRacuniResult", Order = 0)]
        public NeuspjesnoObradjeniRacuniResponse Output { get; set; }
    }
}