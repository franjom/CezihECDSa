using HRVozaci;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.HrVozaci.Wrappers
{
    [XmlRoot("PrijavaRezultataOdgovor", Namespace = "http://www.cezih.hr/HrVozacke/Incoming")]
    public sealed class WPrijavaRezultataOdgovor
    {
        public WPrijavaRezultataOdgovor()
        {
        }

        public WPrijavaRezultataOdgovor(PrijavaRezultataOdgovor output)
        {
            Odgovor = output.Odgovor;
            Greske = output.Greske;
            Id = output.id;
        }

        [XmlElement("Odgovor", Order = 0)]
        public Odgovor Odgovor { get; set; }

        [XmlArray(Order = 1)]
        [XmlArrayItem("Greska", IsNullable = false)]
        public Grp_GreskeGreska[] Greske { get; set; }

        [XmlAttribute("id")]
        public string Id { get; set; }
    }
}
