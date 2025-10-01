using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("echoResponse", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WEchoResponse
    {
        public WEchoResponse() { }
        public WEchoResponse(string output) => Output = output;

        [XmlElement("echoResult", Order = 0)]
        public string Output { get; set; }
    }
}