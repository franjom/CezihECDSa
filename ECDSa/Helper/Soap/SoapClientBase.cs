using System;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
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
        private readonly ISoapRequestFactory _requestFactory;

        protected SoapClientBase(SoapVersion soapVersion)
        {
            _soapVersion = soapVersion;

            _requestFactory = soapVersion == SoapVersion.Soap11
                ? new Soap11RequestFactory()
                : new Soap12RequestFactory();
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
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
#if DEBUG
                ServerCertificateCustomValidationCallback = delegate { return true; },
#endif
            };

            var client = new HttpClient(handler)
            {
                Timeout = DefaultTimeout
            };

            return client;
        }

        protected async Task<SoapRequestResult> SendRequestAsync(SoapOptions options, CancellationToken ct = default)
        {
            using var request = _requestFactory.CreateSoapRequest(options);
            return await SendAsyncInternal(request, options, ct);
        }

        protected SoapRequestResult SendRequest(SoapOptions options)
        {
            using var request = _requestFactory.CreateSoapRequest(options);
            return SendSyncInternal(request, options);
        }

        protected Result<XmlDocument> ProcessResponse(SoapRequestResult result)
        {
            return _requestFactory.ProcessResponse(result);
        }

        private async Task<SoapRequestResult> SendAsyncInternal(HttpRequestMessage request, SoapOptions options,
            CancellationToken ct)
        {
            try
            {
                using var client = CreateHttpClient(options.Certificate);
                return await SendRequestAsync(client, request, ct);
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

        private SoapRequestResult SendSyncInternal(HttpRequestMessage request, SoapOptions options)
        {
            try
            {
                using var client = CreateHttpClient(options.Certificate);
                return SendRequestSync(request, client);
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

        private static async Task<SoapRequestResult> SendRequestAsync(HttpClient client, HttpRequestMessage request,
            CancellationToken ct)
        {
            using var response = await client.SendAsync(request, HttpCompletionOption.ResponseContentRead, ct);
            var content = await response.Content.ReadAsStringAsync();
            return new SoapRequestResult
            {
                IsSuccessStatusCode = response.IsSuccessStatusCode,
                Content = string.IsNullOrWhiteSpace(content) ? response.ReasonPhrase : content
            };
        }

        private static SoapRequestResult SendRequestSync(HttpRequestMessage request, HttpClient client)
        {
            using var response = client.SendAsync(request).GetAwaiter().GetResult();
            var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            return new SoapRequestResult
            {
                IsSuccessStatusCode = response.IsSuccessStatusCode,
                Content = string.IsNullOrWhiteSpace(content) ? response.ReasonPhrase : content
            };
        }
    }
}