using CezihECDSa.Wsdl.OsigInfo;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.OsigInfo
{
    [XmlRoot("chosenDoctorResponse", Namespace = "http://www.hzzo-net.hr/")]
    public class ChosenDoctorResponse
    {
        public ChosenDoctorResponse()
        {
        }

        public ChosenDoctorResponse(chosenDoctorResponseChosenDoctorOutput output)
        {
            Output = output;
        }

        [XmlElement("chosenDoctorOutput", Order = 0)]
        public chosenDoctorResponseChosenDoctorOutput Output { get; set; }
    }
}