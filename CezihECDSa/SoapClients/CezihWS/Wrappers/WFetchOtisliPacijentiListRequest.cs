using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("ListaOtisliPacijentiListRequest", Namespace = "urn:publicid:-:CEZIH:WS-types:1.0")]
    public class WFetchOtisliPacijentiListRequest
    {
        public WFetchOtisliPacijentiListRequest() { }
        public WFetchOtisliPacijentiListRequest(string podatak) 
        {
            this.Podatak = podatak;
        }

        [XmlText]
        public string Podatak { get; set; }
    }
}