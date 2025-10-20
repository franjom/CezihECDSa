using CezihECDSa.Wsdl.DohvatSmjernica;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.DohvatSmjernica
{
    public interface IDohvatSmjernicaClient
    {
        Task<Result<DohvatiSmjerniceResponse>> DohvatiSmjerniceAsync(DohvatiSmjerniceRequest request, CancellationToken ct = default);
    }

    public sealed class DohvatSmjernicaClient : SoapClientBase
    {
        private readonly DohvatSmjernicaOptions _options;
        private readonly X509Certificate2 _cert;

        public DohvatSmjernicaClient(DohvatSmjernicaOptions options, X509Certificate2 cert) : base(SoapVersion.Soap11)
        {
            _options = options;
            _cert = cert;
        }

        protected override TimeSpan DefaultTimeout
        {
            get { return _options.Timeout ?? TimeSpan.FromSeconds(60); }
        }


        public Result<DohvatiSmjerniceResponse> DohvatiSmjernica(DohvatiSmjerniceRequest request,
                CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://tempuri.org/DohvatiSmjernice",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                return ProcessRetrieveDocumentSetResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private Result<DohvatiSmjerniceResponse> ProcessRetrieveDocumentSetResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<DohvatiSmjerniceResponseBody,
                DohvatiSmjerniceResponse>(
                result,
                body => new DohvatiSmjerniceResponse(body));
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
