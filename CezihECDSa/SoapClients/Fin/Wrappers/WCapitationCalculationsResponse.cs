using ECDSAClientServices.Wsdl.Fin;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Fin.Wrappers
{
    [XmlRoot("GetSpecificationForInvoiceRecapResponse", Namespace = "https://e-usluge.hzzo.hr/ews/finance")]
    public sealed class WGetSpecificationForInvoiceRecapResponse
    {
        public WGetSpecificationForInvoiceRecapResponse()
        {
        }

        public WGetSpecificationForInvoiceRecapResponse(SpecificationForInvoicesRecap output)
        {
            Output = output;
        }

        [XmlElement("GetSpecificationForInvoiceRecapResult", Order = 0)]
        public SpecificationForInvoicesRecap Output { get; set; }
    }
}
