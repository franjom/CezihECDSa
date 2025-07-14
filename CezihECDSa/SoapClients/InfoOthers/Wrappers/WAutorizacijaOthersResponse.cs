using CezihECDSa.Wsdl.InfoOthers;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers.Wrappers
{
    [XmlRoot("AutorizacijaOthersNaDanResponse", Namespace = "http://tempuri.org/")]
    public sealed class WAutorizacijaOthersResponse
    {
        public WAutorizacijaOthersResponse()
        {
        }

        public WAutorizacijaOthersResponse(AutStatus output)
        {
            Output = output;
        }

        [XmlElement("AutorizacijaOthersNaDanResult", Order = 0)]
        public AutStatus Output { get; set; }
    }
}
