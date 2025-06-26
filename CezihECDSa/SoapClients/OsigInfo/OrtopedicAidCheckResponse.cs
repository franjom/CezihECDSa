using CezihECDSa.Wsdl.OsigInfo;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.OsigInfo
{
    [XmlRoot("orthopedicAidCheckResponse", Namespace = "http://www.hzzo-net.hr/")]
    public sealed class OrtopedicAidCheckResponse
    {
        public OrtopedicAidCheckResponse()
        {
        }

        public OrtopedicAidCheckResponse(orthopedicAidCheckResponseOrthopedicAidCheckOutput output)
        {
            Output = output;
        }

        [XmlElement("OrthopedicAidCheckOutput", Order = 0)]
        public orthopedicAidCheckResponseOrthopedicAidCheckOutput Output { get; set; }
    }
}