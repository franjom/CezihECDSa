using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("SlanjePlanaImunizacije", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WSlanjePlanaImunizacijeRequest
    {
        public WSlanjePlanaImunizacijeRequest()
        {
        }

        public WSlanjePlanaImunizacijeRequest(SlanjePlanaImunizacijeSlanjePlanaImunizacijeRequest request)
        {
            Request = request;
        }

        [XmlElement("SlanjePlanaImunizacijeRequest")]
        public SlanjePlanaImunizacijeSlanjePlanaImunizacijeRequest Request { get; set; }
    }
}