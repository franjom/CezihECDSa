using CezihECDSa.Wsdl.OsigInfo;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.OsigInfo
{
    [XmlRoot("osigInfoForPharmacyResponse", Namespace = "http://www.hzzo-net.hr/")]
    public sealed class OsigInfoForPharmacyResponse
    {
        public OsigInfoForPharmacyResponse()
        {
        }

        public OsigInfoForPharmacyResponse(osigInfoForPharmacyResponseOsigInfoForPharmacyOutput output)
        {
            Output = output;
        }

        [XmlElement("OsigInfoForPharmacyOutput", Order = 0)]
        public osigInfoForPharmacyResponseOsigInfoForPharmacyOutput Output { get; set; }
    }
}