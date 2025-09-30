using CezihECDSa.Wsdl.CijepniKartonLijecnika;
using CezihECDSa.Wsdl.InfoOthers;
using System;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CijepniKartonLijecnika.Wrappers
{
    [XmlRoot("UpitOCijepnimKartonimaIzabranogLijecnika", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public sealed class WUpitOCijepnimKartonimaIzabranogLijecnikaRequest
    {
        public WUpitOCijepnimKartonimaIzabranogLijecnikaRequest() { }
        public WUpitOCijepnimKartonimaIzabranogLijecnikaRequest(UpitOCijepnimKartonimaIzabranogLijecnikaUpitOCijepnimKartonimaIzabranogLijecnikaRequest upitOCijepnimKartonimaIzabranogLijecnikaRequest1)
        {
            UpitOCijepnimKartonimaIzabranogLijecnikaRequest1 = upitOCijepnimKartonimaIzabranogLijecnikaRequest1;
        }

        [XmlElement("UpitOCijepnimKartonimaIzabranogLijecnikaRequest", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices", Order = 0)]

        public UpitOCijepnimKartonimaIzabranogLijecnikaUpitOCijepnimKartonimaIzabranogLijecnikaRequest UpitOCijepnimKartonimaIzabranogLijecnikaRequest1;
    }
}