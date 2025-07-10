using CezihECDSa.Wsdl.InfoOthers;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers.Wrappers
{
    [XmlRoot("AutorizacijaOthersPharmacyNaDan", Namespace = "http://tempuri.org/")]
    public sealed class WAutorizacijaOthersPharmacyResponse
    {
        public WAutorizacijaOthersPharmacyResponse()
        {
        }

        public WAutorizacijaOthersPharmacyResponse(AutStatus output)
        {
            Output = output;
        }

        [XmlElement("AutStatus", Order = 0)]
        public AutStatus Output { get; set; }
    }
}
