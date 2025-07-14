
using CezihECDSa.Wsdl.InjuryApplicationService;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InjuryApplicationService
{
    public interface IInjuryApplicationServiceClient
    {
        Result<prijavaResponse> Prijava(prijavaRequest request);
        Task<Result<prijavaResponse>> PrijavaAsync(prijavaRequest request, CancellationToken ct = default);

        Result<listaPrijavaResponse> ListaPrijava(listaPrijavaRequest request);
        Task<Result<listaPrijavaResponse>> ListaPrijavaAsync(listaPrijavaRequest request, CancellationToken ct = default);

        Result<izvjesceLijecnikaResponse> IzvjesceLijecnika(izvjesceLijecnikaRequest request);
        Task<Result<izvjesceLijecnikaResponse>> IzvjesceLijecnikaAsync(izvjesceLijecnikaRequest request, CancellationToken ct = default);

        Result<string> Echo(string request);
        Task<Result<string>> EchoAsync(string request, CancellationToken ct = default);
    }

    public sealed class InjuryApplicationServiceClient : SoapClientBase, IInjuryApplicationServiceClient
    {
        private readonly InjuryApplicationServiceOptions _options;
        private readonly X509Certificate2 _cert;

        public InjuryApplicationServiceClient(InjuryApplicationServiceOptions options, X509Certificate2 cert)
            : base(SoapVersion.Soap11)
        {
            _options = options;
            _cert = cert;
        }

        protected override TimeSpan DefaultTimeout
        {
            get { return _options.Timeout ?? TimeSpan.FromSeconds(15); }
        }

        public Result<prijavaResponse> Prijava(prijavaRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "prijava",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                return ProcessPrijavaResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<prijavaResponse>> PrijavaAsync(prijavaRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "prijava",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                return ProcessPrijavaResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<listaPrijavaResponse> ListaPrijava(listaPrijavaRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "listaPrijava",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                return ProcessListaPrijavaResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<listaPrijavaResponse>> ListaPrijavaAsync(listaPrijavaRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "listaPrijava",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                return ProcessListaPrijavaResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<izvjesceLijecnikaResponse> IzvjesceLijecnika(izvjesceLijecnikaRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "izvjesceLijecnika",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                return ProcessIzvjesceLijecnikaResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<izvjesceLijecnikaResponse>> IzvjesceLijecnikaAsync(izvjesceLijecnikaRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "izvjesceLijecnika",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                return ProcessIzvjesceLijecnikaResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<string> Echo(string request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "echo",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                return ProcessEchoResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<string>> EchoAsync(string request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "echo",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                return ProcessEchoResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private Result<prijavaResponse> ProcessPrijavaResponse(SoapRequestResult result)
        {
            return ProcessResponse<prijavaResponse, prijavaResponse>(
                result,
                body => body);
        }

        private Result<listaPrijavaResponse> ProcessListaPrijavaResponse(SoapRequestResult result)
        {
            return ProcessResponse<listaPrijavaResponse, listaPrijavaResponse>(
                result,
                body => body);
        }

        private Result<izvjesceLijecnikaResponse> ProcessIzvjesceLijecnikaResponse(SoapRequestResult result)
        {
            return ProcessResponse<izvjesceLijecnikaResponse, izvjesceLijecnikaResponse>(
                result,
                body => body);
        }

        private Result<string> ProcessEchoResponse(SoapRequestResult result)
        {
            return ProcessResponse<string, string>(
                result,
                body => body);
        }

        private XmlSerializerNamespaces Namespaces
        {
            get
            {
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add("", "http://www.hzzo.hr/eozljede/webservice/operations");
                return namespaces;
            }
        }
    }
}
