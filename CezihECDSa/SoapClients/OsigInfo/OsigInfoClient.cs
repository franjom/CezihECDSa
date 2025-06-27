using CezihECDSa.Wsdl.OsigInfo;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
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

    public sealed class OsigInfoClient : SoapClientBase, IOsigInfoClient
    {
        private readonly OsigInfoOptions _options;
        private readonly X509Certificate2 _cert;

        public OsigInfoClient(OsigInfoOptions options, X509Certificate2 cert) : base(SoapVersion.Soap11)
        {
            _options = options;
            _cert = cert;
        }

        protected override TimeSpan DefaultTimeout
        {
            get { return _options.Timeout ?? TimeSpan.FromSeconds(15); }
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


        private Result<osigInfoForDoctorResponseOsigInfoForDoctorOutput[]> ProcessOsigInfoForDoctorResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<OsigInfoForDoctorResponse, osigInfoForDoctorResponseOsigInfoForDoctorOutput[]>(
                result,
                body => body.Output);
        }

        private Result<osigInfoForBISResponseOsigInfoForBISOutput[]> ProcessOsigInfoForBisResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<OsigInfoForBisResponse, osigInfoForBISResponseOsigInfoForBISOutput[]>(
                result,
                body => body.Output);
        }

        private Result<osigInfoForSKZZResponseOsigInfoForSKZZOutput> ProcessOsigInfoForSKZZResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<OsigInfoForSKZZResponse, osigInfoForSKZZResponseOsigInfoForSKZZOutput>(
                result,
                body => body.Output);
        }

        private Result<osigInfoForPharmacyResponseOsigInfoForPharmacyOutput> ProcessOsigInfoForPharmacyResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<OsigInfoForPharmacyResponse,
                osigInfoForPharmacyResponseOsigInfoForPharmacyOutput>(
                result,
                body => body.Output);
        }

        private Result<infoGlavarinaResponseGlavarina[]> ProcessInfoGlavarinaResponse(SoapRequestResult result)
        {
            return ProcessResponse<InfoGlavarinaCheckResponse,
                infoGlavarinaResponseGlavarina[]>(
                result,
                body => body.Output);
        }

        private Result<chosenDoctorResponseChosenDoctorOutput> ProcessChosenDoctorResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<ChosenDoctorResponse,
                chosenDoctorResponseChosenDoctorOutput>(
                result,
                body => body.Output);
        }

        private Result<orthopedicAidCheckResponseOrthopedicAidCheckOutput> ProcessOrtopedicAidResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<OrtopedicAidCheckResponse,
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
    }
}