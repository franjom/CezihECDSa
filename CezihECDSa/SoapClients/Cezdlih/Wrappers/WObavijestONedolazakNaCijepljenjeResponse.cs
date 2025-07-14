using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("ObavijestONedolazakNaCijepljenjeResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WObavijestONedolazakNaCijepljenjeResponse
    {
        public WObavijestONedolazakNaCijepljenjeResponse()
        {
        }

        public WObavijestONedolazakNaCijepljenjeResponse(
            ObavijestONedolazakNaCijepljenjeResponseObavijestONedolazakNaCijepljenjeResult result)
        {
            Result = result;
        }

        [XmlElement("ObavijestONedolazakNaCijepljenjeResult", Order = 0)]
        public ObavijestONedolazakNaCijepljenjeResponseObavijestONedolazakNaCijepljenjeResult Result { get; set; }
    }
}