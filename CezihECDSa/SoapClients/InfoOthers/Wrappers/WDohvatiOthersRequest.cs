using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers.Wrappers
{
    [XmlRoot("DohvatiOthers", Namespace = "http://tempuri.org/")]
    public sealed class WDohvatiOthersRequest
    {
        public WDohvatiOthersRequest() { }
        public WDohvatiOthersRequest(string osiguravateljsifra, string pacijentoib)
        {
            OsiguravateljSifra = osiguravateljsifra;
            PacijentOib = pacijentoib;
        }

        [XmlElement("osiguravateljsifra", IsNullable = true)]
        public string OsiguravateljSifra { get; set; }

        [XmlElement("pacijentoib", IsNullable = true)]
        public string PacijentOib { get; set; }
    }
}
