using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CijepniKartonLijecnika.Wrappers
{
    [XmlRoot("UpitOCijepnimKartonimaIzabranogLijecnikaRequest", Namespace = "http://tempuri.org/")]
    public sealed class WUpitOCijepnimKartonimaIzabranogLijecnikaRequest
    {
        public WUpitOCijepnimKartonimaIzabranogLijecnikaRequest() { }
        public WUpitOCijepnimKartonimaIzabranogLijecnikaRequest(
            ZaglavljeZahtjevType identifikatorZahtjevField,
            string sifraLijecnikaField,
            int sifraVrsteCjepivoField)
        {
            IdentifikatorZahtjevField = identifikatorZahtjevField;
            SifraLijecnikaField = sifraLijecnikaField;
            SifraVrsteCjepivoField = sifraVrsteCjepivoField;
        }

        [XmlElement("identifikatorZahtjevField", Order = 0)]
        public ZaglavljeZahtjevType IdentifikatorZahtjevField { get; set; }

        [XmlElement("sifraLijecnikaField", Order = 1)]
        public string SifraLijecnikaField { get; set; }

        [XmlElement("sifraVrsteCjepivoField", Order = 2)]
        public int SifraVrsteCjepivoField { get; set; }
    }
}