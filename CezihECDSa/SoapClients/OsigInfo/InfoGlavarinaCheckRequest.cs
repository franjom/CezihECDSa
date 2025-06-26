using System;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.OsigInfo
{
    [XmlRoot("infoGlavarina", Namespace = "http://www.hzzo-net.hr/")]
    public sealed class InfoGlavarinaCheckRequest
    {
        public InfoGlavarinaCheckRequest()
        {
        }

        public InfoGlavarinaCheckRequest(string mboDoktor)
        {
            MboDoktor = mboDoktor;
        }

        public InfoGlavarinaCheckRequest(string mboDoktor, DateTime datum)
        {
            MboDoktor = mboDoktor;
            Datum = datum;

            DatumSpecified = datum != DateTime.MinValue;
        }

        [XmlElement("MBODoktor")]
        public string MboDoktor { get; set; }

        [XmlElement("Datum", DataType = "date")]
        public DateTime Datum { get; set; }

        [XmlIgnore]
        public bool DatumSpecified { get; set; }
    }
}