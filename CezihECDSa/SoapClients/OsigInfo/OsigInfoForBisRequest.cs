using CezihECDSa.Wsdl.OsigInfo;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.OsigInfo
{
    [XmlRoot("osigInfoForBIS", Namespace = "http://www.hzzo-net.hr/")]
    public sealed class OsigInfoForBisRequest
    {
        public OsigInfoForBisRequest()
        {
        }

        public OsigInfoForBisRequest(object Item)
        {
            this.Item = Item;
        }

        [XmlElement("BrojOsiguraneOsobe", typeof(osigInfoForBISBrojOsiguraneOsobe))]
        [XmlElement("OpceInformacijeOPacijentu", typeof(osigInfoForBISOpceInformacijeOPacijentu))]
        [XmlElement("MBOsiguraneOsobe", typeof(string))]
        public object Item { get; set; }
    }
}