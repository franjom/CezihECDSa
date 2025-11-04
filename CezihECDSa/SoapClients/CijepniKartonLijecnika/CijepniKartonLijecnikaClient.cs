using CezihECDSa.SoapClients.CijepniKartonLijecnika.Wrappers;
using CezihECDSa.SoapClients.InfoOthers.Wrappers;
using CezihECDSa.Wsdl.CijepniKartonLijecnika;
using CezihECDSa.Wsdl.InfoOthers;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.CijepniKartonLijecnika
{
    public interface ICijepniKartonLijecnikaClient
    {
        Result<UpitOCijepnimKartonimaIzabranogLijecnikaResponseUpitOCijepnimKartonimaIzabranogLijecnikaResult> UpitOCijepnimKartonimaIzabranogLijecnika(UpitOCijepnimKartonimaIzabranogLijecnikaRequest request);
        Task<Result<UpitOCijepnimKartonimaIzabranogLijecnikaResponseUpitOCijepnimKartonimaIzabranogLijecnikaResult>> UpitOCijepnimKartonimaIzabranogLijecnikaAsync(WUpitOCijepnimKartonimaIzabranogLijecnikaRequest request,
            CancellationToken ct = default);

    }
    public class CijepniKartonLijecnikaClient : SoapClientBase, ICijepniKartonLijecnikaClient
    {
        private readonly CijepniKartonLijecnikaOptions _options;
        private readonly X509Certificate2 _cert;

        public CijepniKartonLijecnikaClient(CijepniKartonLijecnikaOptions options, X509Certificate2 cert) : base(SoapVersion.Soap11)
        {
            _options = options;
            _cert = cert;
        }

        protected override TimeSpan DefaultTimeout
        {
            get { return _options.Timeout ?? TimeSpan.FromSeconds(30); }
        }

        public Result<UpitOCijepnimKartonimaIzabranogLijecnikaResponseUpitOCijepnimKartonimaIzabranogLijecnikaResult> UpitOCijepnimKartonimaIzabranogLijecnika(UpitOCijepnimKartonimaIzabranogLijecnikaRequest request)
        {
            try
            {
                var rootNs = new XmlQualifiedName("x", "http://www.cezdlih.hr/CEZDLIH/WebServices");
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces, "UpitOCijepnimKartonimaIzabranogLijecnikaRequest", rootNs);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/UpitOCijepnimKartonimaIzabranogLijecnika",
                    Uri = uri,
                    XmlString = xml,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true,
                });

                return ProcesUpitOCijepnimKartonimaIzabranogLijecnika(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<UpitOCijepnimKartonimaIzabranogLijecnikaResponseUpitOCijepnimKartonimaIzabranogLijecnikaResult>> UpitOCijepnimKartonimaIzabranogLijecnikaAsync(WUpitOCijepnimKartonimaIzabranogLijecnikaRequest request, CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = await SendRequestAsync(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "http://www.cezdlih.hr/CEZDLIH/WebServices/UpitOCijepnimKartonimaIzabranogLijecnika",
                    Uri = uri,
                    XmlString = xml,
                    SignEnvelope = true,
                }, ct);

                return ProcesUpitOCijepnimKartonimaIzabranogLijecnika(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        #region Process

        private Result<UpitOCijepnimKartonimaIzabranogLijecnikaResponseUpitOCijepnimKartonimaIzabranogLijecnikaResult> ProcesUpitOCijepnimKartonimaIzabranogLijecnika(SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var othersResponse = SoapSerializer.Instance.Deserialize<UpitOCijepnimKartonimaIzabranogLijecnikaResponseUpitOCijepnimKartonimaIzabranogLijecnikaResult>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName, new XmlQualifiedName("", "http://www.cezdlih.hr/CEZDLIH/WebServices"));

            return othersResponse;
        }

        #endregion

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
