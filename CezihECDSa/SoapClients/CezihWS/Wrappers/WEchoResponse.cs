using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("EchoResponse", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WEchoResponse
    {
        public WEchoResponse() { }
        public WEchoResponse(string output) => Output = output;

        [XmlText]
        public string Output { get; set; }
    }
}