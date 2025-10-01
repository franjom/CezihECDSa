using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("upload", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WUploadRequest
    {
        public WUploadRequest() { }

        public WUploadRequest(UploadRequest uploadRequest)
        {
            UploadRequest1 = uploadRequest;
        }

        [XmlElement("UploadRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0", Order = 0)]
        public UploadRequest UploadRequest1 { get; set; }
    }
}