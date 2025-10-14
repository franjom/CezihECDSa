using CezihECDSa.Wsdl.CezihWS;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ArhivirajOtisliPacijentiResponse", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WArhivirajOtisliPacijentiResponse
    {
        public WArhivirajOtisliPacijentiResponse() { }

        [XmlText]
        public ArhivirajOtisliPacijentiResponse Result { get; set; }
    }
}