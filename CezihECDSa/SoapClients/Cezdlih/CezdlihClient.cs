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

        Result<SlanjeNarudzbenicaResponse> SlanjeNarudzbenica(SlanjeNarudzbenicaRequest request);

        Task<Result<SlanjeNarudzbenicaResponse>> SlanjeNarudzbenicaAsync(SlanjeNarudzbenicaRequest request,
            CancellationToken ct = default);

        Result<PreuzimanjeOtpremniceResponse> PreuzimanjeOtpremnice(PreuzimanjeOtpremniceRequest request);

        Task<Result<PreuzimanjeOtpremniceResponse>> PreuzimanjeOtpremniceAsync(PreuzimanjeOtpremniceRequest request,
            CancellationToken ct = default);

        Result<SlanjePrimkeResponse> SlanjePrimke(SlanjePrimkeRequest request);

        Task<Result<SlanjePrimkeResponse>> SlanjePrimkeAsync(SlanjePrimkeRequest request,
            CancellationToken ct = default);

        Result<ObavijestOPovratuOtpisuCjepivaResponse> ObavijestOPovratuOtpisuCjepiva(ObavijestOPovratuOtpisuCjepivaRequest request);

        Task<Result<ObavijestOPovratuOtpisuCjepivaResponse>> ObavijestOPovratuOtpisuCjepivaAsync(ObavijestOPovratuOtpisuCjepivaRequest request,
            CancellationToken ct = default);

        Result<SlanjeOtpremniceResponse> SlanjeOtpremnice(SlanjeOtpremniceRequest request);

        Task<Result<SlanjeOtpremniceResponse>> SlanjeOtpremniceAsync(SlanjeOtpremniceRequest request,
            CancellationToken ct = default);

        Result<ObavijestONedolazakNaCijepljenjeResponse> ObavijestONedolazakNaCijepljenje(ObavijestONedolazakNaCijepljenjeRequest request);

        Task<Result<ObavijestONedolazakNaCijepljenjeResponse>> ObavijestONedolazakNaCijepljenjeAsync(ObavijestONedolazakNaCijepljenjeRequest request,
            CancellationToken ct = default);

        Result<ObavijestOCijepljenjeResponse> ObavijestOCijepljenje(ObavijestOCijepljenjeRequest request);

        Task<Result<ObavijestOCijepljenjeResponse>> ObavijestOCijepljenjeAsync(ObavijestOCijepljenjeRequest request,
            CancellationToken ct = default);

        Result<OtkazivanjeObavijestOCijepljenjeResponse> OtkazivanjeObavijestOCijepljenje(OtkazivanjeObavijestOCijepljenjeRequest request);

        Task<Result<OtkazivanjeObavijestOCijepljenjeResponse>> OtkazivanjeObavijestOCijepljenjeAsync(OtkazivanjeObavijestOCijepljenjeRequest request,
            CancellationToken ct = default);

        Result<PrijavaNuspojaveCijepljenjaResponse> PrijavaNuspojaveCijepljenja(PrijavaNuspojaveCijepljenjaRequest request);

        Task<Result<PrijavaNuspojaveCijepljenjaResponse>> PrijavaNuspojaveCijepljenjaAsync(PrijavaNuspojaveCijepljenjaRequest request,
            CancellationToken ct = default);

        Result<UpitOCijepnomKartonuOsobeResponse> UpitOCijepnomKartonuOsobe(UpitOCijepnomKartonuOsobeRequest request);

        Task<Result<UpitOCijepnomKartonuOsobeResponse>> UpitOCijepnomKartonuOsobeAsync(UpitOCijepnomKartonuOsobeRequest request,
            CancellationToken ct = default);

        Result<PreuzimanjeZipResponse> PreuzimanjeZip(PreuzimanjeZipRequest request);

        Task<Result<PreuzimanjeZipResponse>> PreuzimanjeZipAsync(PreuzimanjeZipRequest request,
            CancellationToken ct = default);

        Result<SlanjeZipResponse> SlanjeZip(SlanjeZipRequest request);

        Task<Result<SlanjeZipResponse>> SlanjeZipAsync(SlanjeZipRequest request,
            CancellationToken ct = default);

        Result<SlanjeLagerResponse> SlanjeLager(SlanjeLagerRequest request);

        Task<Result<SlanjeLagerResponse>> SlanjeLagerAsync(SlanjeLagerRequest request,
            CancellationToken ct = default);

        Result<StatusLijecenjaPacijentaResponseStatusLijecenjaPacijentaResult> StatusLijecenjaPacijenta(StatusLijecenjaPacijentaZahtjevZaStatusLijecenjaPacijenta request);

        Task<Result<StatusLijecenjaPacijentaResponseStatusLijecenjaPacijentaResult>> StatusLijecenjaPacijentaAsync(StatusLijecenjaPacijentaZahtjevZaStatusLijecenjaPacijenta request,
            CancellationToken ct = default);

        Result<PrijavaZainteresiranihResponse> PrijavaZainteresiranih(PrijavaZainteresiranihRequest request);

        Task<Result<PrijavaZainteresiranihResponse>> PrijavaZainteresiranihAsync(PrijavaZainteresiranihRequest request,
            CancellationToken ct = default);

        Result<OtkazivanjePrijavaZainteresiranihResponse> OtkazivanjePrijavaZainteresiranih(OtkazivanjePrijavaZainteresiranihRequest request);

        Task<Result<OtkazivanjePrijavaZainteresiranihResponse>> OtkazivanjePrijavaZainteresiranihAsync(OtkazivanjePrijavaZainteresiranihRequest request,
            CancellationToken ct = default);

        Result<PreuzimanjePrijavaZainteresiranihResponse> PreuzimanjePrijavaZainteresiranih(PreuzimanjePrijavaZainteresiranihRequest request);

        Task<Result<PreuzimanjePrijavaZainteresiranihResponse>> PreuzimanjePrijavaZainteresiranihAsync(PreuzimanjePrijavaZainteresiranihRequest request,
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

        public Result<SlanjeNarudzbenicaResponse> SlanjeNarudzbenica(SlanjeNarudzbenicaRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjeNarudzbenicaRequest(request.SlanjeNarudzbenicaRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeNarudzbenica",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessSlanjeNarudzbenicaResponse(result);

                if (!response.IsError
                    && response.Value.SlanjeNarudzbenicaResult?.ListaGresaka != null
                    && response.Value.SlanjeNarudzbenicaResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .SlanjeNarudzbenicaResult
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

        public async Task<Result<SlanjeNarudzbenicaResponse>> SlanjeNarudzbenicaAsync(SlanjeNarudzbenicaRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjeNarudzbenicaRequest(request.SlanjeNarudzbenicaRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeNarudzbenica",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessSlanjeNarudzbenicaResponse(result);

                if (!response.IsError
                    && response.Value.SlanjeNarudzbenicaResult?.ListaGresaka != null
                    && response.Value.SlanjeNarudzbenicaResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .SlanjeNarudzbenicaResult
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

        public Result<PreuzimanjeOtpremniceResponse> PreuzimanjeOtpremnice(PreuzimanjeOtpremniceRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPreuzimanjeOtpremniceRequest(request.PreuzimanjeOtpremniceRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjeOtpremnice",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessPreuzimanjeOtpremniceResponse(result);

                if (!response.IsError
                    && response.Value.PreuzimanjeOtpremniceResult?.ListaGresaka != null
                    && response.Value.PreuzimanjeOtpremniceResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .PreuzimanjeOtpremniceResult
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

        public async Task<Result<PreuzimanjeOtpremniceResponse>> PreuzimanjeOtpremniceAsync(PreuzimanjeOtpremniceRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPreuzimanjeOtpremniceRequest(request.PreuzimanjeOtpremniceRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjeOtpremnice",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessPreuzimanjeOtpremniceResponse(result);

                if (!response.IsError
                    && response.Value.PreuzimanjeOtpremniceResult?.ListaGresaka != null
                    && response.Value.PreuzimanjeOtpremniceResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .PreuzimanjeOtpremniceResult
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

        public Result<SlanjePrimkeResponse> SlanjePrimke(SlanjePrimkeRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjePrimkeRequest(request.SlanjePrimkeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjePrimke",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessSlanjePrimkeResponse(result);

                if (!response.IsError
                    && response.Value.SlanjePrimkeResult?.ListaGresaka != null
                    && response.Value.SlanjePrimkeResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .SlanjePrimkeResult
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

        public async Task<Result<SlanjePrimkeResponse>> SlanjePrimkeAsync(SlanjePrimkeRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjePrimkeRequest(request.SlanjePrimkeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjePrimke",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessSlanjePrimkeResponse(result);

                if (!response.IsError
                    && response.Value.SlanjePrimkeResult?.ListaGresaka != null
                    && response.Value.SlanjePrimkeResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .SlanjePrimkeResult
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

        public Result<ObavijestOPovratuOtpisuCjepivaResponse> ObavijestOPovratuOtpisuCjepiva(ObavijestOPovratuOtpisuCjepivaRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WObavijestOPovratuOtpisuCjepivaRequest(request.ObavijestOPovratuOtpisuCjepivaRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/ObavijestOPovratuOtpisuCjepiva",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessObavijestOPovratuOtpisuCjepivaResponse(result);

                if (!response.IsError
                    && response.Value.ObavijestOPovratuOtpisuCjepivaResult?.ListaGresaka != null
                    && response.Value.ObavijestOPovratuOtpisuCjepivaResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .ObavijestOPovratuOtpisuCjepivaResult
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

        public async Task<Result<ObavijestOPovratuOtpisuCjepivaResponse>> ObavijestOPovratuOtpisuCjepivaAsync(ObavijestOPovratuOtpisuCjepivaRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WObavijestOPovratuOtpisuCjepivaRequest(request.ObavijestOPovratuOtpisuCjepivaRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/ObavijestOPovratuOtpisuCjepiva",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessObavijestOPovratuOtpisuCjepivaResponse(result);

                if (!response.IsError
                    && response.Value.ObavijestOPovratuOtpisuCjepivaResult?.ListaGresaka != null
                    && response.Value.ObavijestOPovratuOtpisuCjepivaResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .ObavijestOPovratuOtpisuCjepivaResult
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

        public Result<SlanjeOtpremniceResponse> SlanjeOtpremnice(SlanjeOtpremniceRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjeOtpremniceRequest(request.SlanjeOtpremniceRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeOtpremnice",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessSlanjeOtpremniceResponse(result);

                if (!response.IsError
                    && response.Value.SlanjeOtpremniceResult?.ListaGresaka != null
                    && response.Value.SlanjeOtpremniceResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .SlanjeOtpremniceResult
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

        public async Task<Result<SlanjeOtpremniceResponse>> SlanjeOtpremniceAsync(SlanjeOtpremniceRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjeOtpremniceRequest(request.SlanjeOtpremniceRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeOtpremnice",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessSlanjeOtpremniceResponse(result);

                if (!response.IsError
                    && response.Value.SlanjeOtpremniceResult?.ListaGresaka != null
                    && response.Value.SlanjeOtpremniceResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .SlanjeOtpremniceResult
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

        public Result<ObavijestONedolazakNaCijepljenjeResponse> ObavijestONedolazakNaCijepljenje(ObavijestONedolazakNaCijepljenjeRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WObavijestONedolazakNaCijepljenjeRequest(request.ObavijestONedolazakNaCijepljenjeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/ObavijestONedolazakNaCijepljenje",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessObavijestONedolazakNaCijepljenjeResponse(result);

                if (!response.IsError
                    && response.Value.ObavijestONedolazakNaCijepljenjeResult?.ListaGresaka != null
                    && response.Value.ObavijestONedolazakNaCijepljenjeResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .ObavijestONedolazakNaCijepljenjeResult
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

        public async Task<Result<ObavijestONedolazakNaCijepljenjeResponse>> ObavijestONedolazakNaCijepljenjeAsync(ObavijestONedolazakNaCijepljenjeRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WObavijestONedolazakNaCijepljenjeRequest(request.ObavijestONedolazakNaCijepljenjeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/ObavijestONedolazakNaCijepljenje",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessObavijestONedolazakNaCijepljenjeResponse(result);

                if (!response.IsError
                    && response.Value.ObavijestONedolazakNaCijepljenjeResult?.ListaGresaka != null
                    && response.Value.ObavijestONedolazakNaCijepljenjeResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .ObavijestONedolazakNaCijepljenjeResult
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

        public Result<ObavijestOCijepljenjeResponse> ObavijestOCijepljenje(ObavijestOCijepljenjeRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WObavijestOCijepljenjeRequest(request.ObavijestOCijepljenjeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/ObavijestOCijepljenje",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessObavijestOCijepljenjeResponse(result);

                if (!response.IsError
                    && response.Value.ObavijestOCijepljenjeResult?.ListaGresaka != null
                    && response.Value.ObavijestOCijepljenjeResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .ObavijestOCijepljenjeResult
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

        public async Task<Result<ObavijestOCijepljenjeResponse>> ObavijestOCijepljenjeAsync(ObavijestOCijepljenjeRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WObavijestOCijepljenjeRequest(request.ObavijestOCijepljenjeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/ObavijestOCijepljenje",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessObavijestOCijepljenjeResponse(result);

                if (!response.IsError
                    && response.Value.ObavijestOCijepljenjeResult?.ListaGresaka != null
                    && response.Value.ObavijestOCijepljenjeResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .ObavijestOCijepljenjeResult
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

        public Result<OtkazivanjeObavijestOCijepljenjeResponse> OtkazivanjeObavijestOCijepljenje(OtkazivanjeObavijestOCijepljenjeRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WOtkazivanjeObavijestOCijepljenjeRequest(request.OtkazivanjeObavijestOCijepljenjeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/OtkazivanjeObavijestOCijepljenje",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessOtkazivanjeObavijestOCijepljenjeResponse(result);

                if (!response.IsError
                    && response.Value.OtkazivanjeObavijestOCijepljenjeResult?.ListaGresaka != null
                    && response.Value.OtkazivanjeObavijestOCijepljenjeResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .OtkazivanjeObavijestOCijepljenjeResult
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

        public async Task<Result<OtkazivanjeObavijestOCijepljenjeResponse>> OtkazivanjeObavijestOCijepljenjeAsync(OtkazivanjeObavijestOCijepljenjeRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WOtkazivanjeObavijestOCijepljenjeRequest(request.OtkazivanjeObavijestOCijepljenjeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/OtkazivanjeObavijestOCijepljenje",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessOtkazivanjeObavijestOCijepljenjeResponse(result);

                if (!response.IsError
                    && response.Value.OtkazivanjeObavijestOCijepljenjeResult?.ListaGresaka != null
                    && response.Value.OtkazivanjeObavijestOCijepljenjeResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .OtkazivanjeObavijestOCijepljenjeResult
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

        public Result<PrijavaNuspojaveCijepljenjaResponse> PrijavaNuspojaveCijepljenja(PrijavaNuspojaveCijepljenjaRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPrijavaNuspojaveCijepljenjaRequest(request.PrijavaNuspojaveCijepljenjaRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PrijavaNuspojaveCijepljenja",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessPrijavaNuspojaveCijepljenjaResponse(result);

                if (!response.IsError
                    && response.Value.PrijavaNuspojaveCijepljenjaResult?.ListaGresaka != null
                    && response.Value.PrijavaNuspojaveCijepljenjaResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .PrijavaNuspojaveCijepljenjaResult
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

        public async Task<Result<PrijavaNuspojaveCijepljenjaResponse>> PrijavaNuspojaveCijepljenjaAsync(PrijavaNuspojaveCijepljenjaRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPrijavaNuspojaveCijepljenjaRequest(request.PrijavaNuspojaveCijepljenjaRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PrijavaNuspojaveCijepljenja",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessPrijavaNuspojaveCijepljenjaResponse(result);

                if (!response.IsError
                    && response.Value.PrijavaNuspojaveCijepljenjaResult?.ListaGresaka != null
                    && response.Value.PrijavaNuspojaveCijepljenjaResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .PrijavaNuspojaveCijepljenjaResult
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

        public Result<UpitOCijepnomKartonuOsobeResponse> UpitOCijepnomKartonuOsobe(UpitOCijepnomKartonuOsobeRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WUpitOCijepnomKartonuOsobeRequest(request.UpitOCijepnomKartonuOsobeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/UpitOCijepnomKartonuOsobe",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessUpitOCijepnomKartonuOsobeResponse(result);

                if (!response.IsError
                    && response.Value.UpitOCijepnomKartonuOsobeResult?.ListaGresaka != null
                    && response.Value.UpitOCijepnomKartonuOsobeResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .UpitOCijepnomKartonuOsobeResult
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

        public async Task<Result<UpitOCijepnomKartonuOsobeResponse>> UpitOCijepnomKartonuOsobeAsync(UpitOCijepnomKartonuOsobeRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WUpitOCijepnomKartonuOsobeRequest(request.UpitOCijepnomKartonuOsobeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/UpitOCijepnomKartonuOsobe",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessUpitOCijepnomKartonuOsobeResponse(result);

                if (!response.IsError
                    && response.Value.UpitOCijepnomKartonuOsobeResult?.ListaGresaka != null
                    && response.Value.UpitOCijepnomKartonuOsobeResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .UpitOCijepnomKartonuOsobeResult
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

        public Result<PreuzimanjeZipResponse> PreuzimanjeZip(PreuzimanjeZipRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPreuzimanjeZipRequest(request.PreuzimanjeZipRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjeZip",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessPreuzimanjeZipResponse(result);

                return response;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<PreuzimanjeZipResponse>> PreuzimanjeZipAsync(PreuzimanjeZipRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPreuzimanjeZipRequest(request.PreuzimanjeZipRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjeZip",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessPreuzimanjeZipResponse(result);

                return response;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<SlanjeZipResponse> SlanjeZip(SlanjeZipRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjeZipRequest(request.SlanjeZipRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeZip",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessSlanjeZipResponse(result);

                if (!response.IsError
                    && response.Value.SlanjeZipResult?.ListaGresaka != null
                    && response.Value.SlanjeZipResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .SlanjeZipResult
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

        public async Task<Result<SlanjeZipResponse>> SlanjeZipAsync(SlanjeZipRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjeZipRequest(request.SlanjeZipRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeZip",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessSlanjeZipResponse(result);

                if (!response.IsError
                    && response.Value.SlanjeZipResult?.ListaGresaka != null
                    && response.Value.SlanjeZipResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .SlanjeZipResult
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

        public Result<SlanjeLagerResponse> SlanjeLager(SlanjeLagerRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjeLagerRequest(request.SlanjeLagerRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeLager",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessSlanjeLagerResponse(result);

                if (!response.IsError
                    && response.Value.SlanjeLagerResult?.ListaGresaka != null
                    && response.Value.SlanjeLagerResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .SlanjeLagerResult
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

        public async Task<Result<SlanjeLagerResponse>> SlanjeLagerAsync(SlanjeLagerRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjeLagerRequest(request.SlanjeLagerRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeLager",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessSlanjeLagerResponse(result);

                if (!response.IsError
                    && response.Value.SlanjeLagerResult?.ListaGresaka != null
                    && response.Value.SlanjeLagerResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .SlanjeLagerResult
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

        public Result<StatusLijecenjaPacijentaResponseStatusLijecenjaPacijentaResult> StatusLijecenjaPacijenta(StatusLijecenjaPacijentaZahtjevZaStatusLijecenjaPacijenta request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WStatusLijecenjaPacijentaRequest(request), Namespaces);

                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/StatusLijecenjaPacijenta",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessStatusLijecenjaPacijentaResponse(result);

                if (!response.IsError
                    && response.Value?.ListaGresaka?.Any() == true)
                {
                    return response.Value
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

        public async Task<Result<StatusLijecenjaPacijentaResponseStatusLijecenjaPacijentaResult>> StatusLijecenjaPacijentaAsync(StatusLijecenjaPacijentaZahtjevZaStatusLijecenjaPacijenta request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WStatusLijecenjaPacijentaRequest(request), Namespaces);

                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/StatusLijecenjaPacijenta",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessStatusLijecenjaPacijentaResponse(result);

                if (!response.IsError
                    && response.Value?.ListaGresaka?.Any() == true)
                {
                    return response.Value
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

        public Result<PrijavaZainteresiranihResponse> PrijavaZainteresiranih(PrijavaZainteresiranihRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPrijavaZainteresiranihRequest(request.PrijavaZainteresiranihRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PrijavaZainteresiranih",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessPrijavaZainteresiranihResponse(result);

                if (!response.IsError
                    && response.Value.PrijavaZainteresiranihResult?.ListaGresaka != null
                    && response.Value.PrijavaZainteresiranihResult.ListaGresaka.Any())
                {
                    return response.Value.PrijavaZainteresiranihResult.ListaGresaka.Select(o => new ErrorMessage(o.NazivGreske)).ToList();
                }

                return response;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<PrijavaZainteresiranihResponse>> PrijavaZainteresiranihAsync(PrijavaZainteresiranihRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPrijavaZainteresiranihRequest(request.PrijavaZainteresiranihRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PrijavaZainteresiranih",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessPrijavaZainteresiranihResponse(result);

                if (!response.IsError
                    && response.Value.PrijavaZainteresiranihResult?.ListaGresaka != null
                    && response.Value.PrijavaZainteresiranihResult.ListaGresaka.Any())
                {
                    return response.Value.PrijavaZainteresiranihResult.ListaGresaka.Select(o => new ErrorMessage(o.NazivGreske)).ToList();
                }

                return response;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<OtkazivanjePrijavaZainteresiranihResponse> OtkazivanjePrijavaZainteresiranih(OtkazivanjePrijavaZainteresiranihRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WOtkazivanjePrijavaZainteresiranihRequest(request.OtkazivanjePrijavaZainteresiranihRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/OtkazivanjePrijavaZainteresiranih",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessOtkazivanjePrijavaZainteresiranihResponse(result);

                if (!response.IsError
                    && response.Value.OtkazivanjePrijavaZainteresiranihResult?.ListaGresaka != null
                    && response.Value.OtkazivanjePrijavaZainteresiranihResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .OtkazivanjePrijavaZainteresiranihResult
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

        public async Task<Result<OtkazivanjePrijavaZainteresiranihResponse>> OtkazivanjePrijavaZainteresiranihAsync(OtkazivanjePrijavaZainteresiranihRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WOtkazivanjePrijavaZainteresiranihRequest(request.OtkazivanjePrijavaZainteresiranihRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/OtkazivanjePrijavaZainteresiranih",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessOtkazivanjePrijavaZainteresiranihResponse(result);

                if (!response.IsError
                    && response.Value.OtkazivanjePrijavaZainteresiranihResult?.ListaGresaka != null
                    && response.Value.OtkazivanjePrijavaZainteresiranihResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .OtkazivanjePrijavaZainteresiranihResult
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

        public Result<PreuzimanjePrijavaZainteresiranihResponse> PreuzimanjePrijavaZainteresiranih(PreuzimanjePrijavaZainteresiranihRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPreuzimanjePrijavaZainteresiranihRequest(request.PreuzimanjePrijavaZainteresiranihRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjePrijavaZainteresiranih",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                var response = ProcessPreuzimanjePrijavaZainteresiranihResponse(result);

                if (!response.IsError
                    && response.Value.PreuzimanjePrijavaZainteresiranihResult?.ListaGresaka != null
                    && response.Value.PreuzimanjePrijavaZainteresiranihResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .PreuzimanjePrijavaZainteresiranihResult
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

        public async Task<Result<PreuzimanjePrijavaZainteresiranihResponse>> PreuzimanjePrijavaZainteresiranihAsync(PreuzimanjePrijavaZainteresiranihRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPreuzimanjePrijavaZainteresiranihRequest(request.PreuzimanjePrijavaZainteresiranihRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendSignedRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjePrijavaZainteresiranih",
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                }, ct);

                var response = ProcessPreuzimanjePrijavaZainteresiranihResponse(result);

                if (!response.IsError
                    && response.Value.PreuzimanjePrijavaZainteresiranihResult?.ListaGresaka != null
                    && response.Value.PreuzimanjePrijavaZainteresiranihResult.ListaGresaka.Any()
                   )
                {
                    return response.Value
                        .PreuzimanjePrijavaZainteresiranihResult
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

        private Result<SlanjeNarudzbenicaResponse> ProcessSlanjeNarudzbenicaResponse(SoapRequestResult result)
        {
            return ProcessResponse<WSlanjeNarudzbenicaResponse,
                SlanjeNarudzbenicaResponse>(
                result,
                response => new SlanjeNarudzbenicaResponse(response.Result));
        }

        private Result<PreuzimanjeOtpremniceResponse> ProcessPreuzimanjeOtpremniceResponse(SoapRequestResult result)
        {
            return ProcessResponse<WPreuzimanjeOtpremniceResponse,
                PreuzimanjeOtpremniceResponse>(
                result,
                response => new PreuzimanjeOtpremniceResponse(response.Result));
        }

        private Result<SlanjePrimkeResponse> ProcessSlanjePrimkeResponse(SoapRequestResult result)
        {
            return ProcessResponse<WSlanjePrimkeResponse,
                SlanjePrimkeResponse>(
                result,
                response => new SlanjePrimkeResponse(response.Result));
        }

        private Result<ObavijestOPovratuOtpisuCjepivaResponse> ProcessObavijestOPovratuOtpisuCjepivaResponse(SoapRequestResult result)
        {
            return ProcessResponse<WObavijestOPovratuOtpisuCjepivaResponse,
                ObavijestOPovratuOtpisuCjepivaResponse>(
                result,
                response => new ObavijestOPovratuOtpisuCjepivaResponse(response.Result));
        }

        private Result<SlanjeOtpremniceResponse> ProcessSlanjeOtpremniceResponse(SoapRequestResult result)
        {
            return ProcessResponse<WSlanjeOtpremniceResponse,
                SlanjeOtpremniceResponse>(
                result,
                response => new SlanjeOtpremniceResponse(response.Result));
        }

        private Result<ObavijestONedolazakNaCijepljenjeResponse> ProcessObavijestONedolazakNaCijepljenjeResponse(SoapRequestResult result)
        {
            return ProcessResponse<WObavijestONedolazakNaCijepljenjeResponse,
                ObavijestONedolazakNaCijepljenjeResponse>(
                result,
                response => new ObavijestONedolazakNaCijepljenjeResponse(response.Result));
        }

        private Result<ObavijestOCijepljenjeResponse> ProcessObavijestOCijepljenjeResponse(SoapRequestResult result)
        {
            return ProcessResponse<WObavijestOCijepljenjeResponse,
                ObavijestOCijepljenjeResponse>(
                result,
                response => new ObavijestOCijepljenjeResponse(response.Result));
        }

        private Result<OtkazivanjeObavijestOCijepljenjeResponse> ProcessOtkazivanjeObavijestOCijepljenjeResponse(SoapRequestResult result)
        {
            return ProcessResponse<WOtkazivanjeObavijestOCijepljenjeResponse,
                OtkazivanjeObavijestOCijepljenjeResponse>(
                result,
                response => new OtkazivanjeObavijestOCijepljenjeResponse(response.Result));
        }

        private Result<PrijavaNuspojaveCijepljenjaResponse> ProcessPrijavaNuspojaveCijepljenjaResponse(SoapRequestResult result)
        {
            return ProcessResponse<WPrijavaNuspojaveCijepljenjaResponse,
                PrijavaNuspojaveCijepljenjaResponse>(
                result,
                response => new PrijavaNuspojaveCijepljenjaResponse(response.Result));
        }

        private Result<UpitOCijepnomKartonuOsobeResponse> ProcessUpitOCijepnomKartonuOsobeResponse(SoapRequestResult result)
        {
            return ProcessResponse<WUpitOCijepnomKartonuOsobeResponse,
                UpitOCijepnomKartonuOsobeResponse>(
                result,
                response => new UpitOCijepnomKartonuOsobeResponse(response.Result));
        }

        private Result<PreuzimanjeZipResponse> ProcessPreuzimanjeZipResponse(SoapRequestResult result)
        {
            return ProcessResponse<WPreuzimanjeZipResponse,
                PreuzimanjeZipResponse>(
                result,
                response => new PreuzimanjeZipResponse(response.Result));
        }

        private Result<SlanjeZipResponse> ProcessSlanjeZipResponse(SoapRequestResult result)
        {
            return ProcessResponse<WSlanjeZipResponse,
                SlanjeZipResponse>(
                result,
                response => new SlanjeZipResponse(response.Result));
        }

        private Result<SlanjeLagerResponse> ProcessSlanjeLagerResponse(SoapRequestResult result)
        {
            return ProcessResponse<WSlanjeLagerResponse,
                SlanjeLagerResponse>(
                result,
                response => new SlanjeLagerResponse(response.Result));
        }

        private Result<StatusLijecenjaPacijentaResponseStatusLijecenjaPacijentaResult> ProcessStatusLijecenjaPacijentaResponse(SoapRequestResult result)
        {
            return ProcessResponse<WStatusLijecenjaPacijentaResponse,
                StatusLijecenjaPacijentaResponseStatusLijecenjaPacijentaResult>(
                result,
                response => response?.Result);
        }

        private Result<PrijavaZainteresiranihResponse> ProcessPrijavaZainteresiranihResponse(SoapRequestResult result)
        {
            return ProcessResponse<WPrijavaZainteresiranihResponse, PrijavaZainteresiranihResponse>(
                result,
                response => new PrijavaZainteresiranihResponse(response.Result)
            );
        }

        private Result<OtkazivanjePrijavaZainteresiranihResponse> ProcessOtkazivanjePrijavaZainteresiranihResponse(SoapRequestResult result)
        {
            return ProcessResponse<WOtkazivanjePrijavaZainteresiranihResponse, OtkazivanjePrijavaZainteresiranihResponse>(
                result,
                response => new OtkazivanjePrijavaZainteresiranihResponse(response.Result)
            );
        }

        private Result<PreuzimanjePrijavaZainteresiranihResponse> ProcessPreuzimanjePrijavaZainteresiranihResponse(SoapRequestResult result)
        {
            return ProcessResponse<WPreuzimanjePrijavaZainteresiranihResponse, PreuzimanjePrijavaZainteresiranihResponse>(
                result,
                response => new PreuzimanjePrijavaZainteresiranihResponse(response.Result)
            );
        }

        private XmlSerializerNamespaces Namespaces
        {
            get
            {
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add("urn", "urn:publicid:-:FileTransferWebService:WS-types:1.0");
                return namespaces;
            }
        }
    }
}