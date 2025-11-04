using CezihECDSa.SoapClients.CezihWs.Wrappers;
using CezihECDSa.Wsdl.CezihWS;
using CezihECDSa.Wsdl.PrijavaZarazne;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CezihWs
{
    public interface ICezihWsClient
    {
        Result<string> Echo(WEchoRequest request);
        Task<Result<string>> EchoAsync(WEchoRequest request,
            CancellationToken ct = default);

        Result<ListaPacijenataListResponse> FetchListaPacijenataList(WFetchListaPacijenataListRequest request);
        Task<Result<ListaPacijenataListResponse>> FetchListaPacijenataListAsync(WFetchListaPacijenataListRequest request,
            CancellationToken ct = default);

        Result<ListaPacijenataZipResponse> FetchListaPacijenataZip(WFetchListaPacijenataZipRequest request);
        Task<Result<ListaPacijenataZipResponse>> FetchListaPacijenataZipAsync(WFetchListaPacijenataZipRequest request,
            CancellationToken ct = default);

        Result<ListaPacijenataLastZipResponse> FetchListaPacijenataLastZip(WFetchListaPacijenataLastZipRequest request);
        Task<Result<ListaPacijenataLastZipResponse>> FetchListaPacijenataLastZipAsync(WFetchListaPacijenataLastZipRequest request,
            CancellationToken ct = default);

        Result<UploadResponse> Upload(WUploadRequest request);
        Task<Result<UploadResponse>> UploadAsync(WUploadRequest request,
            CancellationToken ct = default);

        Result<ListaRezultataListResponse> FetchListaRezultataObradeList(WFetchListaRezultataObradeListRequest request);
        Task<Result<ListaRezultataListResponse>> FetchListaRezultataObradeListAsync(WFetchListaRezultataObradeListRequest request,
            CancellationToken ct = default);

        Result<RezultatObradeResponse> FetchRezultatObrade(WFetchRezultatObradeRequest request);
        Task<Result<RezultatObradeResponse>> FetchRezultatObradeAsync(WFetchRezultatObradeRequest request,
            CancellationToken ct = default);

        Result<ArhivirajRezultatObradeResponse> ArhivirajRezultatObrade(WArhivirajRezultatObradeRequest request);
        Task<Result<ArhivirajRezultatObradeResponse>> ArhivirajRezultatObradeAsync(WArhivirajRezultatObradeRequest request,
            CancellationToken ct = default);

        Result<ListaEKartonaListResponse> FetchListaEKartonaList(WFetchListaEKartonaListRequest request);
        Task<Result<ListaEKartonaListResponse>> FetchListaEKartonaListAsync(WFetchListaEKartonaListRequest request,
            CancellationToken ct = default);

        Result<EKartonResponse> FetchEKarton(WFetchEKartonRequest request);
        Task<Result<EKartonResponse>> FetchEKartonAsync(WFetchEKartonRequest request,
            CancellationToken ct = default);

        Result<ArhivirajEKartonResponse> ArhivirajEKarton(WArhivirajEKartonRequest request);
        Task<Result<ArhivirajEKartonResponse>> ArhivirajEKartonAsync(WArhivirajEKartonRequest request,
            CancellationToken ct = default);

        Result<ListaOtisliPacijentiListResponse> FetchOtisliPacijentiList(WFetchOtisliPacijentiListRequest request);
        Task<Result<ListaOtisliPacijentiListResponse>> FetchOtisliPacijentiListAsync(WFetchOtisliPacijentiListRequest request,
            CancellationToken ct = default);

        Result<OtisliPacijentiResponse> FetchOtisliPacijenti(WFetchOtisliPacijentiRequest request);
        Task<Result<OtisliPacijentiResponse>> FetchOtisliPacijentiAsync(WFetchOtisliPacijentiRequest request,
            CancellationToken ct = default);

        Result<ArhivirajOtisliPacijentiResponse> ArhivirajOtisliPacijenti(WArhivirajOtisliPacijentiRequest request);
        Task<Result<ArhivirajOtisliPacijentiResponse>> ArhivirajOtisliPacijentiAsync(WArhivirajOtisliPacijentiRequest request,
            CancellationToken ct = default);

        Result<fetchNeuspjesnoObradjeniRacuniResponse> FetchNeuspjesnoObradjeniRacuni(WFetchNeuspjesnoObradjeniRacuniRequest request);
        Task<Result<fetchNeuspjesnoObradjeniRacuniResponse>> FetchNeuspjesnoObradjeniRacuniAsync(WFetchNeuspjesnoObradjeniRacuniRequest request,
            CancellationToken ct = default);

        Result<ListaObavijestiListResponse> FetchListaObavijestiList(WFetchListaObavijestiListRequest request);
        Task<Result<ListaObavijestiListResponse>> FetchListaObavijestiListAsync(WFetchListaObavijestiListRequest request,
            CancellationToken ct = default);

        Result<fetchObavijestResponse> FetchObavijest(WFetchObavijestRequest request);
        Task<Result<fetchObavijestResponse>> FetchObavijestAsync(WFetchObavijestRequest request,
            CancellationToken ct = default);
    }

    public class CezihWsClient : SoapClientBase//, ICezihWsClient
    {
        private readonly CezihWsOptions _options;
        private readonly X509Certificate2 _cert;

        public CezihWsClient(CezihWsOptions options, X509Certificate2 cert) : base(SoapVersion.Soap11)
        {
            _options = options;
            _cert = cert;
        }

        public Result<string> Echo(WEchoRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/echo",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesEchoResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<string>> EchoAsync(WEchoRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/echo",
                    Uri = uri,
                    XmlString = xml
                }, ct);
                return ProcesEchoResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<ListaPacijenataListResponse> FetchListaPacijenataList(WFetchListaPacijenataListRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchListaPacijenataList",
                    Uri = uri,
                    XmlString = xml
                });
                return ProcesFetchListaPacijenataListResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<ListaPacijenataListResponse>> FetchListaPacijenataListAsync(WFetchListaPacijenataListRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchListaPacijenataList",
                    Uri = uri,
                    XmlString = xml
                }, ct);
                return ProcesFetchListaPacijenataListResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<ListaPacijenataZipResponse> FetchListaPacijenataZip(WFetchListaPacijenataZipRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchListaPacijenataZip",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesFetchListaPacijenataZipResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<ListaPacijenataZipResponse>> FetchListaPacijenataZipAsync(WFetchListaPacijenataZipRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchListaPacijenataZip",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesFetchListaPacijenataZipResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<ListaPacijenataLastZipResponse> FetchListaPacijenataLastZip(WFetchListaPacijenataLastZipRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchListaPacijenataLastZip",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesFetchListaPacijenataLastZipResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<ListaPacijenataLastZipResponse>> FetchListaPacijenataLastZipAsync(WFetchListaPacijenataLastZipRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchListaPacijenataLastZip",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesFetchListaPacijenataLastZipResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<UploadResponse> Upload(WUploadRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/upload",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesUploadResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<UploadResponse>> UploadAsync(WUploadRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/upload",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesUploadResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<ListaRezultataListResponse> FetchListaRezultataObradeList(WFetchListaRezultataObradeListRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchListaRezultataObradeList",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesFetchListaRezultataObradeListResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<ListaRezultataListResponse>> FetchListaRezultataObradeListAsync(WFetchListaRezultataObradeListRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchListaRezultataObradeList",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesFetchListaRezultataObradeListResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<RezultatObradeResponse> FetchRezultatObrade(WFetchRezultatObradeRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchRezultatObrade",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesFetchRezultatObradeResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<RezultatObradeResponse>> FetchRezultatObradeAsync(WFetchRezultatObradeRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchRezultatObrade",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesFetchRezultatObradeResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }


        public Result<ArhivirajRezultatObradeResponse> ArhivirajRezultatObrade(WArhivirajRezultatObradeRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/arhivirajRezultatObrade",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesArhivirajRezultatObradeResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<ArhivirajRezultatObradeResponse>> ArhivirajRezultatObradeAsync(WArhivirajRezultatObradeRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/arhivirajRezultatObrade",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesArhivirajRezultatObradeResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<ListaEKartonaListResponse> FetchListaEKartonaList(WFetchListaEKartonaListRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchListaEKartonaList",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesFetchListaEKartonaListResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<ListaEKartonaListResponse>> FetchListaEKartonaListAsync(WFetchListaEKartonaListRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchListaEKartonaList",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesFetchListaEKartonaListResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<WEKartonResponse> FetchEKarton(WFetchEKartonRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchEKarton",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesFetchEKartonResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<WEKartonResponse>> FetchEKartonAsync(WFetchEKartonRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchEKarton",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesFetchEKartonResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<ArhivirajEKartonResponse> ArhivirajEKarton(WArhivirajEKartonRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/arhivirajEKarton",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesArhivirajEKartonResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<ArhivirajEKartonResponse>> ArhivirajEKartonAsync(WArhivirajEKartonRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/arhivirajEKarton",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesArhivirajEKartonResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<ListaOtisliPacijentiListResponse> FetchOtisliPacijentiList(WFetchOtisliPacijentiListRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchOtisliPacijentiList",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesFetchOtisliPacijentiListResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<ListaOtisliPacijentiListResponse>> FetchOtisliPacijentiListAsync(WFetchOtisliPacijentiListRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchOtisliPacijentiList",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesFetchOtisliPacijentiListResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<OtisliPacijentiResponse> FetchOtisliPacijenti(WFetchOtisliPacijentiRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchOtisliPacijenti",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesFetchOtisliPacijentiResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<OtisliPacijentiResponse>> FetchOtisliPacijentiAsync(WFetchOtisliPacijentiRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchOtisliPacijenti",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesFetchOtisliPacijentiResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<ArhivirajOtisliPacijentiResponse> ArhivirajOtisliPacijenti(WArhivirajOtisliPacijentiRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/arhivirajOtisliPacijenti",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesArhivirajOtisliPacijentiResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<ArhivirajOtisliPacijentiResponse>> ArhivirajOtisliPacijentiAsync(WArhivirajOtisliPacijentiRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/arhivirajOtisliPacijenti",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesArhivirajOtisliPacijentiResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<fetchNeuspjesnoObradjeniRacuniResponse> FetchNeuspjesnoObradjeniRacuni(WFetchNeuspjesnoObradjeniRacuniRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchNeuspjesnoObradjeniRacuni",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesFetchNeuspjesnoObradjeniRacuniResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<fetchNeuspjesnoObradjeniRacuniResponse>> FetchNeuspjesnoObradjeniRacuniAsync(WFetchNeuspjesnoObradjeniRacuniRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchNeuspjesnoObradjeniRacuni",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesFetchNeuspjesnoObradjeniRacuniResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }
        public Result<ListaObavijestiListResponse> FetchListaObavijestiList(WFetchListaObavijestiListRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchListaObavijestiList",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesFetchListaObavijestiListResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<ListaObavijestiListResponse>> FetchListaObavijestiListAsync(WFetchListaObavijestiListRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchListaObavijestiList",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesFetchListaObavijestiListResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<fetchObavijestResponse> FetchObavijest(WFetchObavijestRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchObavijest",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesFetchObavijestResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<fetchObavijestResponse>> FetchObavijestAsync(WFetchObavijestRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");
                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "urn:publicid:-:FileTransferWebService:WS:1.0/fetchObavijest",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesFetchObavijestResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }



        private Result<string> ProcesEchoResponse(
            SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<echoResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName);

            return body.EchoResponse1;
        }

        private Result<ListaPacijenataListResponse> ProcesFetchListaPacijenataListResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<ListaPacijenataListResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private Result<ListaPacijenataZipResponse> ProcesFetchListaPacijenataZipResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<ListaPacijenataZipResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private Result<ListaPacijenataLastZipResponse> ProcesFetchListaPacijenataLastZipResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<ListaPacijenataLastZipResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private Result<UploadResponse> ProcesUploadResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<UploadResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private Result<ListaRezultataListResponse> ProcesFetchListaRezultataObradeListResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<ListaRezultataListResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private Result<RezultatObradeResponse> ProcesFetchRezultatObradeResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<RezultatObradeResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private Result<ArhivirajRezultatObradeResponse> ProcesArhivirajRezultatObradeResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<ArhivirajRezultatObradeResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private Result<ListaEKartonaListResponse> ProcesFetchListaEKartonaListResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<ListaEKartonaListResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private Result<WEKartonResponse> ProcesFetchEKartonResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<WEKartonResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private Result<ArhivirajEKartonResponse> ProcesArhivirajEKartonResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<ArhivirajEKartonResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private Result<ListaOtisliPacijentiListResponse> ProcesFetchOtisliPacijentiListResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<ListaOtisliPacijentiListResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private Result<OtisliPacijentiResponse> ProcesFetchOtisliPacijentiResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<OtisliPacijentiResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private Result<ArhivirajOtisliPacijentiResponse> ProcesArhivirajOtisliPacijentiResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<ArhivirajOtisliPacijentiResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private Result<fetchNeuspjesnoObradjeniRacuniResponse> ProcesFetchNeuspjesnoObradjeniRacuniResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<fetchNeuspjesnoObradjeniRacuniResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private Result<ListaObavijestiListResponse> ProcesFetchListaObavijestiListResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<ListaObavijestiListResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private Result<fetchObavijestResponse> ProcesFetchObavijestResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            if (soapBody.IsError)
            {
                var messages = new List<ErrorMessage>();
                foreach (var item in soapBody.ErrorMessages)
                {
                    messages.Add(new ErrorMessage(item.Message));
                }

                return messages;
            }

            var body = SoapSerializer.Instance.Deserialize<fetchObavijestResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "urn:publicid:-:FileTransferWebService:WS-types:1.0"));

            return body;
        }

        private XmlSerializerNamespaces Namespaces
        {
            get
            {
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add("CezihWsSOAP", "urn:publicid:-:FileTransferWebService:WS-types:1.0");
                return namespaces;
            }
        }
    }
}