using CezihECDSa.Wsdl.InfoOthers;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers.Wrappers
{
    [XmlRoot("DohvatiOthersNaDanResponse", Namespace = "http://tempuri.org/")]
    public sealed class WDohvatiOthersNaDanResponse
    {
        public WDohvatiOthersNaDanResponse()
        {
        }

        public WDohvatiOthersNaDanResponse(OsigStatus output)
        {
            Output = output;
        }

        [XmlElement("DohvatiOthersNaDanResult", Order = 0)]
        public OsigStatus Output { get; set; }
    }
}
