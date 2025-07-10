using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("SlanjePrimkeResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WSlanjePrimkeResponse
    {
        public WSlanjePrimkeResponse()
        {
        }

        public WSlanjePrimkeResponse(
            SlanjePrimkeResponseSlanjePrimkeResult result)
        {
            Result = result;
        }

        [XmlElement("SlanjePrimkeResult", Order = 0)]
        public SlanjePrimkeResponseSlanjePrimkeResult Result { get; set; }
    }
}