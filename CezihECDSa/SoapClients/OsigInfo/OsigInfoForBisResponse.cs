using CezihECDSa.Wsdl.OsigInfo;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.OsigInfo
{
    [XmlRoot("osigInfoForBISResponse", Namespace = "http://www.hzzo-net.hr/")]
    public sealed class OsigInfoForBisResponse
    {
        public OsigInfoForBisResponse()
        {
        }

        public OsigInfoForBisResponse(osigInfoForBISResponseOsigInfoForBISOutput[] output)
        {
            Output = output;
        }

        [XmlElement("OsigInfoForBISOutput", Order = 0)]
        public osigInfoForBISResponseOsigInfoForBISOutput[] Output { get; set; }
    }
}