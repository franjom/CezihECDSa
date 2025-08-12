using CezihECDSa.SoapClients.NRS.Wrappers;
using CezihECDSa.Wsdl.PrijavaZarazne;
using CezihECDSa.Wsdl.PrijavaZarazneUpdate;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.NRS
{
    public interface INRSClient
    {
        // @formatter:off
        Result<WReferenceScoreResult> CalculateScore(WReferenceScoreData request);

        // @formatter:on
    }

    public sealed class NRSClient : SoapClientBase, INRSClient
    {
        private readonly NRSOptions _options;
        private readonly X509Certificate2 _cert;

        public NRSClient(NRSOptions options, X509Certificate2 cert) : base(SoapVersion.Soap12)
        {
            _options = options;
            _cert = cert;
        }

        protected override TimeSpan DefaultTimeout
        {
            get { return _options.Timeout ?? TimeSpan.FromSeconds(15); }
        }

        public Result<WReferenceScoreResult> CalculateScore(
            WReferenceScoreData request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request, Namespaces);
                var uri = new Uri(_options.BaseUri, "");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "http://tempuri.org/INutritionalReferenceScore/CalculateScore",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                return ProcessReferenceScoreResult(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private Result<WReferenceScoreResult> ProcessReferenceScoreResult(
            SoapRequestResult result)
        {
            return ProcessResponse<ReferenceScoreResult,
                WReferenceScoreResult>(
                result,
                body => new WReferenceScoreResult(body));
        }

        private XmlSerializerNamespaces Namespaces
        {
            get
            {
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add("", "http://schemas.datacontract.org/2004/07/NRS.Service");

                return namespaces;
            }
        }
    }
}