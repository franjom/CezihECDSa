using CezihECDSa.Wsdl.OsigInfo;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.OsigInfo
{
    [XmlRoot("osigInfoForDoctorResponse", Namespace = "http://www.hzzo-net.hr/")]
    public sealed class OsigInfoForDoctorResponse
    {
        public OsigInfoForDoctorResponse()
        {
        }

        public OsigInfoForDoctorResponse(osigInfoForDoctorResponseOsigInfoForDoctorOutput[] output)
        {
            Output = output;
        }

        [XmlElement("OsigInfoForDoctorOutput", Order = 0)]
        public osigInfoForDoctorResponseOsigInfoForDoctorOutput[] Output { get; set; }
    }
}