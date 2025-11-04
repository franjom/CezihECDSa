using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("uploadResponse", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WUploadResponse
    {
        public WUploadResponse() { }
        public WUploadResponse(UploadResponse output) => Output = output;

        [XmlElement("uploadResult", Order = 0)]
        public UploadResponse Output { get; set; }
    }
}