using System.Xml.Serialization;
using CezihECDSa.Wsdl.OsigInfo;

namespace CezihECDSa.SoapClients.OsigInfo
{
    [XmlRoot("osigInfoForSKZZResponse", Namespace = "http://www.hzzo-net.hr/")]
    public sealed class OsigInfoForSKZZResponse
    {
        public OsigInfoForSKZZResponse()
        {
        }

        public OsigInfoForSKZZResponse(osigInfoForSKZZResponseOsigInfoForSKZZOutput output)
        {
            this.Output = output;
        }

        [XmlElement("OsigInfoForSKZZOutput", Order = 0)]
        public osigInfoForSKZZResponseOsigInfoForSKZZOutput Output { get; set; }
    }
}