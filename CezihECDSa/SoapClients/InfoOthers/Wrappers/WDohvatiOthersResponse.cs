using CezihECDSa.Wsdl.InfoOthers;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers.Wrappers
{
    [XmlRoot("DohvatiOthersResponse", Namespace = "http://tempuri.org/")]
    public sealed class WDohvatiOthersResponse
    {
        public WDohvatiOthersResponse()
        {
        }

        public WDohvatiOthersResponse(OsigStatus output)
        {
            Output = output;
        }

        [XmlElement("DohvatiOthersResult", Order = 0)]
        public OsigStatus Output { get; set; }
    }
}
