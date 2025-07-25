using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.NarucivanjeWS.Wrappers
{
    [XmlRoot("DohvatiSmjerniceRequest", Namespace = "http://tempuri.org/")]
    public sealed class WDohvatiSmjerniceRequest
    {
        public WDohvatiSmjerniceRequest() { }
        public WDohvatiSmjerniceRequest(string kzn, string mkb10)
        {
            KZN = kzn;
            MKB10 = mkb10;
        }

        [XmlElement("KZN", Order = 0)]
        public string KZN { get; set; }

        [XmlElement("MKB10", Order = 1)]
        public string MKB10 { get; set; }
    }
}
