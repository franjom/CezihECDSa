using CezihECDSa.Wsdl.InfoOthers;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers.Wrappers
{
    [XmlRoot("AutorizacijaOthersPharmacyNaDanResponse", Namespace = "http://tempuri.org/")]
    public sealed class WAutorizacijaOthersPharmacyResponse
    {
        public WAutorizacijaOthersPharmacyResponse()
        {
        }

        public WAutorizacijaOthersPharmacyResponse(AutStatus output)
        {
            Output = output;
        }

        [XmlElement("AutorizacijaOthersPharmacyNaDanResult", Order = 0)]
        public AutStatus Output { get; set; }
    }
}
