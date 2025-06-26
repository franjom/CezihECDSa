using CezihECDSa.Wsdl.OsigInfo;
using System;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.OsigInfo
{
    [XmlRoot("infoGlavarinaResponse", Namespace = "http://www.hzzo-net.hr/")]
    public sealed class InfoGlavarinaCheckResponse
    {
        public InfoGlavarinaCheckResponse()
        {
            Output = Array.Empty<infoGlavarinaResponseGlavarina>();
        }

        public InfoGlavarinaCheckResponse(infoGlavarinaResponseGlavarina[] output)
        {
            Output = output;
        }

        [XmlArray("infoGlavarinaOutput")]
        [XmlArrayItem("Glavarina", IsNullable = false)]
        public infoGlavarinaResponseGlavarina[] Output { get; set; }
    }
}