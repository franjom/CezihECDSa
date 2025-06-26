using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.OsigInfo
{
    [XmlRoot("orthopedicAidCheck", Namespace = "http://www.hzzo-net.hr/")]
    public sealed class OrtopedicAidCheckRequest
    {
        public OrtopedicAidCheckRequest()
        {
        }

        public OrtopedicAidCheckRequest(string mbOsiguraneOsobe, string sifraPomagala)
        {
            MbOsiguraneOsobe = mbOsiguraneOsobe;
            SifraPomagala = sifraPomagala;
        }

        [XmlElement("MBOsiguraneOsobe", Order = 0)]
        public string MbOsiguraneOsobe { get; set; }

        [XmlElement("SifraPomagala", Order = 1)]
        public string SifraPomagala { get; set; }
    }
}