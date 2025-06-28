using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("PreuzimanjePlanaImunizacijeResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WPreuzimanjePlanaImunizacijeResponse
    {
        public WPreuzimanjePlanaImunizacijeResponse()
        {
        }

        public WPreuzimanjePlanaImunizacijeResponse(
            PreuzimanjePlanaImunizacijeResponsePreuzimanjePlanaImunizacijeResult result)
        {
            Result = result;
        }

        [XmlElement("PreuzimanjePlanaImunizacijeResult", Order = 0)]
        public PreuzimanjePlanaImunizacijeResponsePreuzimanjePlanaImunizacijeResult Result { get; set; }
    }
}