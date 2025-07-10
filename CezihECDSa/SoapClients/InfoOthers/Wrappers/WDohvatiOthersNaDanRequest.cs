using System;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers.Wrappers
{
    [XmlRoot("DohvatiOthersNaDan", Namespace = "http://tempuri.org/")]
    public sealed class WDohvatiOthersNaDanRequest
    {
        public WDohvatiOthersNaDanRequest() { }
        public WDohvatiOthersNaDanRequest(string osiguravateljsifra, string pacijentoib, DateTime dan, bool danSpecified)
        {
            OsiguravateljSifra = osiguravateljsifra;
            PacijentOib = pacijentoib;
            Dan = dan;
            DanSpecified = danSpecified;
        }

        [XmlElement("osiguravateljsifra", Order = 0)]
        public string OsiguravateljSifra { get; set; }

        [XmlElement("pacijentoib", Order = 1)]
        public string PacijentOib { get; set; }

        [XmlIgnore]
        public DateTime Dan { get; set; }

        [XmlElement("dan", Order = 2)]
        public string DanString
        {
            get => Dan.ToString("yyyy-MM-ddTHH:mm:ss");
            set => Dan = DateTime.Parse(value);
        }

        [XmlIgnore]
        [XmlElement("danSpecified", Order = 3)]
        public bool DanSpecified { get; set; }
    }
}
