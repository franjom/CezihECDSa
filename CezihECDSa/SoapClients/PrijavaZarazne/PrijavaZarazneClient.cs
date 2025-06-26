using CezihECDSa.Soap;
using CezihECDSa.Wsdl.PrijavaZarazne;
using CezihECDSa.Wsdl.PrijavaZarazneUpdate;
using ECDSa.Helper;
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
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.PrijavaZarazne
{
    public interface DocumentRepository_PortType
    {
        // @formatter:off
        Result<DocumentRepository_RetrieveDocumentSetResponse> DocumentRepository_RetrieveDocumentSet(DocumentRepository_RetrieveDocumentSetRequest request);

        Task<Result<DocumentRepository_RetrieveDocumentSetResponse>> DocumentRepository_RetrieveDocumentSetAsync(DocumentRepository_RetrieveDocumentSetRequest request, CancellationToken ct = default);

        Result<DocumentRepository_ProvideAndRegisterDocumentSetbResponse> DocumentRepository_ProvideAndRegisterDocumentSetb(DocumentRepository_ProvideAndRegisterDocumentSetbRequest request);

        Task<Result<DocumentRepository_ProvideAndRegisterDocumentSetbResponse>> DocumentRepository_ProvideAndRegisterDocumentSetbAsync(DocumentRepository_ProvideAndRegisterDocumentSetbRequest request, CancellationToken ct = default);
        
        Result<DocumentRegistry_UpdateDocumentSetResponse> DocumentRegistry_UpdateDocumentSet(DocumentRegistry_UpdateDocumentSetRequest request);

        Task<Result<DocumentRegistry_UpdateDocumentSetResponse>> DocumentRegistry_UpdateDocumentSetAsync(DocumentRegistry_UpdateDocumentSetRequest request, CancellationToken ct = default);
        // @formatter:on
    }

    public sealed class PrijavaZarazneClient : DocumentRepository_PortType
    {
        private readonly PrijavaZarazneOptions _options;
        private readonly X509Certificate2 _cert;

        public PrijavaZarazneClient(PrijavaZarazneOptions options, X509Certificate2 cert)
        {
            _options = options;
            _cert = cert;
        }

        public Result<DocumentRepository_RetrieveDocumentSetResponse> DocumentRepository_RetrieveDocumentSet(
            DocumentRepository_RetrieveDocumentSetRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request.RetrieveDocumentSetRequest, Namespaces);
                var uri = new Uri(_options.BaseUri, "/WS/IHE/XDS_DocumentRegistry");

                var result = SendRequest(xml, "urn:ihe:iti:2007:RetrieveDocumentSet", _cert, uri);

                return ProcessRetrieveDocumentSetResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<DocumentRepository_RetrieveDocumentSetResponse>>
            DocumentRepository_RetrieveDocumentSetAsync(
                DocumentRepository_RetrieveDocumentSetRequest request,
                CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request.RetrieveDocumentSetRequest, Namespaces);
                var uri = new Uri(_options.BaseUri, "/WS/IHE/XDS_DocumentRegistry");

                var result = await SendRequestAsync(xml, "urn:ihe:iti:2007:RetrieveDocumentSet", _cert, uri, ct);

                return ProcessRetrieveDocumentSetResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }


        public Result<DocumentRepository_ProvideAndRegisterDocumentSetbResponse>
            DocumentRepository_ProvideAndRegisterDocumentSetb(
                DocumentRepository_ProvideAndRegisterDocumentSetbRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request.ProvideAndRegisterDocumentSetRequest, Namespaces);
                var uri = new Uri(_options.BaseUri, "/WS/IHE/XDS_DocumentRepository");

                var result = SendRequest(xml, "urn:ihe:iti:2007:ProvideAndRegisterDocumentSet-b", _cert, uri);

                return ProcessProvideAndRegisterResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<DocumentRepository_ProvideAndRegisterDocumentSetbResponse>>
            DocumentRepository_ProvideAndRegisterDocumentSetbAsync(
                DocumentRepository_ProvideAndRegisterDocumentSetbRequest request,
                CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request.ProvideAndRegisterDocumentSetRequest, Namespaces);
                var uri = new Uri(_options.BaseUri, "/WS/IHE/XDS_DocumentRepository");

                var result = await SendRequestAsync(xml, "urn:ihe:iti:2007:ProvideAndRegisterDocumentSet-b", _cert, uri,
                    ct);

                return ProcessProvideAndRegisterResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<DocumentRegistry_UpdateDocumentSetResponse> DocumentRegistry_UpdateDocumentSet(
            DocumentRegistry_UpdateDocumentSetRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request.SubmitObjectsRequest, Namespaces);
                var uri = new Uri(_options.BaseUri, "/WS/IHE/XDS_UpdateDocumentSet");

                var result = SendRequest(xml, "urn:ihe:iti:2010:UpdateDocumentSet", _cert, uri);

                return ProcessUpdateDocumentSetResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<DocumentRegistry_UpdateDocumentSetResponse>> DocumentRegistry_UpdateDocumentSetAsync(
            DocumentRegistry_UpdateDocumentSetRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request.SubmitObjectsRequest, Namespaces);
                var uri = new Uri(_options.BaseUri, "/WS/IHE/XDS_UpdateDocumentSet");

                var result = await SendRequestAsync(xml, "urn:ihe:iti:2010:UpdateDocumentSet", _cert, uri, ct);

                return ProcessUpdateDocumentSetResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private Result<DocumentRepository_RetrieveDocumentSetResponse> ProcessRetrieveDocumentSetResponse(
            SoapRequestResult result)
        {
            return ProcessSoapResponse<RetrieveDocumentSetResponseType, DocumentRepository_RetrieveDocumentSetResponse>(
                result,
                body => new DocumentRepository_RetrieveDocumentSetResponse(body));
        }

        private Result<DocumentRepository_ProvideAndRegisterDocumentSetbResponse> ProcessProvideAndRegisterResponse(
            SoapRequestResult result)
        {
            return ProcessSoapResponse<CezihECDSa.Wsdl.PrijavaZarazne.RegistryResponseType, DocumentRepository_ProvideAndRegisterDocumentSetbResponse>(
                result,
                body => new DocumentRepository_ProvideAndRegisterDocumentSetbResponse(body));
        }

        private Result<DocumentRegistry_UpdateDocumentSetResponse> ProcessUpdateDocumentSetResponse(
            SoapRequestResult result)
        {
            return ProcessSoapResponse<Wsdl.PrijavaZarazneUpdate.RegistryResponseType,
                DocumentRegistry_UpdateDocumentSetResponse>(
                result,
                body => new DocumentRegistry_UpdateDocumentSetResponse(body));
        }

        private static Result<TResponse> ProcessSoapResponse<TBody, TResponse>(SoapRequestResult result,
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

        private async Task<SoapRequestResult> SendRequestAsync(string xmlString, string soapAction,
            X509Certificate2 cert, Uri uri, CancellationToken ct)
        {
            var request = CreateSoapRequest(xmlString, soapAction, cert, uri);
            using (var client = CreateHttpClient(cert))
            {
                return await SendAsyncInternal(request, client, ct);
            }
        }

        private SoapRequestResult SendRequest(string xmlString, string soapAction,
            X509Certificate2 cert, Uri uri)
        {
            var request = CreateSoapRequest(xmlString, soapAction, cert, uri);
            using (var client = CreateHttpClient(cert))
            {
                return SendSyncInternal(request, client);
            }
        }

        private static HttpRequestMessage CreateSoapRequest(string xmlString, string soapAction, X509Certificate2 cert,
            Uri uri)
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

        private HttpClient CreateHttpClient(X509Certificate2 cert)
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
                Timeout = _options.Timeout.GetValueOrDefault()
            };

            return client;
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