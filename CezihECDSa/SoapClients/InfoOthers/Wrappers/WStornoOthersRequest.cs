using System;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers.Wrappers
{
    [XmlRoot("StornoOthers", Namespace = "http://tempuri.org/")]
    public sealed class WStornoOthersRequest
    {
        public WStornoOthersRequest() { }
        public WStornoOthersRequest(string osiguravateljsifra, string pacijentoib, string brojKartice, DateTime dattroska, bool dattroskaSpecified, decimal transiznos, bool trnsiznosSpecified, short transtip, bool transtipSpecified, string autkod)
        {
            OsiguravateljSifra = osiguravateljsifra;
            PacijentOib = pacijentoib;
            BrojKartice = brojKartice;
            DatTrosak = dattroska;
            DatTrosakSpecified = dattroskaSpecified;
            TransIznos = transiznos;
            TrnsIznosSpecified = trnsiznosSpecified;
            TransTip = transtip;
            TransTipSpecified = transtipSpecified;
            AutKod = autkod;
        }

        [XmlElement("osiguravateljsifra", Order = 0)]
        public string OsiguravateljSifra { get; set; }

        [XmlElement("pacijentoib", Order = 1)]
        public string PacijentOib { get; set; }

        [XmlElement("brojKartice", Order = 2)]
        public string BrojKartice { get; set; }

        [XmlElement("dattrosak", Order = 3)]
        public DateTime DatTrosak { get; set; }

        [XmlElement("dattrosakSpecified", Order = 4)]
        public bool DatTrosakSpecified { get; set; }

        [XmlElement("transiznos", Order = 5)]
        public decimal TransIznos { get; set; }

        [XmlElement("transiznosSpecified", Order = 6)]
        public bool TrnsIznosSpecified { get; set; }

        [XmlElement("transtip", Order = 7)]
        public short TransTip { get; set; }

        [XmlElement("transtipSpecified", Order = 8)]
        public bool TransTipSpecified { get; set; }

        [XmlElement("autkod", Order = 9)]
        public string AutKod { get; set; }
    }
}
