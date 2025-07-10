using CezihECDSa.Wsdl.InfoOthers;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers.Wrappers
{
    [XmlRoot("AutorizacijaOthersNaDan", Namespace = "http://tempuri.org/")]
    public sealed class WAutorizacijaOthersResponse
    {
        public WAutorizacijaOthersResponse()
        {
        }

        public WAutorizacijaOthersResponse(AutStatus output)
        {
            Output = output;
        }

        [XmlElement("AutStatus", Order = 0)]
        public AutStatus Output { get; set; }
    }
}
