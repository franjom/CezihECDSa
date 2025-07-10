using ECDSa.Helper.Soap._1_1;
using ECDSa.Helper.Soap._1_2;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace ECDSa.Helper.Soap
{
    public enum SoapVersion
    {
        Soap11,
        Soap12
    }

    public abstract class SoapClientBase
    {
        private readonly SoapVersion _soapVersion;

        protected SoapClientBase(SoapVersion soapVersion)
        {
            _soapVersion = soapVersion;
        }

        protected virtual TimeSpan DefaultTimeout
        {
            get { return TimeSpan.FromSeconds(15); }
        }

        protected HttpClient CreateHttpClient(X509Certificate2 cert)
        {
            var handler = new HttpClientHandler
            {
                ClientCertificates = { cert },
#if DEBUG
                ServerCertificateCustomValidationCallback = delegate { return true; }
#endif
            };

            var client = new HttpClient(handler)
            {
                Timeout = DefaultTimeout
            };

            return client;
        }

        protected Result<TResponse> ProcessResponse<TBody, TResponse>(SoapRequestResult result,
            Func<TBody, TResponse> responseFactory)
        {
            if (result.IsSoap11)
            {
                return ProcessSoap11Response(result, responseFactory);
            }

            if (result.IsSoap12)
            {
                return ProcessSoap12Response(result, responseFactory);
            }

            // fallback to _soapVersion

            if (_soapVersion == SoapVersion.Soap12)
            {
                return ProcessSoap12Response(result, responseFactory);
            }

            return ProcessSoap11Response(result, responseFactory);
        }

        protected Task<SoapRequestResult> SendRequestAsync(SoapOptions options, CancellationToken ct)
        {
            if (_soapVersion == SoapVersion.Soap12)
            {
                return SendRequest12Async(options, ct);
            }

            return SendRequest11Async(options, ct);
        }

        protected Task<SoapRequestResult> SendSignedRequestAsync(SoapOptions options, CancellationToken ct)
        {
            if (_soapVersion == SoapVersion.Soap12)
            {
                return SendSignedRequest12Async(options, ct);
            }

            return SendSignedRequest11Async(options, ct);
        }

        protected SoapRequestResult SendRequest(SoapOptions options)
        {
            if (_soapVersion == SoapVersion.Soap12)
            {
                return SendRequest12(options);
            }

            return SendRequest11(options);
        }

        protected SoapRequestResult SendSignedRequest(SoapOptions options)
        {
            if (_soapVersion == SoapVersion.Soap12)
            {
                return SendSignedRequest12(options);
            }

            return SendSignedRequest11(options);
        }

        private SoapRequestResult SendRequest11(SoapOptions options)
        {
            var request = CreateSoap11Request(options);
            using (var client = CreateHttpClient(options.Certificate))
            {
                return SendSyncInternal(request, client);
            }
        }

        private async Task<SoapRequestResult> SendRequest11Async(SoapOptions options, CancellationToken ct)
        {
            var request = CreateSoap11Request(options);
            using (var client = CreateHttpClient(options.Certificate))
            {
                return await SendAsyncInternal(request, client, ct);
            }
        }

        private SoapRequestResult SendSignedRequest11(SoapOptions options)
        {
            var request = CreateSoap11SignedRequest(options);
            using (var client = CreateHttpClient(options.Certificate))
            {
                return SendSyncInternal(request, client);
            }
        }

        private Task<SoapRequestResult> SendSignedRequest11Async(SoapOptions options, CancellationToken ct)
        {
            var request = CreateSoap11SignedRequest(options);
            using (var client = CreateHttpClient(options.Certificate))
            {
                return SendAsyncInternal(request, client, ct);
            }
        }

        private SoapRequestResult SendRequest12(SoapOptions options)
        {
            var request = CreateSoap12Request(options);
            using (var client = CreateHttpClient(options.Certificate))
            {
                return SendSyncInternal(request, client);
            }
        }

        private async Task<SoapRequestResult> SendRequest12Async(SoapOptions options, CancellationToken ct)
        {
            var request = CreateSoap12Request(options);
            using (var client = CreateHttpClient(options.Certificate))
            {
                return await SendAsyncInternal(request, client, ct);
            }
        }

        private SoapRequestResult SendSignedRequest12(SoapOptions options)
        {
            var request = CreateSignedSoap12Request(options);
            using (var client = CreateHttpClient(options.Certificate))
            {
                return SendSyncInternal(request, client);
            }
        }

        private Task<SoapRequestResult> SendSignedRequest12Async(SoapOptions options, CancellationToken ct)
        {
            var request = CreateSignedSoap12Request(options);
            using (var client = CreateHttpClient(options.Certificate))
            {
                return SendAsyncInternal(request, client, ct);
            }
        }

        private static Result<TResponse> ProcessSoap11Response<TBody, TResponse>(SoapRequestResult result,
            Func<TBody, TResponse> responseFactory)
        {
            if (!result.IsSuccessStatusCode)
            {
                if (!result.IsXml)
                {
                    return new ErrorMessage(result.Content);
                }

                var envDoc = new XmlDocument();
                envDoc.LoadXml(result.Content);
                var envelope = SoapSerializer.Instance.Deserialize<Envelope11>(envDoc);
                var error = envelope.Body?.Fault?.FaultString;

                if (!string.IsNullOrEmpty(error))
                {
                    result.IsFault = true;
                    return new ErrorMessage(error);
                }

                return new ErrorMessage(result.Content);
            }

            if (result.IsXml)
            {
                var envDoc = new XmlDocument();
                envDoc.LoadXml(result.Content);
                var envelope = SoapSerializer.Instance.Deserialize<Envelope11>(envDoc);
                var error = envelope.Body?.Fault?.FaultString;

                if (!string.IsNullOrEmpty(error))
                {
                    result.IsFault = true;
                    return new ErrorMessage(error);
                }
            }

            var bodyDoc = SoapEnvelopeHelper.GetSoapBody11Contents(result.Content);
            var body = SoapSerializer.Instance.Deserialize<TBody>(bodyDoc);
            return responseFactory(body);
        }

        private static Result<TResponse> ProcessSoap12Response<TBody, TResponse>(SoapRequestResult result,
            Func<TBody, TResponse> responseFactory)
        {
            if (!result.IsSuccessStatusCode)
            {
                if (!result.IsXml)
                {
                    return new ErrorMessage(result.Content);
                }

                var envDoc = new XmlDocument();
                envDoc.LoadXml(result.Content);
                var envelope = SoapSerializer.Instance.Deserialize<Envelope12>(envDoc);
                var errors = envelope.Body?.Fault?.Detail?.Errors;

                if (errors != null && errors.Count > 0)
                {
                    result.IsFault = true;
                    return errors.Select(o => new ErrorMessage(o.Description)).ToList();
                }

                return new ErrorMessage(result.Content);
            }

            if (result.IsXml)
            {
                var envDoc = new XmlDocument();
                envDoc.LoadXml(result.Content);
                var envelope = SoapSerializer.Instance.Deserialize<Envelope12>(envDoc);
                var errors = envelope.Body?.Fault?.Detail?.Errors;

                if (errors != null && errors.Count > 0)
                {
                    result.IsFault = true;
                    return errors.Select(o => new ErrorMessage(o.Description)).ToList();
                }
            }

            var bodyDoc = SoapEnvelopeHelper.GetSoapBody12Contents(result.Content);
            var body = SoapSerializer.Instance.Deserialize<TBody>(bodyDoc);
            return responseFactory(body);
        }

        private static HttpRequestMessage CreateSoap11Request(SoapOptions options)
        {
            return CreateSoapRequest(options, SoapEnvelopeHelper.CreateSoap11Envelope, false);
        }

        private static HttpRequestMessage CreateSoap11SignedRequest(SoapOptions options)
        {
            return CreateSoapRequest(options, SoapEnvelopeHelper.CreateSoap11SignedEnvelope, false);
        }

        private static HttpRequestMessage CreateSoap12Request(SoapOptions options)
        {
            return CreateSoapRequest(options, SoapEnvelopeHelper.CreateSoap12Envelope, true);
        }

        private static HttpRequestMessage CreateSignedSoap12Request(SoapOptions options)
        {
            return CreateSoapRequest(options, SoapEnvelopeHelper.CreateSoap12SignedEnvelope, true);
        }

        private static HttpRequestMessage CreateSoapRequest(
            SoapOptions options,
            Func<SoapOptions, string> envelopeBuilder,
            bool isSoap12)
        {
            var soapEnvelope = envelopeBuilder(options);
            var request = new HttpRequestMessage(HttpMethod.Post, options.Uri)
            {
                Content = new StringContent(soapEnvelope, Encoding.UTF8)
            };

            if (isSoap12)
            {
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/soap+xml")
                {
                    CharSet = Encoding.UTF8.WebName
                };
                request.Content.Headers.ContentType.Parameters.Add(
                    new NameValueHeaderValue("action", $"\"{options.SoapAction}\""));
            }
            else
            {
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("text/xml")
                {
                    CharSet = Encoding.UTF8.WebName
                };
                request.Headers.Add("SOAPAction", options.SoapAction);
            }

            request.Headers.UserAgent.ParseAdd("OpenCezih.NET");
            request.Headers.AcceptEncoding.ParseAdd("gzip,deflate");
            return request;
        }


        private static async Task<SoapRequestResult> SendAsyncInternal(HttpRequestMessage request, HttpClient client,
            CancellationToken ct)
        {
            try
            {
                using (var response = await client.SendAsync(request, ct))
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return new SoapRequestResult
                    {
                        IsSuccessStatusCode = response.IsSuccessStatusCode,
                        Content = string.IsNullOrWhiteSpace(content) ? response.ReasonPhrase : content
                    };
                }
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }

                return new SoapRequestResult
                {
                    IsSuccessStatusCode = false,
                    Content = ex.Message
                };
            }
        }

        private static SoapRequestResult SendSyncInternal(HttpRequestMessage request, HttpClient client)
        {
            try
            {
                using (var response = client.SendAsync(request).GetAwaiter().GetResult())
                {
                    var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    return new SoapRequestResult
                    {
                        IsSuccessStatusCode = response.IsSuccessStatusCode,
                        Content = string.IsNullOrWhiteSpace(content) ? response.ReasonPhrase : content
                    };
                }
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }

                return new SoapRequestResult
                {
                    IsSuccessStatusCode = false,
                    Content = ex.Message
                };
            }
        }
    }
}