using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("ObavijestOCijepljenjeResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WObavijestOCijepljenjeResponse
    {
        public WObavijestOCijepljenjeResponse()
        {
        }

        public WObavijestOCijepljenjeResponse(
            ObavijestOCijepljenjeResponseObavijestOCijepljenjeResult result)
        {
            Result = result;
        }

        [XmlElement("ObavijestOCijepljenjeResult", Order = 0)]
        public ObavijestOCijepljenjeResponseObavijestOCijepljenjeResult Result { get; set; }
    }
}