using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("EKartonResponse", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WEKartonResponse
    {
        [XmlElement("imeDatoteke")]
        public string[] ImeDatoteke { get; set; }

        [XmlElement("datoteka", DataType = "base64Binary")]
        public byte[][] Datoteke { get; set; }
    }
}