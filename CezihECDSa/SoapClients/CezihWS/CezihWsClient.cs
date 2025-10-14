using CezihECDSa.SoapClients.CezihWs.Wrappers;
using CezihECDSa.Wsdl.CezihWS;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
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

        private Result<string> ProcesEchoResponse(SoapRequestResult result)
        {
            return ProcessResponse<WEchoResponse, string>(
                result,
                body => body.Output);
        }

        private Result<ListaPacijenataListResponse> ProcesFetchListaPacijenataListResponse(SoapRequestResult result)
        {
            return ProcessResponse<WFetchListaPacijenataListResponse, ListaPacijenataListResponse>(
                result,
                wrapper => new ListaPacijenataListResponse { imeMape = wrapper.imeMape }
            );
        }

        private Result<ListaPacijenataZipResponse> ProcesFetchListaPacijenataZipResponse(SoapRequestResult result)
        {
            return ProcessResponse<WFetchListaPacijenataZipResponse, ListaPacijenataZipResponse>(
                result,
                wrapper => new ListaPacijenataZipResponse
                {
                    imeDatoteke = wrapper.imeDatoteke,
                    datoteka = wrapper.datoteka
                }
            );
        }

        private Result<ListaPacijenataLastZipResponse> ProcesFetchListaPacijenataLastZipResponse(SoapRequestResult result)
        {
            return ProcessResponse<WFetchListaPacijenataLastZipResponse, ListaPacijenataLastZipResponse>(
                result,
                wrapper => new ListaPacijenataLastZipResponse
                {
                    imeDatoteke = wrapper.imeDatoteke,
                    datoteka = wrapper.datoteka
                }
            );
        }

        private Result<UploadResponse> ProcesUploadResponse(SoapRequestResult result)
        {
            return ProcessResponse<WUploadResponse, UploadResponse>(
                result,
                body => body.Output);
        }

        private Result<ListaRezultataListResponse> ProcesFetchListaRezultataObradeListResponse(SoapRequestResult result)
        {
            return ProcessResponse<WFetchListaRezultataListResponse, ListaRezultataListResponse>(
                result,
                wrapper => new ListaRezultataListResponse
                {
                    imeDatoteke = wrapper.imeDatoteke
                }
            );
        }

        private Result<RezultatObradeResponse> ProcesFetchRezultatObradeResponse(SoapRequestResult result)
        {
            return ProcessResponse<WFetchRezultatObradeResponse, RezultatObradeResponse>(
                result,
                wrapper => new RezultatObradeResponse
                {
                    imeDatoteke = wrapper.imeDatoteke,
                    datoteka = wrapper.datoteka
                }
            );
        }

        private Result<ArhivirajRezultatObradeResponse> ProcesArhivirajRezultatObradeResponse(SoapRequestResult result)
        {
            return ProcessResponse<WArhivirajRezultatObradeResponse, ArhivirajRezultatObradeResponse>(
                result,
                body => body.Output);
        }

        private Result<ListaEKartonaListResponse> ProcesFetchListaEKartonaListResponse(SoapRequestResult result)
        {
            return ProcessResponse<WFetchListaEKartonaListResponse, ListaEKartonaListResponse>(
                result,
                wrapper => new ListaEKartonaListResponse
                {
                    imeDatoteke = wrapper.imeDatoteke
                }
            );
        }

        private Result<WEKartonResponse> ProcesFetchEKartonResponse(SoapRequestResult result)
        {
            return ProcessResponse<WEKartonResponse, WEKartonResponse>(
                result,
                wrapper => wrapper
            );
        }

        private Result<ArhivirajEKartonResponse> ProcesArhivirajEKartonResponse(SoapRequestResult result)
        {
            return ProcessResponse<WArhivirajEKartonResponse, ArhivirajEKartonResponse>(
                result,
                body => body.Output);
        }

        private Result<ListaOtisliPacijentiListResponse> ProcesFetchOtisliPacijentiListResponse(SoapRequestResult result)
        {
            return ProcessResponse<WFetchListaOtisliPacijentiListResponse, ListaOtisliPacijentiListResponse>(
                result,
                wrapper => new ListaOtisliPacijentiListResponse
                {
                    imeDatoteke = wrapper.imeDatoteke
                }
            );
        }

        private Result<OtisliPacijentiResponse> ProcesFetchOtisliPacijentiResponse(SoapRequestResult result)
        {
            return ProcessResponse<WFetchOtisliPacijentiResponse, OtisliPacijentiResponse>(
                result,
                wrapper => new OtisliPacijentiResponse
                {
                    datoteka = wrapper.datoteka
                }
            );
        }

        private Result<ArhivirajOtisliPacijentiResponse> ProcesArhivirajOtisliPacijentiResponse(SoapRequestResult result)
        {
            return ProcessResponse<WArhivirajOtisliPacijentiResponse, ArhivirajOtisliPacijentiResponse>(
                result,
                wrapper => wrapper.Result
            );
        }

        private Result<fetchNeuspjesnoObradjeniRacuniResponse> ProcesFetchNeuspjesnoObradjeniRacuniResponse(SoapRequestResult result)
        {
            return ProcessResponse<WFetchNeuspjesnoObradjeniRacuniResponse, fetchNeuspjesnoObradjeniRacuniResponse>(
                result,
                body => body.Output);
        }

        private Result<ListaObavijestiListResponse> ProcesFetchListaObavijestiListResponse(SoapRequestResult result)
        {
            return ProcessResponse<WFetchListaObavijestiListResponse, ListaObavijestiListResponse>(
                result,
                wrapper => new ListaObavijestiListResponse
                {
                    imeDatoteke = wrapper.imeDatoteke
                }
            );
        }

        private Result<fetchObavijestResponse> ProcesFetchObavijestResponse(SoapRequestResult result)
        {
            return ProcessResponse<WFetchObavijestResponse, fetchObavijestResponse>(
                result,
                wrapper => new fetchObavijestResponse
                {
                    obavijestDatoteka = wrapper.obavijestDatoteka
                }
            );
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