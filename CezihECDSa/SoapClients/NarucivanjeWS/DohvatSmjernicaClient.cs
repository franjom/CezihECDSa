using CezihECDSa.SoapClients.NarucivanjeWS.Wrappers;
using CezihECDSa.Wsdl.DohvatSmjernica;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.NarucivanjeWS
{
    public interface IDohvatSmjernicaClient
    {
        Task<Result<DohvatiSmjerniceResponse>> DohvatiSmjerniceAsync(
            WDohvatiSmjerniceRequest request, CancellationToken ct = default);
    }

    public class DohvatSmjernicaClient : SoapClientBase, IDohvatSmjernicaClient
    {
        private readonly DohvatSmjernicaOptions _options;
        private readonly X509Certificate2 _cert;

        public DohvatSmjernicaClient(DohvatSmjernicaOptions options, X509Certificate2 cert) : base(SoapVersion.Soap12)
        {
            _options = options;
            _cert = cert;
        }

        public async Task<Result<DohvatiSmjerniceResponse>> DohvatiSmjerniceAsync(WDohvatiSmjerniceRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                //xml = xml.Remove(0, "<?xml version=\"1.0\" encoding=\"utf-8\"?>".Length + 1);

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://tempuri.org/DohvatiSmjernice",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                return ProcessSmjerniceResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private Result<DohvatiSmjerniceResponse> ProcessSmjerniceResponse(SoapRequestResult result)
        {
            return ProcessResponse<DohvatiSmjerniceResponse, DohvatiSmjerniceResponse>(
                result,
                body => body);
        }

        private XmlSerializerNamespaces Namespaces
        {
            get
            {
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add("", "http://tempuri.org/");

                return namespaces;
            }
        }
    }
}