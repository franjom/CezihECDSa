using CezihECDSa.SoapClients.Cezdlih.Wrappers;
using CezihECDSa.Wsdl;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih
{
    public interface ICezdlihClient
    {
        Result<PreuzimanjePlanaImunizacijeResponse> PreuzimanjePlanaImunizacije(
            PreuzimanjePlanaImunizacijeRequest request);

        Task<Result<PreuzimanjePlanaImunizacijeResponse>> PreuzimanjePlanaImunizacijeAsync(
            PreuzimanjePlanaImunizacijeRequest request, CancellationToken ct = default);

        Result<SlanjePlanaImunizacijeResponse> SlanjePlanaImunizacije(SlanjePlanaImunizacijeRequest request);

        Task<Result<SlanjePlanaImunizacijeResponse>> SlanjePlanaImunizacijeAsync(SlanjePlanaImunizacijeRequest request,
            CancellationToken ct = default);
    }

    public class CezdlihClient : SoapClientBase, ICezdlihClient
    {
        private readonly CezdlihOptions _options;
        private readonly X509Certificate2 _cert;

        public CezdlihClient(CezdlihOptions options, X509Certificate2 cert) : base(SoapVersion.Soap12)
        {
            _options = options;
            _cert = cert;
        }

        public Result<PreuzimanjePlanaImunizacijeResponse> PreuzimanjePlanaImunizacije(
            PreuzimanjePlanaImunizacijeRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPreuzimanjePlanaImunizacijeRequest(request.PreuzimanjePlanaImunizacijeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjePlanaImunizacije",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessPreuzimanjePlanaImunizacijeResponse(result);

                if (!response.IsError
                    && response.Value.PreuzimanjePlanaImunizacijeResult?.ListaGresaka != null
                    && response.Value.PreuzimanjePlanaImunizacijeResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .PreuzimanjePlanaImunizacijeResult
                        .ListaGresaka
                        .Select(o => new ErrorMessage(o.NazivGreske))
                        .ToList();
                }

                return response;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<PreuzimanjePlanaImunizacijeResponse>> PreuzimanjePlanaImunizacijeAsync(
            PreuzimanjePlanaImunizacijeRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPreuzimanjePlanaImunizacijeRequest(request.PreuzimanjePlanaImunizacijeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjePlanaImunizacije",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessPreuzimanjePlanaImunizacijeResponse(result);

                if (!response.IsError
                    && response.Value.PreuzimanjePlanaImunizacijeResult?.ListaGresaka != null
                    && response.Value.PreuzimanjePlanaImunizacijeResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .PreuzimanjePlanaImunizacijeResult
                        .ListaGresaka
                        .Select(o => new ErrorMessage(o.NazivGreske))
                        .ToList();
                }

                return response;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<SlanjePlanaImunizacijeResponse> SlanjePlanaImunizacije(SlanjePlanaImunizacijeRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjePlanaImunizacijeRequest(request.SlanjePlanaImunizacijeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjePlanaImunizacije",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessSlanjePlanaImunizacijeResponse(result);

                if (!response.IsError
                    && response.Value.SlanjePlanaImunizacijeResult?.ListaGresaka != null
                    && response.Value.SlanjePlanaImunizacijeResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .SlanjePlanaImunizacijeResult
                        .ListaGresaka
                        .Select(o => new ErrorMessage(o.NazivGreske))
                        .ToList();
                }

                return response;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<SlanjePlanaImunizacijeResponse>> SlanjePlanaImunizacijeAsync(
            SlanjePlanaImunizacijeRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjePlanaImunizacijeRequest(request.SlanjePlanaImunizacijeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjePlanaImunizacije",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessSlanjePlanaImunizacijeResponse(result);

                if (!response.IsError
                    && response.Value.SlanjePlanaImunizacijeResult?.ListaGresaka != null
                    && response.Value.SlanjePlanaImunizacijeResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .SlanjePlanaImunizacijeResult
                        .ListaGresaka
                        .Select(o => new ErrorMessage(o.NazivGreske))
                        .ToList();
                }

                return response;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private Result<PreuzimanjePlanaImunizacijeResponse> ProcessPreuzimanjePlanaImunizacijeResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<WPreuzimanjePlanaImunizacijeResponse,
                PreuzimanjePlanaImunizacijeResponse>(
                result,
                response => new PreuzimanjePlanaImunizacijeResponse(response.Result));
        }

        private Result<SlanjePlanaImunizacijeResponse> ProcessSlanjePlanaImunizacijeResponse(SoapRequestResult result)
        {
            return ProcessResponse<WSlanjePlanaImunizacijeResponse,
                SlanjePlanaImunizacijeResponse>(
                result,
                response => new SlanjePlanaImunizacijeResponse(response.Result));
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