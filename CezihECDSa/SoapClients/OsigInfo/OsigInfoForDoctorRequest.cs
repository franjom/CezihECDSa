using CezihECDSa.Wsdl.OsigInfo;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.OsigInfo
{
    [XmlRoot("osigInfoForDoctor", Namespace = "http://www.hzzo-net.hr/")]
    public sealed class OsigInfoForDoctorRequest
    {
        public OsigInfoForDoctorRequest()
        {
        }

        public OsigInfoForDoctorRequest(object Item)
        {
            this.Item = Item;
        }

        [XmlElement("BrojOsiguraneOsobe", typeof(osigInfoForDoctorBrojOsiguraneOsobe))]
        [XmlElement("OpceInformacijeOPacijentu", typeof(osigInfoForDoctorOpceInformacijeOPacijentu))]
        [XmlElement("MBOsiguraneOsobe", typeof(string))]
        public object Item { get; set; }
    }
}