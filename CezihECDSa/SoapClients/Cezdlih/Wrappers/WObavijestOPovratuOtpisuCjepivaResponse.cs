using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("ObavijestOPovratuOtpisuCjepivaResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WObavijestOPovratuOtpisuCjepivaResponse
    {
        public WObavijestOPovratuOtpisuCjepivaResponse()
        {
        }

        public WObavijestOPovratuOtpisuCjepivaResponse(
            ObavijestOPovratuOtpisuCjepivaResponseObavijestOPovratuOtpisuCjepivaResult result)
        {
            Result = result;
        }

        [XmlElement("ObavijestOPovratuOtpisuCjepivaResult", Order = 0)]
        public ObavijestOPovratuOtpisuCjepivaResponseObavijestOPovratuOtpisuCjepivaResult Result { get; set; }
    }
}