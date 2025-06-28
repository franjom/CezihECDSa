using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("PreuzimanjePlanaImunizacije", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WPreuzimanjePlanaImunizacijeRequest
    {
        public WPreuzimanjePlanaImunizacijeRequest()
        {
        }

        public WPreuzimanjePlanaImunizacijeRequest(PreuzimanjePlanaImunizacijePreuzimanjePlanaImunizacijeRequest request)
        {
            Request = request;
        }

        [XmlElement("PreuzimanjePlanaImunizacijeRequest")]
        public PreuzimanjePlanaImunizacijePreuzimanjePlanaImunizacijeRequest Request { get; set; }
    }
}