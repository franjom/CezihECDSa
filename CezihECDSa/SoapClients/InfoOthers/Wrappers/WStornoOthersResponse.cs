using CezihECDSa.Wsdl.InfoOthers;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers.Wrappers
{
    [XmlRoot("StornoOthersNaDan", Namespace = "http://tempuri.org/")]
    public sealed class WStornoOthersResponse
    {
        public WStornoOthersResponse()
        {
        }

        public WStornoOthersResponse(StornoStatus output)
        {
            Output = output;
        }

        [XmlElement("StornoStatus", Order = 0)]
        public StornoStatus Output { get; set; }
    }
}
