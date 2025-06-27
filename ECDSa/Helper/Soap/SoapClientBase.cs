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

        protected virtual TimeSpan DefaultTimeout => TimeSpan.FromSeconds(15);

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
            if (_soapVersion == SoapVersion.Soap12)
            {
                return ProcessSoap12Response(result, responseFactory);
            }

            return ProcessSoap11Response(result, responseFactory);
        }

        protected Task<SoapRequestResult> SendRequestAsync(string xmlString, string soapAction,
            X509Certificate2 cert, Uri uri, CancellationToken ct)
        {
            if (_soapVersion == SoapVersion.Soap12)
            {
                return SendRequest12Async(xmlString, soapAction, cert, uri, ct);
            }

            return SendRequest11Async(xmlString, soapAction, cert, uri, ct);
        }

        protected SoapRequestResult SendRequest(string xmlString, string soapAction,
            X509Certificate2 cert, Uri uri)
        {
            if (_soapVersion == SoapVersion.Soap12)
            {
                return SendRequest12(xmlString, soapAction, cert, uri);
            }

            return SendRequest11(xmlString, soapAction, cert, uri);
        }

        private async Task<SoapRequestResult> SendRequest11Async(string xmlString, string soapAction,
            X509Certificate2 cert, Uri uri, CancellationToken ct)
        {
            var request = CreateSoap11Request(xmlString, soapAction, uri);
            using (var client = CreateHttpClient(cert))
            {
                return await SendAsyncInternal(request, client, ct);
            }
        }

        private async Task<SoapRequestResult> SendRequest12Async(string xmlString, string soapAction,
            X509Certificate2 cert, Uri uri, CancellationToken ct)
        {
            var request = CreateSoap12Request(xmlString, soapAction, cert, uri);
            using (var client = CreateHttpClient(cert))
            {
                return await SendAsyncInternal(request, client, ct);
            }
        }

        private SoapRequestResult SendRequest11(string xmlString, string soapAction,
            X509Certificate2 cert, Uri uri)
        {
            var request = CreateSoap11Request(xmlString, soapAction, uri);
            using (var client = CreateHttpClient(cert))
            {
                return SendSyncInternal(request, client);
            }
        }

        private SoapRequestResult SendRequest12(string xmlString, string soapAction,
            X509Certificate2 cert, Uri uri)
        {
            var request = CreateSoap12Request(xmlString, soapAction, cert, uri);
            using (var client = CreateHttpClient(cert))
            {
                return SendSyncInternal(request, client);
            }
        }

        private static Result<TResponse> ProcessSoap11Response<TBody, TResponse>(SoapRequestResult result,
            Func<TBody, TResponse> responseFactory)
        {
            if (!result.IsSuccessStatusCode && result.IsXml)
            {
                var envDoc = new XmlDocument();
                envDoc.LoadXml(result.Content);
                var envelope = SoapSerializer.Instance.Deserialize<Envelope11>(envDoc);
                var error = envelope.Body?.Fault?.FaultString;

                if (!string.IsNullOrWhiteSpace(error))
                {
                    return new ErrorMessage(error);
                }

                return new ErrorMessage("Response is not a valid XML document.");
            }

            if (!result.IsSuccessStatusCode)
            {
                return new ErrorMessage(result.Content);
            }

            var bodyDoc = SoapEnvelopeHelper.GetSoapBody11Contents(result.Content);
            var body = SoapSerializer.Instance.Deserialize<TBody>(bodyDoc);
            return responseFactory(body);
        }

        private static Result<TResponse> ProcessSoap12Response<TBody, TResponse>(SoapRequestResult result,
            Func<TBody, TResponse> responseFactory)
        {
            if (!result.IsSuccessStatusCode && result.IsXml)
            {
                var envDoc = new XmlDocument();
                envDoc.LoadXml(result.Content);
                var envelope = SoapSerializer.Instance.Deserialize<Envelope12>(envDoc);
                var errors = envelope.Body?.Fault?.Detail?.Errors;

                if (errors != null && errors.Count > 0)
                    return errors.Select(o => new ErrorMessage(o.Description)).ToList();

                return new ErrorMessage("Response is not a valid XML document.");
            }

            if (!result.IsSuccessStatusCode)
            {
                return new ErrorMessage(result.Content);
            }

            var bodyDoc = SoapEnvelopeHelper.GetSoapBody12Contents(result.Content);
            var body = SoapSerializer.Instance.Deserialize<TBody>(bodyDoc);
            return responseFactory(body);
        }

        private static HttpRequestMessage CreateSoap11Request(string xmlString, string soapAction, Uri uri)
        {
            var soapEnvelope = SoapEnvelopeHelper.CreateSoap11Envelope(xmlString);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, uri)
            {
                Content = new StringContent(soapEnvelope, Encoding.UTF8, "text/xml")
            };

            httpRequest.Headers.Add("SOAPAction", soapAction);
            httpRequest.Headers.UserAgent.ParseAdd($"OpenCezih.NET");
            httpRequest.Headers.AcceptEncoding.ParseAdd("gzip,deflate");

            return httpRequest;
        }

        private static HttpRequestMessage CreateSoap12Request(string xmlString, string soapAction,
            X509Certificate2 cert, Uri uri)
        {
            var soapEnvelope = SoapEnvelopeHelper.CreateSoap12SignedEnvelope(
                xmlString,
                soapAction,
                uri.ToString(),
                cert
            );

            var request = new HttpRequestMessage(HttpMethod.Post, uri)
            {
                Content = new StringContent(soapEnvelope, Encoding.UTF8)
            };

            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/soap+xml")
            {
                CharSet = Encoding.UTF8.WebName
            };
            request.Content.Headers.ContentType.Parameters.Add(
                new NameValueHeaderValue("action", $"\"{soapAction}\""));

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
                        Content = content
                    };
                }
            }
            catch (Exception ex)
            {
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
                        Content = content
                    };
                }
            }
            catch (Exception ex)
            {
                return new SoapRequestResult
                {
                    IsSuccessStatusCode = false,
                    Content = ex.Message
                };
            }
        }
    }
}