using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers.Wrappers
{
    [XmlRoot("PrijedlogZaProvjeruVozaca", Namespace = "https://servis.hzzo.hr/cezih/evidencije")]
    public sealed class WPrijedlogZaProvjeruVozacaRequest
    {
        public WPrijedlogZaProvjeruVozacaRequest() { }
        public WPrijedlogZaProvjeruVozacaRequest(string oib, string sifraOrdinacije)
        {
            Oib = oib;
            SifraOrdinacije = sifraOrdinacije;
        }

        [XmlElement("Oib", IsNullable = true)]
        public string Oib { get; set; }

        [XmlElement("SifraOrdinacije", IsNullable = true)]
        public string SifraOrdinacije { get; set; }
    }
}
