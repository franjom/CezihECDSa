using CezihECDSa.SoapClients.Cezdlih;
using CezihECDSa.SoapClients.Fin.Wrappers;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using ECDSAClientServices.Wsdl.Fin;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Fin
{
    public interface IFinClient
    {
        Result<SpecificationForInvoicesRecap> GetSpecificationForInvoiceRecap(WGetSpecificationForInvoiceRecapRequest request);
        Task<Result<SpecificationForInvoicesRecap>> GetSpecificationForInvoiceRecapAsync(WGetSpecificationForInvoiceRecapRequest request,
            CancellationToken ct);
    }
    public class FinClient : SoapClientBase, IFinClient
    {
        private readonly FinOptions _options;
        private readonly X509Certificate2 _cert;

        public FinClient(FinOptions options, X509Certificate2 cert) : base(SoapVersion.Soap11)
        {
            _options = options;
            _cert = cert;
        }

        protected override TimeSpan DefaultTimeout
        {
            get { return _options.Timeout ?? TimeSpan.FromSeconds(30); }
        }

        public Result<SpecificationForInvoicesRecap> GetSpecificationForInvoiceRecap(WGetSpecificationForInvoiceRecapRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendRequest(new SoapOptions
                {
                    Certificate = _cert,
                    SoapAction = "https://e-usluge.hzzo.hr/ews/finance/IFin/GetSpecificationForInvoiceRecap",
                    Uri = uri,
                    XmlString = xml
                });

                return ProcesGetSpecificationForInvoiceRecapResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<SpecificationForInvoicesRecap>> GetSpecificationForInvoiceRecapAsync(WGetSpecificationForInvoiceRecapRequest request, CancellationToken ct = default)
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

                return ProcesGetSpecificationForInvoiceRecapResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        #region Process

        private Result<SpecificationForInvoicesRecap> ProcesGetSpecificationForInvoiceRecapResponse(SoapRequestResult result)
        {
            return ProcessResponse<WGetSpecificationForInvoiceRecapResponse, SpecificationForInvoicesRecap>(
                result,
                body => body.Output);
        }

        #endregion

        private XmlSerializerNamespaces Namespaces
        {
            get
            {
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add("fin", "https://e-usluge.hzzo.hr/ews/finance");

                return namespaces;
            }
        }
    }
}
