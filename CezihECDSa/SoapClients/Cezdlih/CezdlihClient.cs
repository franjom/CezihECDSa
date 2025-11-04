using CezihECDSa.SoapClients.Cezdlih.Wrappers;
using CezihECDSa.Wsdl;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
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

        Result<ObavijestOPovratuOtpisuCjepivaResponse> ObavijestOPovratuOtpisuCjepiva(
            ObavijestOPovratuOtpisuCjepivaRequest request);

        Task<Result<ObavijestOPovratuOtpisuCjepivaResponse>> ObavijestOPovratuOtpisuCjepivaAsync(
            ObavijestOPovratuOtpisuCjepivaRequest request,
            CancellationToken ct = default);

        Result<SlanjeOtpremniceResponse> SlanjeOtpremnice(SlanjeOtpremniceRequest request);

        Task<Result<SlanjeOtpremniceResponse>> SlanjeOtpremniceAsync(SlanjeOtpremniceRequest request,
            CancellationToken ct = default);

        Result<ObavijestONedolazakNaCijepljenjeResponse> ObavijestONedolazakNaCijepljenje(
            ObavijestONedolazakNaCijepljenjeRequest request);

        Task<Result<ObavijestONedolazakNaCijepljenjeResponse>> ObavijestONedolazakNaCijepljenjeAsync(
            ObavijestONedolazakNaCijepljenjeRequest request,
            CancellationToken ct = default);

        Result<ObavijestOCijepljenjeResponse> ObavijestOCijepljenje(ObavijestOCijepljenjeRequest request);

        Task<Result<ObavijestOCijepljenjeResponse>> ObavijestOCijepljenjeAsync(ObavijestOCijepljenjeRequest request,
            CancellationToken ct = default);

        Result<OtkazivanjeObavijestOCijepljenjeResponse> OtkazivanjeObavijestOCijepljenje(
            OtkazivanjeObavijestOCijepljenjeRequest request);

        Task<Result<OtkazivanjeObavijestOCijepljenjeResponse>> OtkazivanjeObavijestOCijepljenjeAsync(
            OtkazivanjeObavijestOCijepljenjeRequest request,
            CancellationToken ct = default);

        Result<PrijavaNuspojaveCijepljenjaResponse> PrijavaNuspojaveCijepljenja(
            PrijavaNuspojaveCijepljenjaRequest request);

        Task<Result<PrijavaNuspojaveCijepljenjaResponse>> PrijavaNuspojaveCijepljenjaAsync(
            PrijavaNuspojaveCijepljenjaRequest request,
            CancellationToken ct = default);

        Result<UpitOCijepnomKartonuOsobeResponse> UpitOCijepnomKartonuOsobe(UpitOCijepnomKartonuOsobeRequest request);

        Task<Result<UpitOCijepnomKartonuOsobeResponse>> UpitOCijepnomKartonuOsobeAsync(
            UpitOCijepnomKartonuOsobeRequest request,
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

        Result<StatusLijecenjaPacijentaResponseStatusLijecenjaPacijentaResult> StatusLijecenjaPacijenta(
            StatusLijecenjaPacijentaZahtjevZaStatusLijecenjaPacijenta request);

        Task<Result<StatusLijecenjaPacijentaResponseStatusLijecenjaPacijentaResult>> StatusLijecenjaPacijentaAsync(
            StatusLijecenjaPacijentaZahtjevZaStatusLijecenjaPacijenta request,
            CancellationToken ct = default);

        Result<PrijavaZainteresiranihResponse> PrijavaZainteresiranih(PrijavaZainteresiranihRequest request);

        Task<Result<PrijavaZainteresiranihResponse>> PrijavaZainteresiranihAsync(PrijavaZainteresiranihRequest request,
            CancellationToken ct = default);

        Result<OtkazivanjePrijavaZainteresiranihResponse> OtkazivanjePrijavaZainteresiranih(
            OtkazivanjePrijavaZainteresiranihRequest request);

        Task<Result<OtkazivanjePrijavaZainteresiranihResponse>> OtkazivanjePrijavaZainteresiranihAsync(
            OtkazivanjePrijavaZainteresiranihRequest request,
            CancellationToken ct = default);

        Result<PreuzimanjePrijavaZainteresiranihResponse> PreuzimanjePrijavaZainteresiranih(
            PreuzimanjePrijavaZainteresiranihRequest request);

        Task<Result<PreuzimanjePrijavaZainteresiranihResponse>> PreuzimanjePrijavaZainteresiranihAsync(
            PreuzimanjePrijavaZainteresiranihRequest request,
            CancellationToken ct = default);
    }

    public class CezdlihClient : SoapClientBase, ICezdlihClient
    {
        private readonly CezdlihOptions _options;
        private readonly X509Certificate2 _cert;

        private const string Namespace = "http://www.cezdlih.hr/CEZDLIH/WebServices";

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

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjePlanaImunizacije",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjePlanaImunizacije",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true,
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

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjePlanaImunizacije",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjePlanaImunizacije",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeNarudzbenica",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public async Task<Result<SlanjeNarudzbenicaResponse>> SlanjeNarudzbenicaAsync(SlanjeNarudzbenicaRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjeNarudzbenicaRequest(request.SlanjeNarudzbenicaRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeNarudzbenica",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjeOtpremnice",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public async Task<Result<PreuzimanjeOtpremniceResponse>> PreuzimanjeOtpremniceAsync(
            PreuzimanjeOtpremniceRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPreuzimanjeOtpremniceRequest(request.PreuzimanjeOtpremniceRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjeOtpremnice",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjePrimke",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public async Task<Result<SlanjePrimkeResponse>> SlanjePrimkeAsync(SlanjePrimkeRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjePrimkeRequest(request.SlanjePrimkeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjePrimke",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public Result<ObavijestOPovratuOtpisuCjepivaResponse> ObavijestOPovratuOtpisuCjepiva(
            ObavijestOPovratuOtpisuCjepivaRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WObavijestOPovratuOtpisuCjepivaRequest(request.ObavijestOPovratuOtpisuCjepivaRequest1),
                    Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/ObavijestOPovratuOtpisuCjepiva",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public async Task<Result<ObavijestOPovratuOtpisuCjepivaResponse>> ObavijestOPovratuOtpisuCjepivaAsync(
            ObavijestOPovratuOtpisuCjepivaRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WObavijestOPovratuOtpisuCjepivaRequest(request.ObavijestOPovratuOtpisuCjepivaRequest1),
                    Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/ObavijestOPovratuOtpisuCjepiva",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeOtpremnice",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public async Task<Result<SlanjeOtpremniceResponse>> SlanjeOtpremniceAsync(SlanjeOtpremniceRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjeOtpremniceRequest(request.SlanjeOtpremniceRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeOtpremnice",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public Result<ObavijestONedolazakNaCijepljenjeResponse> ObavijestONedolazakNaCijepljenje(
            ObavijestONedolazakNaCijepljenjeRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WObavijestONedolazakNaCijepljenjeRequest(request.ObavijestONedolazakNaCijepljenjeRequest1),
                    Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/ObavijestONedolazakNaCijepljenje",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public async Task<Result<ObavijestONedolazakNaCijepljenjeResponse>> ObavijestONedolazakNaCijepljenjeAsync(
            ObavijestONedolazakNaCijepljenjeRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WObavijestONedolazakNaCijepljenjeRequest(request.ObavijestONedolazakNaCijepljenjeRequest1),
                    Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/ObavijestONedolazakNaCijepljenje",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/ObavijestOCijepljenje",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public async Task<Result<ObavijestOCijepljenjeResponse>> ObavijestOCijepljenjeAsync(
            ObavijestOCijepljenjeRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WObavijestOCijepljenjeRequest(request.ObavijestOCijepljenjeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/ObavijestOCijepljenje",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public Result<OtkazivanjeObavijestOCijepljenjeResponse> OtkazivanjeObavijestOCijepljenje(
            OtkazivanjeObavijestOCijepljenjeRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WOtkazivanjeObavijestOCijepljenjeRequest(request.OtkazivanjeObavijestOCijepljenjeRequest1),
                    Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/OtkazivanjeObavijestOCijepljenje",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public async Task<Result<OtkazivanjeObavijestOCijepljenjeResponse>> OtkazivanjeObavijestOCijepljenjeAsync(
            OtkazivanjeObavijestOCijepljenjeRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WOtkazivanjeObavijestOCijepljenjeRequest(request.OtkazivanjeObavijestOCijepljenjeRequest1),
                    Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/OtkazivanjeObavijestOCijepljenje",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public Result<PrijavaNuspojaveCijepljenjaResponse> PrijavaNuspojaveCijepljenja(
            PrijavaNuspojaveCijepljenjaRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPrijavaNuspojaveCijepljenjaRequest(request.PrijavaNuspojaveCijepljenjaRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PrijavaNuspojaveCijepljenja",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public async Task<Result<PrijavaNuspojaveCijepljenjaResponse>> PrijavaNuspojaveCijepljenjaAsync(
            PrijavaNuspojaveCijepljenjaRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPrijavaNuspojaveCijepljenjaRequest(request.PrijavaNuspojaveCijepljenjaRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PrijavaNuspojaveCijepljenja",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public Result<UpitOCijepnomKartonuOsobeResponse> UpitOCijepnomKartonuOsobe(
            UpitOCijepnomKartonuOsobeRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WUpitOCijepnomKartonuOsobeRequest(request.UpitOCijepnomKartonuOsobeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/UpitOCijepnomKartonuOsobe",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public async Task<Result<UpitOCijepnomKartonuOsobeResponse>> UpitOCijepnomKartonuOsobeAsync(
            UpitOCijepnomKartonuOsobeRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WUpitOCijepnomKartonuOsobeRequest(request.UpitOCijepnomKartonuOsobeRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/UpitOCijepnomKartonuOsobe",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjeZip",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
                });

                var response = ProcessPreuzimanjeZipResponse(result);

                return response;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<PreuzimanjeZipResponse>> PreuzimanjeZipAsync(PreuzimanjeZipRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPreuzimanjeZipRequest(request.PreuzimanjeZipRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjeZip",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeZip",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public async Task<Result<SlanjeZipResponse>> SlanjeZipAsync(SlanjeZipRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjeZipRequest(request.SlanjeZipRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeZip",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeLager",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public async Task<Result<SlanjeLagerResponse>> SlanjeLagerAsync(SlanjeLagerRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WSlanjeLagerRequest(request.SlanjeLagerRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/SlanjeLager",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public Result<StatusLijecenjaPacijentaResponseStatusLijecenjaPacijentaResult> StatusLijecenjaPacijenta(
            StatusLijecenjaPacijentaZahtjevZaStatusLijecenjaPacijenta request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WStatusLijecenjaPacijentaRequest(request), Namespaces);

                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/StatusLijecenjaPacijenta",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public async Task<Result<StatusLijecenjaPacijentaResponseStatusLijecenjaPacijentaResult>>
            StatusLijecenjaPacijentaAsync(StatusLijecenjaPacijentaZahtjevZaStatusLijecenjaPacijenta request,
                CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WStatusLijecenjaPacijentaRequest(request), Namespaces);

                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/StatusLijecenjaPacijenta",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PrijavaZainteresiranih",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
                });

                var response = ProcessPrijavaZainteresiranihResponse(result);

                if (!response.IsError
                    && response.Value.PrijavaZainteresiranihResult?.ListaGresaka != null
                    && response.Value.PrijavaZainteresiranihResult.ListaGresaka.Any())
                {
                    return response.Value.PrijavaZainteresiranihResult.ListaGresaka
                        .Select(o => new ErrorMessage(o.NazivGreske)).ToList();
                }

                return response;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<PrijavaZainteresiranihResponse>> PrijavaZainteresiranihAsync(
            PrijavaZainteresiranihRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPrijavaZainteresiranihRequest(request.PrijavaZainteresiranihRequest1), Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PrijavaZainteresiranih",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
                }, ct);

                var response = ProcessPrijavaZainteresiranihResponse(result);

                if (!response.IsError
                    && response.Value.PrijavaZainteresiranihResult?.ListaGresaka != null
                    && response.Value.PrijavaZainteresiranihResult.ListaGresaka.Any())
                {
                    return response.Value.PrijavaZainteresiranihResult.ListaGresaka
                        .Select(o => new ErrorMessage(o.NazivGreske)).ToList();
                }

                return response;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<OtkazivanjePrijavaZainteresiranihResponse> OtkazivanjePrijavaZainteresiranih(
            OtkazivanjePrijavaZainteresiranihRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WOtkazivanjePrijavaZainteresiranihRequest(request.OtkazivanjePrijavaZainteresiranihRequest1),
                    Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/OtkazivanjePrijavaZainteresiranih",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public async Task<Result<OtkazivanjePrijavaZainteresiranihResponse>> OtkazivanjePrijavaZainteresiranihAsync(
            OtkazivanjePrijavaZainteresiranihRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WOtkazivanjePrijavaZainteresiranihRequest(request.OtkazivanjePrijavaZainteresiranihRequest1),
                    Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/OtkazivanjePrijavaZainteresiranih",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public Result<PreuzimanjePrijavaZainteresiranihResponse> PreuzimanjePrijavaZainteresiranih(
            PreuzimanjePrijavaZainteresiranihRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPreuzimanjePrijavaZainteresiranihRequest(request.PreuzimanjePrijavaZainteresiranihRequest1),
                    Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjePrijavaZainteresiranih",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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

        public async Task<Result<PreuzimanjePrijavaZainteresiranihResponse>> PreuzimanjePrijavaZainteresiranihAsync(
            PreuzimanjePrijavaZainteresiranihRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(
                    new WPreuzimanjePrijavaZainteresiranihRequest(request.PreuzimanjePrijavaZainteresiranihRequest1),
                    Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/PreuzimanjePrijavaZainteresiranih",
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
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
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WPreuzimanjePlanaImunizacijeResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new PreuzimanjePlanaImunizacijeResponse(othersResponse.Result);
        }

        private Result<SlanjePlanaImunizacijeResponse> ProcessSlanjePlanaImunizacijeResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WSlanjePlanaImunizacijeResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new SlanjePlanaImunizacijeResponse(othersResponse.Result);
        }

        private Result<SlanjeNarudzbenicaResponse> ProcessSlanjeNarudzbenicaResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WSlanjeNarudzbenicaResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new SlanjeNarudzbenicaResponse(othersResponse.Result);
        }

        private Result<PreuzimanjeOtpremniceResponse> ProcessPreuzimanjeOtpremniceResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WPreuzimanjeOtpremniceResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new PreuzimanjeOtpremniceResponse(othersResponse.Result);
        }

        private Result<SlanjePrimkeResponse> ProcessSlanjePrimkeResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WSlanjePrimkeResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new SlanjePrimkeResponse(othersResponse.Result);
        }

        private Result<ObavijestOPovratuOtpisuCjepivaResponse> ProcessObavijestOPovratuOtpisuCjepivaResponse(
            SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WObavijestOPovratuOtpisuCjepivaResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new ObavijestOPovratuOtpisuCjepivaResponse(othersResponse.Result);
        }

        private Result<SlanjeOtpremniceResponse> ProcessSlanjeOtpremniceResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WSlanjeOtpremniceResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new SlanjeOtpremniceResponse(othersResponse.Result);
        }

        private Result<ObavijestONedolazakNaCijepljenjeResponse> ProcessObavijestONedolazakNaCijepljenjeResponse(
            SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WObavijestONedolazakNaCijepljenjeResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new ObavijestONedolazakNaCijepljenjeResponse(othersResponse.Result);
        }

        private Result<ObavijestOCijepljenjeResponse> ProcessObavijestOCijepljenjeResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WObavijestOCijepljenjeResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new ObavijestOCijepljenjeResponse(othersResponse.Result);
        }

        private Result<OtkazivanjeObavijestOCijepljenjeResponse> ProcessOtkazivanjeObavijestOCijepljenjeResponse(
            SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WOtkazivanjeObavijestOCijepljenjeResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new OtkazivanjeObavijestOCijepljenjeResponse(othersResponse.Result);
        }

        private Result<PrijavaNuspojaveCijepljenjaResponse> ProcessPrijavaNuspojaveCijepljenjaResponse(
            SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WPrijavaNuspojaveCijepljenjaResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new PrijavaNuspojaveCijepljenjaResponse(othersResponse.Result);
        }

        private Result<UpitOCijepnomKartonuOsobeResponse> ProcessUpitOCijepnomKartonuOsobeResponse(
            SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WUpitOCijepnomKartonuOsobeResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new UpitOCijepnomKartonuOsobeResponse(othersResponse.Result);
        }

        private Result<PreuzimanjeZipResponse> ProcessPreuzimanjeZipResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WPreuzimanjeZipResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new PreuzimanjeZipResponse(othersResponse.Result);
        }

        private Result<SlanjeZipResponse> ProcessSlanjeZipResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WSlanjeZipResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new SlanjeZipResponse(othersResponse.Result);
        }

        private Result<SlanjeLagerResponse> ProcessSlanjeLagerResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WSlanjeLagerResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new SlanjeLagerResponse(othersResponse.Result);
        }

        private Result<StatusLijecenjaPacijentaResponseStatusLijecenjaPacijentaResult>
            ProcessStatusLijecenjaPacijentaResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WStatusLijecenjaPacijentaResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return othersResponse.Result;
        }

        private Result<PrijavaZainteresiranihResponse> ProcessPrijavaZainteresiranihResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WPrijavaZainteresiranihResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new PrijavaZainteresiranihResponse(othersResponse.Result);
        }

        private Result<OtkazivanjePrijavaZainteresiranihResponse> ProcessOtkazivanjePrijavaZainteresiranihResponse(
            SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WOtkazivanjePrijavaZainteresiranihResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new OtkazivanjePrijavaZainteresiranihResponse(othersResponse.Result);
        }

        private Result<PreuzimanjePrijavaZainteresiranihResponse> ProcessPreuzimanjePrijavaZainteresiranihResponse(
            SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WPreuzimanjePrijavaZainteresiranihResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return new PreuzimanjePrijavaZainteresiranihResponse(othersResponse.Result);
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