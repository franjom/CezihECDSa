using CezihECDSa.SoapClients.InfoOthers.Wrappers;
using CezihECDSa.Wsdl.InfoOthers;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.InfoOthers
{
    public interface IInfoOthersClient
    {
        Result<OsigStatus> DohvatiOthers(WDohvatiOthersRequest request);

        Task<Result<OsigStatus>> DohvatiOthersAsync(WDohvatiOthersRequest request,
            CancellationToken ct = default);

        Result<OsigStatus> DohvatiOthersNaDan(WDohvatiOthersNaDanRequest request);

        Task<Result<OsigStatus>> DohvatiOthersNaDanAsync(WDohvatiOthersNaDanRequest request,
            CancellationToken ct = default);

        Result<AutStatus> AutorizacijaOthers(WAutorizacijaOthersRequest request);

        Task<Result<AutStatus>> AutorizacijaOthersAsync(WAutorizacijaOthersRequest request,
            CancellationToken ct = default);

        Result<AutStatus> AutorizacijaOthersPharmacy(WAutorizacijaOthersPharmacyRequest request);

        Task<Result<AutStatus>> AutorizacijaOthersPharmacyAsync(WAutorizacijaOthersPharmacyRequest request,
            CancellationToken ct = default);

        Result<StornoStatus> StornoOthers(WStornoOthersRequest request);

        Task<Result<StornoStatus>> StornoOthersAsync(WStornoOthersRequest request,
            CancellationToken ct = default);
    }

    public class InfoOthersClient : SoapClientBase, IInfoOthersClient
    {
        private readonly InfoOthersOptions _options;
        private readonly X509Certificate2 _cert;

        private const string Namespace = "http://tempuri.org/";

        public InfoOthersClient(InfoOthersOptions options, X509Certificate2 cert) : base(SoapVersion.Soap11)
        {
            _options = options;
            _cert = cert;
        }

        protected override TimeSpan DefaultTimeout
        {
            get { return _options.Timeout ?? TimeSpan.FromSeconds(30); }
        }

        public Result<OsigStatus> DohvatiOthers(WDohvatiOthersRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "http://tempuri.org/IInfoOthers/DohvatiOthers",
                    Uri = uri,
                    XmlString = xml,
                    MessageId = Guid.NewGuid()
                });

                return ProcesDohvatiOthersResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<OsigStatus>> DohvatiOthersAsync(WDohvatiOthersRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "http://tempuri.org/IInfoOthers/DohvatiOthers",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesDohvatiOthersResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }


        public Result<OsigStatus> DohvatiOthersNaDan(WDohvatiOthersNaDanRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "http://tempuri.org/IInfoOthers/DohvatiOthersNaDan",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesDohvatiOthersNaDanResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<OsigStatus>> DohvatiOthersNaDanAsync(WDohvatiOthersNaDanRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "http://tempuri.org/IInfoOthers/DohvatiOthersNaDan",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesDohvatiOthersNaDanResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }


        public Result<AutStatus> AutorizacijaOthers(WAutorizacijaOthersRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "http://tempuri.org/IInfoOthers/AutorizacijaOthers",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesAutorizacijaOthersResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<AutStatus>> AutorizacijaOthersAsync(WAutorizacijaOthersRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "http://tempuri.org/IInfoOthers/AutorizacijaOthers",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesAutorizacijaOthersResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }


        public Result<AutStatus> AutorizacijaOthersPharmacy(WAutorizacijaOthersPharmacyRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "http://tempuri.org/IInfoOthers/AutorizacijaOthersPharmacy",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesAutorizacijaOthersPharmacyResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<AutStatus>> AutorizacijaOthersPharmacyAsync(WAutorizacijaOthersPharmacyRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "http://tempuri.org/IInfoOthers/AutorizacijaOthersPharmacy",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesAutorizacijaOthersPharmacyResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<StornoStatus> StornoOthers(WStornoOthersRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "http://tempuri.org/IInfoOthers/StornoOthers",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesStornoOthersResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<StornoStatus>> StornoOthersAsync(WStornoOthersRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "http://tempuri.org/IInfoOthers/StornoOthers",
                    Uri = uri,
                    XmlString = xml
                }, ct);

                return ProcesStornoOthersResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        #region Process

        private Result<OsigStatus> ProcesDohvatiOthersResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WDohvatiOthersResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return othersResponse.Output;
        }

        private Result<OsigStatus> ProcesDohvatiOthersNaDanResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WDohvatiOthersNaDanResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return othersResponse.Output;
        }

        private Result<AutStatus> ProcesAutorizacijaOthersResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WAutorizacijaOthersResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return othersResponse.Output;
        }

        private Result<AutStatus> ProcesAutorizacijaOthersPharmacyResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WAutorizacijaOthersPharmacyResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return othersResponse.Output;
        }

        private Result<StornoStatus> ProcesStornoOthersResponse(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<WStornoOthersResponse>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", Namespace));

            return othersResponse.Output;
        }

        #endregion

        private XmlSerializerNamespaces Namespaces
        {
            get
            {
                var namespaces = new XmlSerializerNamespaces();
                //namespaces.Add("tempuri", "http://tempuri.org/");

                return namespaces;
            }
        }
    }
}