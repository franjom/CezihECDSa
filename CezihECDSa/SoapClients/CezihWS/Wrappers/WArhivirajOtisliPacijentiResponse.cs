using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("arhivirajOtisliPacijentiResponse", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public sealed class WArhivirajOtisliPacijentiResponse
    {
        public WArhivirajOtisliPacijentiResponse() { }
        public WArhivirajOtisliPacijentiResponse(ArhivirajOtisliPacijentiResponse output) => Output = output;

        [XmlElement("arhivirajOtisliPacijentiResult", Order = 0)]
        public ArhivirajOtisliPacijentiResponse Output { get; set; }
    }
}