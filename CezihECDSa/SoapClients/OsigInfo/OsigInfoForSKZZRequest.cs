using CezihECDSa.Wsdl.OsigInfo;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.OsigInfo
{
    [XmlRoot("osigInfoForSKZZ", Namespace = "http://www.hzzo-net.hr/")]
    public sealed class OsigInfoForSKZZRequest
    {
        public OsigInfoForSKZZRequest()
        {
        }

        public OsigInfoForSKZZRequest(object Item)
        {
            this.Item = Item;
        }

        [XmlElement("BrojOsiguraneOsobe", typeof(osigInfoForSKZZBrojOsiguraneOsobe))]
        [XmlElement("MBOsiguraneOsobe", typeof(string))]
        public object Item { get; set; }
    }
}