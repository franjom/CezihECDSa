using CezihECDSa.SoapClients.PrijavaZarazne;
using CezihECDSa.Wsdl.PrijavaZarazne;
using CezihECDSa.Wsdl.PrijavaZarazneUpdate;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.Czo
{
    public interface ICzoClient
    {
        Result<DocumentRepository_RetrieveDocumentSetResponse> DocumentRepository_RetrieveDocumentSet(DocumentRepository_RetrieveDocumentSetRequest request);
    }

    public sealed class CzoClient : SoapClientBase, ICzoClient
    {
        private readonly CzoOptions _options;
        private readonly X509Certificate2 _cert;

        public CzoClient(CzoOptions options, X509Certificate2 cert) : base(SoapVersion.Soap12)
        {
            _options = options;
            _cert = cert;
        }

        protected override TimeSpan DefaultTimeout
        {
            get { return _options.Timeout ?? TimeSpan.FromSeconds(15); }
        }

        public Result<DocumentRepository_RetrieveDocumentSetResponse> DocumentRepository_RetrieveDocumentSet(
            DocumentRepository_RetrieveDocumentSetRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request.RetrieveDocumentSetRequest, Namespaces);
                var uri = new Uri(_options.BaseUri, "/WS/IHE/XDS_DocumentRegistry");

                var result = SendSignedRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "urn:ihe:iti:2007:RetrieveDocumentSet",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid()
                });

                return ProcessRetrieveDocumentSetResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private Result<DocumentRepository_RetrieveDocumentSetResponse> ProcessRetrieveDocumentSetResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<RetrieveDocumentSetResponseType,
                DocumentRepository_RetrieveDocumentSetResponse>(
                result,
                body => new DocumentRepository_RetrieveDocumentSetResponse(body));
        }

        private XmlSerializerNamespaces Namespaces
        {
            get
            {
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add("lcm", "urn:oasis:names:tc:ebxml-regrep:xsd:lcm:3.0");
                namespaces.Add("rim", "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0");
                namespaces.Add("rs", "urn:oasis:names:tc:ebxml-regrep:xsd:rs:3.0");
                namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

                return namespaces;
            }
        }
    }
}
