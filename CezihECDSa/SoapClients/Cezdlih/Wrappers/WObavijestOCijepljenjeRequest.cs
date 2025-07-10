using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("ObavijestOCijepljenje", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WObavijestOCijepljenjeRequest
    {
        public WObavijestOCijepljenjeRequest()
        {
        }

        public WObavijestOCijepljenjeRequest(ObavijestOCijepljenjeObavijestOCijepljenjeRequest request)
        {
            Request = request;
        }

        [XmlElement("ObavijestOCijepljenjeRequest", Order = 0)]
        public ObavijestOCijepljenjeObavijestOCijepljenjeRequest Request { get; set; }
    }
}