using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("EchoRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WEchoRequest
    {
        public WEchoRequest() { }

        public WEchoRequest(string echoRequest)
        {
            this.Podatak = echoRequest;
        }

        [XmlText]
        public string Podatak { get; set; }
    }
}