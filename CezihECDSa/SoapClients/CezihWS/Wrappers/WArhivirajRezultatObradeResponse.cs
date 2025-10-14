using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("arhivirajRezultatObradeResponse", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WArhivirajRezultatObradeResponse
    {
        public WArhivirajRezultatObradeResponse() { }
        public WArhivirajRezultatObradeResponse(ArhivirajRezultatObradeResponse output) => Output = output;

        [XmlElement("arhivirajRezultatObradeResult", Order = 0)]
        public ArhivirajRezultatObradeResponse Output { get; set; }
    }
}