using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("OtkazivanjeObavijestOCijepljenjeResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WOtkazivanjeObavijestOCijepljenjeResponse
    {
        public WOtkazivanjeObavijestOCijepljenjeResponse()
        {
        }

        public WOtkazivanjeObavijestOCijepljenjeResponse(
            OtkazivanjeObavijestOCijepljenjeResponseOtkazivanjeObavijestOCijepljenjeResult result)
        {
            Result = result;
        }

        [XmlElement("OtkazivanjeObavijestOCijepljenjeResult", Order = 0)]
        public OtkazivanjeObavijestOCijepljenjeResponseOtkazivanjeObavijestOCijepljenjeResult Result { get; set; }
    }
}