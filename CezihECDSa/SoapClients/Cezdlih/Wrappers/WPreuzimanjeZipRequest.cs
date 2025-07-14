using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("PreuzimanjeZip", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WPreuzimanjeZipRequest
    {
        public WPreuzimanjeZipRequest()
        {
        }

        public WPreuzimanjeZipRequest(PreuzimanjeZipPreuzimanjeZipRequest request)
        {
            Request = request;
        }

        [XmlElement("PreuzimanjeZipRequest", Order = 0)]
        public PreuzimanjeZipPreuzimanjeZipRequest Request { get; set; }
    }
}