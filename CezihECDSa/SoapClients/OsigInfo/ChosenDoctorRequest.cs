using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.OsigInfo
{
    [XmlRoot("chosenDoctor", Namespace = "http://www.hzzo-net.hr/")]
    public class ChosenDoctorRequest
    {
        public ChosenDoctorRequest()
        {
        }

        public ChosenDoctorRequest(string oibOsobe)
        {
            OibOsobe = oibOsobe;
        }

        [XmlElement("OIBOsobe")]
        public string OibOsobe { get; set; }
    }
}