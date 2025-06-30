using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("SlanjePlanaImunizacijeResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WSlanjePlanaImunizacijeResponse
    {
        public WSlanjePlanaImunizacijeResponse()
        {
        }

        public WSlanjePlanaImunizacijeResponse(
            SlanjePlanaImunizacijeResponseSlanjePlanaImunizacijeResult result)
        {
            Result = result;
        }

        [XmlElement("SlanjePlanaImunizacijeResult", Order = 0)]
        public SlanjePlanaImunizacijeResponseSlanjePlanaImunizacijeResult Result { get; set; }
    }
}