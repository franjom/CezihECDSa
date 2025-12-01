using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Fin.Wrappers
{
    [XmlRoot("GetSpecificationForInvoiceRecap", Namespace = "https://e-usluge.hzzo.hr/ews/finance")]
    public sealed class WGetSpecificationForInvoiceRecapRequest
    {
        public WGetSpecificationForInvoiceRecapRequest() { }
        public WGetSpecificationForInvoiceRecapRequest(string healthcareInstitutionCode, string unitCode, string invoiceType, string invoiceNumber, string dateFrom, string dateTo)
        {
            HealthcareInstitutionCode = healthcareInstitutionCode;
            UnitCode = unitCode;
            InvoiceType = invoiceType;
            InvoiceNumber = invoiceNumber;
            DateReceivedFrom = dateFrom;
            DateReceivedTo = dateTo;
        }

        [XmlElement("HealthcareInstitutionCode", Order = 0)]
        public string HealthcareInstitutionCode { get; set; }

        [XmlElement("UnitCode", Order = 1)]
        public string UnitCode { get; set; }

        [XmlElement("DateReceivedFrom", Order = 2)]
        public string DateReceivedFrom { get; set; }

        [XmlElement("DateReceivedTo", Order = 3)]
        public string DateReceivedTo { get; set; }

        [XmlElement("InvoiceType", Order = 4)]
        public string InvoiceType { get; set; }

        [XmlElement("InvoiceNumber", Order = 5)]
        public string InvoiceNumber { get; set; }
    }
}
