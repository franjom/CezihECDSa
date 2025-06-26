using CezihECDSa.Soap;
using CezihECDSa.Wsdl.OsigInfo;
using ECDSa.Helper;
using ECDSa.Helper.Soap._1_1;
using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.OsigInfo
{
    public interface IOsigInfoClient
    {
        Result<chosenDoctorResponseChosenDoctorOutput> chosenDoctor(string oibOsobe);

        Task<Result<chosenDoctorResponseChosenDoctorOutput>> chosenDoctorAsync(string oibOsobe,
            CancellationToken ct = default);

        Result<infoGlavarinaResponseGlavarina[]> infoGlavarina(string mboDoktor, DateTime datum);

        Task<Result<infoGlavarinaResponseGlavarina[]>> infoGlavarinaAsync(string mboDoktor, DateTime datum,
            CancellationToken ct = default);

        Result<orthopedicAidCheckResponseOrthopedicAidCheckOutput> orthopedicAidCheck(string mbOsiguraneOsobe,
            string sifraPomagala);

        Task<Result<orthopedicAidCheckResponseOrthopedicAidCheckOutput>> orthopedicAidCheckAsync(
            string mbOsiguraneOsobe, string sifraPomagala, CancellationToken ct = default);

        Result<osigInfoForBISResponseOsigInfoForBISOutput[]> osigInfoForBIS(
            osigInfoForBISBrojOsiguraneOsobe brojOsiguraneOsobe);

        Result<osigInfoForBISResponseOsigInfoForBISOutput[]> osigInfoForBIS(string mbOsiguraneOsobe);

        Result<osigInfoForBISResponseOsigInfoForBISOutput[]> osigInfoForBIS(
            osigInfoForBISOpceInformacijeOPacijentu opceInformacijeOPacijentu);

        Task<Result<osigInfoForBISResponseOsigInfoForBISOutput[]>> osigInfoForBISAsync(
            osigInfoForBISBrojOsiguraneOsobe brojOsiguraneOsobe, CancellationToken ct = default);

        Task<Result<osigInfoForBISResponseOsigInfoForBISOutput[]>> osigInfoForBISAsync(string mbOsiguraneOsobe,
            CancellationToken ct = default);

        Task<Result<osigInfoForBISResponseOsigInfoForBISOutput[]>> osigInfoForBISAsync(
            osigInfoForBISOpceInformacijeOPacijentu opceInformacijeOPacijentu, CancellationToken ct = default);

        Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]> osigInfoForDoctor(
            osigInfoForDoctorBrojOsiguraneOsobe brojOsiguraneOsobe);

        Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]> osigInfoForDoctor(string mbOsiguraneOsobe);

        Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]> osigInfoForDoctor(
            osigInfoForDoctorOpceInformacijeOPacijentu opceInformacijeOPacijentu);

        Task<Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]>> osigInfoForDoctorAsync(
            osigInfoForDoctorBrojOsiguraneOsobe brojOsiguraneOsobe, CancellationToken ct = default);

        Task<Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]>> osigInfoForDoctorAsync(
            string mbOsiguraneOsobe, CancellationToken ct = default);

        Task<Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]>> osigInfoForDoctorAsync(
            osigInfoForDoctorOpceInformacijeOPacijentu opceInformacijeOPacijentu, CancellationToken ct = default);

        Result<osigInfoForPharmacyResponseOsigInfoForPharmacyOutput> osigInfoForPharmacy(
            osigInfoForPharmacyBrojOsiguraneOsobe brojOsiguraneOsobe);

        Result<osigInfoForPharmacyResponseOsigInfoForPharmacyOutput> osigInfoForPharmacy(string mbOsiguraneOsobe);

        Task<Result<osigInfoForPharmacyResponseOsigInfoForPharmacyOutput>> osigInfoForPharmacyAsync(
            osigInfoForPharmacyBrojOsiguraneOsobe brojOsiguraneOsobe, CancellationToken ct = default);

        Task<Result<osigInfoForPharmacyResponseOsigInfoForPharmacyOutput>> osigInfoForPharmacyAsync(
            string mbOsiguraneOsobe, CancellationToken ct = default);

        Result<osigInfoForSKZZResponseOsigInfoForSKZZOutput> osigInfoForSKZZ(
            osigInfoForSKZZBrojOsiguraneOsobe brojOsiguraneOsobe);

        Result<osigInfoForSKZZResponseOsigInfoForSKZZOutput> osigInfoForSKZZ(string mbOsiguraneOsobe);

        Task<Result<osigInfoForSKZZResponseOsigInfoForSKZZOutput>> osigInfoForSKZZAsync(
            osigInfoForSKZZBrojOsiguraneOsobe brojOsiguraneOsobe, CancellationToken ct = default);

        Task<Result<osigInfoForSKZZResponseOsigInfoForSKZZOutput>> osigInfoForSKZZAsync(string mbOsiguraneOsobe,
            CancellationToken ct = default);
    }

    public sealed class OsigInfoClient : IOsigInfoClient
    {
        private readonly OsigInfoOptions _options;
        private readonly X509Certificate2 _cert;

        public OsigInfoClient(OsigInfoOptions options, X509Certificate2 cert)
        {
            _options = options;
            _cert = cert;
        }

        public Result<chosenDoctorResponseChosenDoctorOutput> chosenDoctor(string oibOsobe)
        {
            return ChosenDoctor(new ChosenDoctorRequest(oibOsobe));
        }

        public Task<Result<chosenDoctorResponseChosenDoctorOutput>> chosenDoctorAsync(string oibOsobe,
            CancellationToken ct = default)
        {
            return ChosenDoctorAsync(new ChosenDoctorRequest(oibOsobe), ct);
        }

        public Result<infoGlavarinaResponseGlavarina[]> infoGlavarina(string mboDoktor, DateTime datum)
        {
            return InfoGlavarina(new InfoGlavarinaCheckRequest(mboDoktor, datum));
        }

        public Task<Result<infoGlavarinaResponseGlavarina[]>> infoGlavarinaAsync(string mboDoktor, DateTime datum,
            CancellationToken ct = default)
        {
            return InfoGlavarinaAsync(new InfoGlavarinaCheckRequest(mboDoktor, datum), ct);
        }

        public Result<orthopedicAidCheckResponseOrthopedicAidCheckOutput> orthopedicAidCheck(string mbOsiguraneOsobe,
            string sifraPomagala)
        {
            return OrtpoedicAidCheck(new OrtopedicAidCheckRequest(mbOsiguraneOsobe, sifraPomagala));
        }

        public Task<Result<orthopedicAidCheckResponseOrthopedicAidCheckOutput>> orthopedicAidCheckAsync(
            string mbOsiguraneOsobe, string sifraPomagala, CancellationToken ct = default)
        {
            return OrtpoedicAidCheckAsync(new OrtopedicAidCheckRequest(mbOsiguraneOsobe, sifraPomagala), ct);
        }

        public Result<osigInfoForBISResponseOsigInfoForBISOutput[]> osigInfoForBIS(
            osigInfoForBISBrojOsiguraneOsobe brojOsiguraneOsobe)
        {
            return OsigInfoForBIS(new OsigInfoForBisRequest(brojOsiguraneOsobe));
        }

        public Task<Result<osigInfoForBISResponseOsigInfoForBISOutput[]>> osigInfoForBISAsync(
            osigInfoForBISBrojOsiguraneOsobe brojOsiguraneOsobe, CancellationToken ct = default)
        {
            return OsigInfoForBISAsync(new OsigInfoForBisRequest(brojOsiguraneOsobe), ct);
        }

        public Task<Result<osigInfoForBISResponseOsigInfoForBISOutput[]>> osigInfoForBISAsync(string mbOsiguraneOsobe,
            CancellationToken ct = default)
        {
            return OsigInfoForBISAsync(new OsigInfoForBisRequest(mbOsiguraneOsobe), ct);
        }

        public Result<osigInfoForBISResponseOsigInfoForBISOutput[]> osigInfoForBIS(string mbOsiguraneOsobe)
        {
            return OsigInfoForBIS(new OsigInfoForBisRequest(mbOsiguraneOsobe));
        }

        public Result<osigInfoForBISResponseOsigInfoForBISOutput[]> osigInfoForBIS(
            osigInfoForBISOpceInformacijeOPacijentu opceInformacijeOPacijentu)
        {
            return OsigInfoForBIS(new OsigInfoForBisRequest(opceInformacijeOPacijentu));
        }

        public Task<Result<osigInfoForBISResponseOsigInfoForBISOutput[]>> osigInfoForBISAsync(
            osigInfoForBISOpceInformacijeOPacijentu opceInformacijeOPacijentu, CancellationToken ct = default)
        {
            return OsigInfoForBISAsync(new OsigInfoForBisRequest(opceInformacijeOPacijentu), ct);
        }

        public Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]> osigInfoForDoctor(
            osigInfoForDoctorBrojOsiguraneOsobe brojOsiguraneOsobe)
        {
            return OsigInfoForDoctor(new OsigInfoForDoctorRequest(brojOsiguraneOsobe));
        }

        public Task<Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]>> osigInfoForDoctorAsync(
            osigInfoForDoctorBrojOsiguraneOsobe brojOsiguraneOsobe, CancellationToken ct = default)
        {
            return OsigInfoForDoctorAsync(new OsigInfoForDoctorRequest(brojOsiguraneOsobe), ct);
        }

        public Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]> osigInfoForDoctor(string mbOsiguraneOsobe)
        {
            return OsigInfoForDoctor(new OsigInfoForDoctorRequest(mbOsiguraneOsobe));
        }

        public Task<Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]>> osigInfoForDoctorAsync(
            string mbOsiguraneOsobe, CancellationToken ct = default)
        {
            return OsigInfoForDoctorAsync(new OsigInfoForDoctorRequest(mbOsiguraneOsobe), ct);
        }

        public Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]> osigInfoForDoctor(
            osigInfoForDoctorOpceInformacijeOPacijentu opceInformacijeOPacijentu)
        {
            return OsigInfoForDoctor(new OsigInfoForDoctorRequest(opceInformacijeOPacijentu));
        }

        public Task<Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]>> osigInfoForDoctorAsync(
            osigInfoForDoctorOpceInformacijeOPacijentu opceInformacijeOPacijentu, CancellationToken ct = default)
        {
            return OsigInfoForDoctorAsync(new OsigInfoForDoctorRequest(opceInformacijeOPacijentu), ct);
        }

        public Result<osigInfoForPharmacyResponseOsigInfoForPharmacyOutput> osigInfoForPharmacy(
            osigInfoForPharmacyBrojOsiguraneOsobe brojOsiguraneOsobe)
        {
            return OsigInfoForPharmacy(new OsigInfoForPharmacyRequest(brojOsiguraneOsobe));
        }

        public Task<Result<osigInfoForPharmacyResponseOsigInfoForPharmacyOutput>> osigInfoForPharmacyAsync(
            osigInfoForPharmacyBrojOsiguraneOsobe brojOsiguraneOsobe, CancellationToken ct = default)
        {
            return OsigInfoForPharmacyAsync(new OsigInfoForPharmacyRequest(brojOsiguraneOsobe), ct);
        }

        public Result<osigInfoForPharmacyResponseOsigInfoForPharmacyOutput> osigInfoForPharmacy(string mbOsiguraneOsobe)
        {
            return OsigInfoForPharmacy(new OsigInfoForPharmacyRequest(mbOsiguraneOsobe));
        }

        public Task<Result<osigInfoForPharmacyResponseOsigInfoForPharmacyOutput>> osigInfoForPharmacyAsync(
            string mbOsiguraneOsobe, CancellationToken ct = default)
        {
            return OsigInfoForPharmacyAsync(new OsigInfoForPharmacyRequest(mbOsiguraneOsobe), ct);
        }

        public Result<osigInfoForSKZZResponseOsigInfoForSKZZOutput> osigInfoForSKZZ(
            osigInfoForSKZZBrojOsiguraneOsobe brojOsiguraneOsobe)
        {
            return OsigInfoForSkzz(new OsigInfoForSKZZRequest(brojOsiguraneOsobe));
        }

        public Task<Result<osigInfoForSKZZResponseOsigInfoForSKZZOutput>> osigInfoForSKZZAsync(
            osigInfoForSKZZBrojOsiguraneOsobe brojOsiguraneOsobe, CancellationToken ct = default)
        {
            return OsigInfoForSkzzAsync(new OsigInfoForSKZZRequest(brojOsiguraneOsobe), ct);
        }

        public Result<osigInfoForSKZZResponseOsigInfoForSKZZOutput> osigInfoForSKZZ(string mbOsiguraneOsobe)
        {
            return OsigInfoForSkzz(new OsigInfoForSKZZRequest(mbOsiguraneOsobe));
        }


        public Task<Result<osigInfoForSKZZResponseOsigInfoForSKZZOutput>> osigInfoForSKZZAsync(string mbOsiguraneOsobe,
            CancellationToken ct = default)
        {
            return OsigInfoForSkzzAsync(new OsigInfoForSKZZRequest(mbOsiguraneOsobe), ct);
        }

        #region PrivateMethods

        private Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]> OsigInfoForDoctor(
            OsigInfoForDoctorRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(xml, "osigInfoForDoctor", _cert, uri);

                return ProcessOsigInfoForDoctorResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private async Task<Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]>> OsigInfoForDoctorAsync(
            OsigInfoForDoctorRequest request, CancellationToken ct)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(xml, "osigInfoForDoctor", _cert, uri, ct);

                return ProcessOsigInfoForDoctorResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private Result<osigInfoForPharmacyResponseOsigInfoForPharmacyOutput> OsigInfoForPharmacy(
            OsigInfoForPharmacyRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(xml, "osigInfoForPharmacy", _cert, uri);

                return ProcessOsigInfoForPharmacyResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private async Task<Result<osigInfoForPharmacyResponseOsigInfoForPharmacyOutput>> OsigInfoForPharmacyAsync(
            OsigInfoForPharmacyRequest request, CancellationToken ct)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(xml, "osigInfoForPharmacy", _cert, uri, ct);

                return ProcessOsigInfoForPharmacyResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private Result<osigInfoForSKZZResponseOsigInfoForSKZZOutput> OsigInfoForSkzz(OsigInfoForSKZZRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(xml, "osigInfoForSKZZ", _cert, uri);

                return ProcessOsigInfoForSKZZResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private async Task<Result<osigInfoForSKZZResponseOsigInfoForSKZZOutput>> OsigInfoForSkzzAsync(
            OsigInfoForSKZZRequest request, CancellationToken ct)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(xml, "osigInfoForSKZZ", _cert, uri, ct);

                return ProcessOsigInfoForSKZZResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private Result<osigInfoForBISResponseOsigInfoForBISOutput[]> OsigInfoForBIS(OsigInfoForBisRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(xml, "osigInfoForBIS", _cert, uri);

                return ProcessOsigInfoForBisResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private async Task<Result<osigInfoForBISResponseOsigInfoForBISOutput[]>> OsigInfoForBISAsync(
            OsigInfoForBisRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(xml, "osigInfoForBIS", _cert, uri, ct);

                return ProcessOsigInfoForBisResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private Result<infoGlavarinaResponseGlavarina[]> InfoGlavarina(InfoGlavarinaCheckRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(xml, "infoGlavarina", _cert, uri);

                return ProcessInfoGlavarinaResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private async Task<Result<infoGlavarinaResponseGlavarina[]>> InfoGlavarinaAsync(
            InfoGlavarinaCheckRequest request, CancellationToken ct)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(xml, "infoGlavarina", _cert, uri, ct);

                return ProcessInfoGlavarinaResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private Result<chosenDoctorResponseChosenDoctorOutput> ChosenDoctor(ChosenDoctorRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(xml, "chosenDoctor", _cert, uri);

                return ProcessChosenDoctorResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private async Task<Result<chosenDoctorResponseChosenDoctorOutput>> ChosenDoctorAsync(
            ChosenDoctorRequest request, CancellationToken ct)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(xml, "chosenDoctor", _cert, uri, ct);

                return ProcessChosenDoctorResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private Result<orthopedicAidCheckResponseOrthopedicAidCheckOutput> OrtpoedicAidCheck(
            OrtopedicAidCheckRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(xml, "orthopedicAidCheck", _cert, uri);

                return ProcessOrtopedicAidResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private async Task<Result<orthopedicAidCheckResponseOrthopedicAidCheckOutput>> OrtpoedicAidCheckAsync(
            OrtopedicAidCheckRequest request, CancellationToken ct)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(xml, "orthopedicAidCheck", _cert, uri, ct);

                return ProcessOrtopedicAidResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        #endregion


        private static Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]> ProcessOsigInfoForDoctorResponse(
            SoapRequestResult result)
        {
            return ProcessSoapResponse<OsigInfoForDoctorResponse, osigInfoForDoctorResponseOsigInfoForDoctorOutput[]>(
                result,
                body => body.Output);
        }

        private static Result<osigInfoForBISResponseOsigInfoForBISOutput[]> ProcessOsigInfoForBisResponse(
            SoapRequestResult result)
        {
            return ProcessSoapResponse<OsigInfoForBisResponse, osigInfoForBISResponseOsigInfoForBISOutput[]>(
                result,
                body => body.Output);
        }

        private static Result<osigInfoForSKZZResponseOsigInfoForSKZZOutput> ProcessOsigInfoForSKZZResponse(
            SoapRequestResult result)
        {
            return ProcessSoapResponse<OsigInfoForSKZZResponse, osigInfoForSKZZResponseOsigInfoForSKZZOutput>(
                result,
                body => body.Output);
        }

        private static Result<osigInfoForPharmacyResponseOsigInfoForPharmacyOutput> ProcessOsigInfoForPharmacyResponse(
            SoapRequestResult result)
        {
            return ProcessSoapResponse<OsigInfoForPharmacyResponse,
                osigInfoForPharmacyResponseOsigInfoForPharmacyOutput>(
                result,
                body => body.Output);
        }

        private static Result<infoGlavarinaResponseGlavarina[]> ProcessInfoGlavarinaResponse(SoapRequestResult result)
        {
            return ProcessSoapResponse<InfoGlavarinaCheckResponse,
                infoGlavarinaResponseGlavarina[]>(
                result,
                body => body.Output);
        }

        private static Result<chosenDoctorResponseChosenDoctorOutput> ProcessChosenDoctorResponse(
            SoapRequestResult result)
        {
            return ProcessSoapResponse<ChosenDoctorResponse,
                chosenDoctorResponseChosenDoctorOutput>(
                result,
                body => body.Output);
        }

        private static Result<orthopedicAidCheckResponseOrthopedicAidCheckOutput> ProcessOrtopedicAidResponse(
            SoapRequestResult result)
        {
            return ProcessSoapResponse<OrtopedicAidCheckResponse,
                orthopedicAidCheckResponseOrthopedicAidCheckOutput>(
                result,
                body => body.Output);
        }

        private XmlSerializerNamespaces Namespaces
        {
            get
            {
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add("", "http://www.hzzo-net.hr/");

                return namespaces;
            }
        }

        private SoapRequestResult SendRequest(string xmlString, string soapAction,
            X509Certificate2 cert, Uri uri)
        {
            var request = CreateSoapRequest(xmlString, soapAction, uri);
            using (var client = CreateHttpClient(cert))
            {
                return SendSyncInternal(request, client);
            }
        }

        private async Task<SoapRequestResult> SendRequestAsync(string xmlString, string soapAction,
            X509Certificate2 cert, Uri uri, CancellationToken ct)
        {
            var request = CreateSoapRequest(xmlString, soapAction, uri);
            using (var client = CreateHttpClient(cert))
            {
                return await SendAsyncInternal(request, client, ct);
            }
        }

        private static Result<TResponse> ProcessSoapResponse<TBody, TResponse>(SoapRequestResult result,
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

        private static HttpRequestMessage CreateSoapRequest(string xmlString, string soapAction, Uri uri)
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