using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers.Wrappers
{
    [XmlRoot("PrijedlogZaProvjeruVozacaResponse", Namespace = "https://servis.hzzo.hr/cezih/evidencije")]
    public sealed class WPrijedlogZaProvjeruVozacaResponse
    {
        public WPrijedlogZaProvjeruVozacaResponse()
        {
        }

        public WPrijedlogZaProvjeruVozacaResponse(ZahtjevOdgovor output)
        {
            Output = output;
        }

        [XmlElement("PrijedlogZaProvjeruVozacaResult", Order = 0)]
        public ZahtjevOdgovor Output { get; set; }
    }
}
