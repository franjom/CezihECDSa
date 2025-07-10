using CezihECDSa.Wsdl;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih.Wrappers
{
    [XmlRoot("PrijavaNuspojaveCijepljenja", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public class WPrijavaNuspojaveCijepljenjaRequest
    {
        public WPrijavaNuspojaveCijepljenjaRequest()
        {
        }

        public WPrijavaNuspojaveCijepljenjaRequest(PrijavaNuspojaveCijepljenjaPrijavaNuspojaveCijepljenjaRequest request)
        {
            Request = request;
        }

        [XmlElement("PrijavaNuspojaveCijepljenjaRequest", Order = 0)]
        public PrijavaNuspojaveCijepljenjaPrijavaNuspojaveCijepljenjaRequest Request { get; set; }
    }
}