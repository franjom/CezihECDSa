using ECDSAClientServices.Wsdl.Fin;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Fin.Wrappers
{
    [XmlRoot("GetCapitationCalculationsResponse", Namespace = "https://e-usluge.hzzo.hr/ews/finance")]
    public sealed class WGetCapitationCalculationsResponse
    {
        public WGetCapitationCalculationsResponse()
        {
        }

        public WGetCapitationCalculationsResponse(CapitationCalculations output)
        {
            Output = output;
        }

        [XmlElement("GetCapitationCalculationsResult", Order = 0)]
        public CapitationCalculations Output { get; set; }
    }
}
