using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("arhivirajEKartonResponse", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WArhivirajEKartonResponse
    {
        public WArhivirajEKartonResponse() { }
        public WArhivirajEKartonResponse(ArhivirajEKartonResponse output) => Output = output;

        [XmlElement("arhivirajEKartonResult", Order = 0)]
        public ArhivirajEKartonResponse Output { get; set; }
    }
}