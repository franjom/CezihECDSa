using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("PrijavaNuspojaveCijepljenjaResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WPrijavaNuspojaveCijepljenjaResponse
    {
        public WPrijavaNuspojaveCijepljenjaResponse()
        {
        }

        public WPrijavaNuspojaveCijepljenjaResponse(
            PrijavaNuspojaveCijepljenjaResponsePrijavaNuspojaveCijepljenjaResult result)
        {
            Result = result;
        }

        [XmlElement("PrijavaNuspojaveCijepljenjaResult", Order = 0)]
        public PrijavaNuspojaveCijepljenjaResponsePrijavaNuspojaveCijepljenjaResult Result { get; set; }
    }
}