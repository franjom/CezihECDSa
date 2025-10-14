using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("RezultatObradeResponse", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WFetchRezultatObradeResponse
    {
        public WFetchRezultatObradeResponse() { }

        public WFetchRezultatObradeResponse(string imeDatoteke, byte[] datoteka)
        {
            this.imeDatoteke = imeDatoteke;
            this.datoteka = datoteka;
        }

        [XmlElement(Order = 0)]
        public string imeDatoteke { get; set; }

        [XmlElement(DataType = "base64Binary", Order = 1)]
        public byte[] datoteka { get; set; }
    }
}