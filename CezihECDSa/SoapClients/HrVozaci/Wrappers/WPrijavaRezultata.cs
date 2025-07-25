using HRVozaci;
using System;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.HrVozaci.Wrappers
{
    [XmlRoot("PrijavaRezultata", Namespace = "http://www.cezih.hr/HrVozacke/Incoming")]
    public class WPrijavaRezultata
    {
        public WPrijavaRezultata()
        {
        }

        public WPrijavaRezultata(
            Grp_Poruka poruka,
            Grp_Autor autor,
            string brojUvjerenja,
            Grp_TijeloIzdavanja tijeloIzdavanja,
            DateTime datum,
            string svrha,
            Grp_Nositelj nositelj,
            Grp_Sposoban sposoban,
            Grp_Kategorije[] kategorije)
        {
            Poruka = poruka;
            Autor = autor;
            BrojUvjerenja = brojUvjerenja;
            TijeloIzdavanja = tijeloIzdavanja;
            Datum = datum;
            Svrha = svrha;
            Nositelj = nositelj;
            Sposoban = sposoban;
            Kategorije = kategorije;
        }

        public WPrijavaRezultata(PrijavaRezultata prijavaRezultata)
        {
            Poruka = prijavaRezultata.Poruka;
            Autor = prijavaRezultata.Autor;
            BrojUvjerenja = prijavaRezultata.BrojUvjerenja;
            TijeloIzdavanja = prijavaRezultata.TijeloIzdavanja;
            Datum = prijavaRezultata.Datum;
            Svrha = prijavaRezultata.Svrha;
            Nositelj = prijavaRezultata.Nositelj;
            Sposoban = prijavaRezultata.Sposoban;
            Kategorije = prijavaRezultata.Kategorije;
        }

        [XmlElement("Poruka")]
        public Grp_Poruka Poruka { get; set; }

        [XmlElement("Autor")]
        public Grp_Autor Autor { get; set; }

        [XmlElement("BrojUvjerenja")]
        public string BrojUvjerenja { get; set; }

        [XmlElement("TijeloIzdavanja")]
        public Grp_TijeloIzdavanja TijeloIzdavanja { get; set; }

        [XmlElement("Datum", DataType = "date")]
        public DateTime Datum { get; set; }

        [XmlElement("Svrha")]
        public string Svrha { get; set; }

        [XmlElement("Nositelj")]
        public Grp_Nositelj Nositelj { get; set; }

        [XmlElement("Sposoban")]
        public Grp_Sposoban Sposoban { get; set; }

        [XmlElement("Kategorije")]
        public Grp_Kategorije[] Kategorije { get; set; }
    }
}