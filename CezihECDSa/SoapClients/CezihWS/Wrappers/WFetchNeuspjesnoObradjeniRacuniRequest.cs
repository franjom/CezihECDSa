using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchNeuspjesnoObradjeniRacuni", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WFetchNeuspjesnoObradjeniRacuniRequest
    {
        public WFetchNeuspjesnoObradjeniRacuniRequest() { }

        public WFetchNeuspjesnoObradjeniRacuniRequest(NeuspjesnoObradjeniRacuniRequest neuspjesnoObradjeniRacuniRequest)
        {
            NeuspjesnoObradjeniRacuniRequest1 = neuspjesnoObradjeniRacuniRequest;
        }

        [XmlElement("NeuspjesnoObradjeniRacuniRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public NeuspjesnoObradjeniRacuniRequest NeuspjesnoObradjeniRacuniRequest1 { get; set; }
    }
}