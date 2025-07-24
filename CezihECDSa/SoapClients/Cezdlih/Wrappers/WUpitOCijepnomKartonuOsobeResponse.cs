using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("UpitOCijepnomKartonuOsobeResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WUpitOCijepnomKartonuOsobeResponse
    {
        public WUpitOCijepnomKartonuOsobeResponse()
        {
        }

        public WUpitOCijepnomKartonuOsobeResponse(
            UpitOCijepnomKartonuOsobeResponseUpitOCijepnomKartonuOsobeResult result)
        {
            Result = result;
        }

        [XmlElement("UpitOCijepnomKartonuOsobeResult", Order = 0)]
        public UpitOCijepnomKartonuOsobeResponseUpitOCijepnomKartonuOsobeResult Result { get; set; }
    }
}