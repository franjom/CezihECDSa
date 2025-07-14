using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("UpitOCijepnomKartonuOsobe", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WUpitOCijepnomKartonuOsobeRequest
    {
        public WUpitOCijepnomKartonuOsobeRequest()
        {
        }

        public WUpitOCijepnomKartonuOsobeRequest(UpitOCijepnomKartonuOsobeUpitOCijepnomKartonuOsobeRequest request)
        {
            Request = request;
        }

        [XmlElement("UpitOCijepnomKartonuOsobeRequest", Order = 0)]
        public UpitOCijepnomKartonuOsobeUpitOCijepnomKartonuOsobeRequest Request { get; set; }
    }
}