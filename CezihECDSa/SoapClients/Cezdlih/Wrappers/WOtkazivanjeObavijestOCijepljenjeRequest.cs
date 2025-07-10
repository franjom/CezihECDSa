using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("OtkazivanjeObavijestOCijepljenje", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WOtkazivanjeObavijestOCijepljenjeRequest
    {
        public WOtkazivanjeObavijestOCijepljenjeRequest()
        {
        }

        public WOtkazivanjeObavijestOCijepljenjeRequest(OtkazivanjeObavijestOCijepljenjeOtkazivanjeObavijestOCijepljenjeRequest request)
        {
            Request = request;
        }

        [XmlElement("OtkazivanjeObavijestOCijepljenjeRequest", Order = 0)]
        public OtkazivanjeObavijestOCijepljenjeOtkazivanjeObavijestOCijepljenjeRequest Request { get; set; }
    }
}