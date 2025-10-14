using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("OtisliPacijentiResponse", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WFetchOtisliPacijentiResponse
    {
        public WFetchOtisliPacijentiResponse() { }

        public WFetchOtisliPacijentiResponse(byte[] datoteka)
        {
            this.datoteka = datoteka;
        }

        [XmlElement(DataType = "base64Binary", Order = 0)]
        public byte[] datoteka { get; set; }
    }
}