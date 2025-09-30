using CezihECDSa.Wsdl.CijepniKartonLijecnika;
using CezihECDSa.Wsdl.InfoOthers;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CijepniKartonLijecnika.Wrappers
{
    [XmlRoot("UpitOCijepnimKartonimaIzabranogLijecnikaResponse", Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices")]
    public sealed class WUpitOCijepnimKartonimaIzabranogLijecnikaResponse
    {
        public WUpitOCijepnimKartonimaIzabranogLijecnikaResponse()
        {
        }

        public WUpitOCijepnimKartonimaIzabranogLijecnikaResponse(UpitOCijepnimKartonimaIzabranogLijecnikaResponseUpitOCijepnimKartonimaIzabranogLijecnikaResult output)
        {
            Output = output;
        }

        [XmlElement("AutorizacijaOthersPharmacyNaDanResult", Order = 0)]
        public UpitOCijepnimKartonimaIzabranogLijecnikaResponseUpitOCijepnimKartonimaIzabranogLijecnikaResult Output { get; set; }
    }
}
