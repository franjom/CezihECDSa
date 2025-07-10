using CezihECDSa.Wsdl.InfoOthers;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers.Wrappers
{
    [XmlRoot("DohvatiOthers", Namespace = "http://tempuri.org/")]
    public sealed class WDohvatiOthersResponse
    {
        public WDohvatiOthersResponse()
        {
        }

        public WDohvatiOthersResponse(OsigStatus output)
        {
            Output = output;
        }

        [XmlElement("OsigStatus", Order = 0)]
        public OsigStatus Output { get; set; }
    }
}
