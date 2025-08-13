using CezihECDSa.Wsdl.SkolskaMedicina;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.SkolskaMedicina
{
    public interface ISkolskaMedicinaClient
    {
        // @formatter:off
        Task<Result<ZaprimanjeIzvjestajaResponse>> ZaprimanjeIzvjestajaAsync(ZaprimanjeIzvjestajaRequest request, CancellationToken ct = default);
        Task<Result<StatusIzvjestajaResponse>> StatusIzvjestajaAsync(StatusIzvjestajaRequest request, CancellationToken ct = default);

        // @formatter:on
    }

    public sealed class SkolskaMedicinaClient : SoapClientBase, ISkolskaMedicinaClient
    {
        private readonly SkolskaMedicinaOptions _options;
        private readonly X509Certificate2 _cert;

        public SkolskaMedicinaClient(SkolskaMedicinaOptions options, X509Certificate2 cert) : base(SoapVersion.Soap12)
        {
            _options = options;
            _cert = cert;
        }

        protected override TimeSpan DefaultTimeout
        {
            get { return _options.Timeout ?? TimeSpan.FromSeconds(15); }
        }

        public Result<ZaprimanjeIzvjestajaResponse> ZaprimanjeIzvjestaja(
            ZaprimanjeIzvjestajaRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "https://ws.cezih.hr:15443/skolska/ZaprimanjeIzvjestaja",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                return ProcessZaprimanjeIzvjestajaResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<ZaprimanjeIzvjestajaResponse>> ZaprimanjeIzvjestajaAsync(
            ZaprimanjeIzvjestajaRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "https://ws.cezih.hr:15443/skolska/ZaprimanjeIzvjestaja",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                return ProcessZaprimanjeIzvjestajaResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<StatusIzvjestajaResponse> StatusIzvjestaja(StatusIzvjestajaRequestBody request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "https://ws.cezih.hr:15443/skolska/StatusIzvjestaja",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                return ProcessStatusIzvjestajaResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<StatusIzvjestajaResponse>> StatusIzvjestajaAsync(StatusIzvjestajaRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "https://ws.cezih.hr:15443/skolska/StatusIzvjestaja",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                return ProcessStatusIzvjestajaResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<PromjenaPostojecegIzvjestajaResponse> PromjenaPostojecegIzvjestajaAsync(PromjenaPostojecegIzvjestajaRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "https://ws.cezih.hr:15443/skolska/PromjenaPostojecegIzvjestaja",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                return ProcessPostojecegIzvjestajaResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<PostojiLiNoviZadatakResponse> PostojiLiNoviZadatakAsync(PostojiLiNoviZadatakRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "https://ws.cezih.hr:15443/skolska/PostojiLiNoviZadatak",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                return ProcessPostojiLiNoviZadatakResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<StatusZadatkaResponse> StatusZadatkaAsync(StatusZadatkaRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "https://ws.cezih.hr:15443/skolska/StatusZadatka",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                return ProcessStatusZadatkaResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<SkolskiObvezniciResponse> SkolskiObvezniciAsync(SkolskiObvezniciRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "https://ws.cezih.hr:15443/skolska/SkolskiObveznici",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                return ProcessSkolskiObvezniciResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<PopisUcenikaPoSkolamaResponse> PopisUcenikaPoSkolamaAsync(PopisUcenikaPoSkolamaRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "https://ws.cezih.hr:15443/skolska/PopisUcenikaPoSkolama",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                return ProcessPopisUcenikaPoSkolamaResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }


        private Result<ZaprimanjeIzvjestajaResponse> ProcessZaprimanjeIzvjestajaResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<ZaprimanjeIzvjestajaResponseBody,
                ZaprimanjeIzvjestajaResponse>(
                result,
                body => new ZaprimanjeIzvjestajaResponse(body));
        }

        private Result<StatusIzvjestajaResponse> ProcessStatusIzvjestajaResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<StatusIzvjestajaResponseBody,
                StatusIzvjestajaResponse>(
                result,
                body => new StatusIzvjestajaResponse(body));
        }

        private Result<PromjenaPostojecegIzvjestajaResponse> ProcessPostojecegIzvjestajaResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<PromjenaPostojecegIzvjestajaResponseBody,
                PromjenaPostojecegIzvjestajaResponse>(
                result,
                body => new PromjenaPostojecegIzvjestajaResponse(body));
        }

        private Result<PostojiLiNoviZadatakResponse> ProcessPostojiLiNoviZadatakResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<PostojiLiNoviZadatakResponseBody,
                PostojiLiNoviZadatakResponse>(
                result,
                body => new PostojiLiNoviZadatakResponse(body));
        }

        private Result<StatusZadatkaResponse> ProcessStatusZadatkaResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<StatusZadatkaResponseBody,
                StatusZadatkaResponse>(
                result,
                body => new StatusZadatkaResponse(body));
        }

        private Result<SkolskiObvezniciResponse> ProcessSkolskiObvezniciResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<SkolskiObvezniciResponseBody,
                SkolskiObvezniciResponse>(
                result,
                body => new SkolskiObvezniciResponse(body));
        }

        private Result<PopisUcenikaPoSkolamaResponse> ProcessPopisUcenikaPoSkolamaResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<PopisUcenikaPoSkolamaResponseBody,
                PopisUcenikaPoSkolamaResponse>(
                result,
                body => new PopisUcenikaPoSkolamaResponse(body));
        }

        private XmlSerializerNamespaces Namespaces
        {
            get
            {
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add("lcm", "urn:oasis:names:tc:ebxml-regrep:xsd:lcm:3.0");
                namespaces.Add("rim", "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0");
                namespaces.Add("rs", "urn:oasis:names:tc:ebxml-regrep:xsd:rs:3.0");
                namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

                return namespaces;
            }
        }
    }
}