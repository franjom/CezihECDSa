using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ObavijestResponse", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WFetchObavijestResponse
    {
        public WFetchObavijestResponse() { }

        public WFetchObavijestResponse(obavijestDatoteka[] obavijestDatoteka)
        {
            this.obavijestDatoteka = obavijestDatoteka;
        }

        [XmlElement("obavijestDatoteka", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
        public obavijestDatoteka[] obavijestDatoteka { get; set; }
    }
}