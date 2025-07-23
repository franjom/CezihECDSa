using CezihECDSa.SoapClients.PrijavaZarazne;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using HRVozaci;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.HrVozaci
{
    public interface IHRVozaci
    {
        // @formatter:off
        Result<SlanjeRezultataResponse> SlanjeRezultata(SlanjeRezultataRequest request);
        Task<Result<SlanjeRezultataResponse>> SlanjeRezultataAsync(SlanjeRezultataRequest request, CancellationToken ct = default);

        // @formatter:on
    }

    public sealed class HrVozaciClient : SoapClientBase, IHRVozaci
    {
        private readonly HrVozaciOptions _options;
        private readonly X509Certificate2 _cert;

        public HrVozaciClient(HrVozaciOptions options, X509Certificate2 cert) : base(SoapVersion.Soap11)
        {
            _options = options;
            _cert = cert;
        }

        protected override TimeSpan DefaultTimeout
        {
            get { return _options.Timeout ?? TimeSpan.FromSeconds(15); }
        }

        public Result<SlanjeRezultataResponse> SlanjeRezultata(
            SlanjeRezultataRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezih.hr/HrVozacke/Outgoing/SlanjeRezultata",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                return ProcessSlanjeRezultataResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<SlanjeRezultataResponse>>
            SlanjeRezultataAsync(SlanjeRezultataRequest request,
                CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezih.hr/HrVozacke/Outgoing/SlanjeRezultata",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                return ProcessSlanjeRezultataResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private Result<SlanjeRezultataResponse> ProcessSlanjeRezultataResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<SlanjeRezultataResponse, SlanjeRezultataResponse>(
                result,
                body => body);
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