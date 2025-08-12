using CezihECDSa.SoapClients.InfoOthers.Wrappers;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Evidencije
{
    public interface IEvidencijeClient
    {
        Result<ZahtjevOdgovor> PrijedlogZaProvjeruVozaca(
            WPrijedlogZaProvjeruVozacaRequest request);
    }

    public class EvidencijeClient : SoapClientBase, IEvidencijeClient
    {
        private readonly EvidencijeOptions _options;
        private readonly X509Certificate2 _cert;

        public EvidencijeClient(EvidencijeOptions options, X509Certificate2 cert) : base(SoapVersion.Soap11)
        {
            _options = options;
            _cert = cert;
        }

        public Result<ZahtjevOdgovor> PrijedlogZaProvjeruVozaca(
            WPrijedlogZaProvjeruVozacaRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "https://servis.hzzo.hr/cezih/evidencije/IEvidencije/PrijedlogZaProvjeruVozaca",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessEvidencijaResponse(result);

                return response;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private Result<ZahtjevOdgovor> ProcessEvidencijaResponse(SoapRequestResult result)
        {
            return ProcessResponse<WPrijedlogZaProvjeruVozacaResponse, ZahtjevOdgovor>(
                result,
                body => body.Output);
        }

        private XmlSerializerNamespaces Namespaces
        {
            get
            {
                var namespaces = new XmlSerializerNamespaces();

                return namespaces;
            }
        }
    }
}