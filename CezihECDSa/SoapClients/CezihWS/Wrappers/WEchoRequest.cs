using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("echo", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WEchoRequest
    {
        public WEchoRequest() { }

        public WEchoRequest(string echoRequest)
        {
            EchoRequest = echoRequest;
        }

        [XmlElement("EchoRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public string EchoRequest { get; set; }
    }
}