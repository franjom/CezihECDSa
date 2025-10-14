using CezihECDSa.Wsdl.CezihWS;
using System;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs.Wrappers
{
    [XmlRoot("NeuspjesnoObradjeniRacuniRequest", Namespace = "urn:publicid:-:FileTransferWebService:WS-types:1.0")]
    public sealed class WFetchNeuspjesnoObradjeniRacuniRequest
    {
        public WFetchNeuspjesnoObradjeniRacuniRequest() { }

        public WFetchNeuspjesnoObradjeniRacuniRequest(fetchNeuspjesnoObradjeniRacuniRequest neuspjesnoObradjeniRacuniRequest)
        {
            DatumOd = neuspjesnoObradjeniRacuniRequest.datumOd;
            DatumDo = neuspjesnoObradjeniRacuniRequest.datumDo;
        }

        [XmlElement("datumOd")]
        public DateTime DatumOd { get; set; }

        [XmlElement("datumDo")]
        public DateTime DatumDo { get; set; }
    }
}