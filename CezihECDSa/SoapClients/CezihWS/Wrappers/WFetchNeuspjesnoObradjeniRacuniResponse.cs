using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("fetchNeuspjesnoObradjeniRacuniResponse", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WFetchNeuspjesnoObradjeniRacuniResponse
    {
        public WFetchNeuspjesnoObradjeniRacuniResponse() { }
        public WFetchNeuspjesnoObradjeniRacuniResponse(fetchNeuspjesnoObradjeniRacuniResponse output) => Output = output;

        [XmlElement("fetchNeuspjesnoObradjeniRacuniResult", Order = 0)]
        public fetchNeuspjesnoObradjeniRacuniResponse Output { get; set; }
    }
}