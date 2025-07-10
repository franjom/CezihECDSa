using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers.Wrappers
{
    [XmlRoot("DohvatiOthersNaDan")]
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

        [XmlElement("dan", Order = 2)]
        public DateTime Dan { get; set; }

        [XmlElement("danSpecified", Order = 3)]
        public bool DanSpecified { get; set; }
    }
}
