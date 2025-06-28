using CezihECDSa.SoapClients.Cezdlih.Wrappers;
using CezihECDSa.Wsdl;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Cezdlih
{
    public interface ICezdlihClient
    {
        Result<PreuzimanjePlanaImunizacijeResponse> PreuzimanjePlanaImunizacije(
            PreuzimanjePlanaImunizacijeRequest request);
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

                var response = ProcessRetrieveDocumentSetResponse(result);

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

        private Result<PreuzimanjePlanaImunizacijeResponse> ProcessRetrieveDocumentSetResponse(SoapRequestResult result)
        {
            return ProcessResponse<WPreuzimanjePlanaImunizacijeResponse,
                PreuzimanjePlanaImunizacijeResponse>(
                result,
                response => new PreuzimanjePlanaImunizacijeResponse(response.Result));
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