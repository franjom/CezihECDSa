using System.Xml.Serialization;
using CezihECDSa.Wsdl.OsigInfo;

namespace CezihECDSa.SoapClients.OsigInfo
{
    [XmlRoot("osigInfoForPharmacy", Namespace = "http://www.hzzo-net.hr/")]
    public sealed class OsigInfoForPharmacyRequest
    {
        public OsigInfoForPharmacyRequest()
        {
        }

        public OsigInfoForPharmacyRequest(object Item)
        {
            this.Item = Item;
        }

        [XmlElement("BrojOsiguraneOsobe", typeof(osigInfoForPharmacyBrojOsiguraneOsobe))]
        [XmlElement("MBOsiguraneOsobe", typeof(string))]
        public object Item { get; set; }
    }
}