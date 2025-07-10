using CezihECDSa.Wsdl.InfoOthers;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers.Wrappers
{
    [XmlRoot("DohvatiOthersNaDan", Namespace = "http://tempuri.org/")]
    public sealed class WDohvatiOthersNaDanResponse
    {
        public WDohvatiOthersNaDanResponse()
        {
        }

        public WDohvatiOthersNaDanResponse(OsigStatus output)
        {
            Output = output;
        }

        [XmlElement("OsigStatus", Order = 0)]
        public OsigStatus Output { get; set; }
    }
}
