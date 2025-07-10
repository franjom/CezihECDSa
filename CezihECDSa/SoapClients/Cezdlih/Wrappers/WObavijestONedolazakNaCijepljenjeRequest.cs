using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("ObavijestONedolazakNaCijepljenje", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WObavijestONedolazakNaCijepljenjeRequest
    {
        public WObavijestONedolazakNaCijepljenjeRequest()
        {
        }

        public WObavijestONedolazakNaCijepljenjeRequest(ObavijestONedolazakNaCijepljenjeObavijestONedolazakNaCijepljenjeRequest request)
        {
            Request = request;
        }

        [XmlElement("ObavijestONedolazakNaCijepljenjeRequest", Order = 0)]
        public ObavijestONedolazakNaCijepljenjeObavijestONedolazakNaCijepljenjeRequest Request { get; set; }
    }
}