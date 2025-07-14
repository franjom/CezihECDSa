using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("ObavijestOPovratuOtpisuCjepiva", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WObavijestOPovratuOtpisuCjepivaRequest
    {
        public WObavijestOPovratuOtpisuCjepivaRequest()
        {
        }

        public WObavijestOPovratuOtpisuCjepivaRequest(ObavijestOPovratuOtpisuCjepivaObavijestOPovratuOtpisuCjepivaRequest request)
        {
            Request = request;
        }

        [XmlElement("ObavijestOPovratuOtpisuCjepivaRequest", Order = 0)]
        public ObavijestOPovratuOtpisuCjepivaObavijestOPovratuOtpisuCjepivaRequest Request { get; set; }
    }
}