using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Fin.Wrappers
{
    [XmlRoot("GetCapitationCalculations", Namespace = "https://e-usluge.hzzo.hr/ews/finance")]
    public sealed class WCapitationCalculationsRequest
    {
        public WCapitationCalculationsRequest() { }
        public WCapitationCalculationsRequest(string healthcareInstitutionCode, string unitCode, string controlDateFrom, string controlDateTo)
        {
            HealthcareInstitutionCode = healthcareInstitutionCode;
            UnitCode = unitCode;
            ControlDateFrom = controlDateFrom;
            ControlDateTo = controlDateTo;
        }

        [XmlElement("HealthcareInstitutionCode", Order = 0)]
        public string HealthcareInstitutionCode { get; set; }

        [XmlElement("UnitCode", Order = 1)]
        public string UnitCode { get; set; }

        [XmlElement("ControlDateFrom", Order = 2)]
        public string ControlDateFrom { get; set; }

        [XmlElement("ControlDateTo", Order = 3)]
        public string ControlDateTo { get; set; }
    }
}
