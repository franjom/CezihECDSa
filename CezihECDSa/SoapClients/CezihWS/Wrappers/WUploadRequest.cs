using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("UploadRequest", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WUploadRequest
    {
        public WUploadRequest() { }

        public WUploadRequest(UploadRequest uploadRequest)
        {
            ImeDatoteke = uploadRequest.imeDatoteke;
            Datoteka = uploadRequest.datoteka;
        }

        [XmlElement("imeDatoteke")]
        public string ImeDatoteke { get; set; }

        [XmlElement("datoteka")]
        public byte[] Datoteka { get; set; }
    }
}