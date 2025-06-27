using CezihECDSa.Wsdl.PrijavaZarazne;
using CezihECDSa.Wsdl.PrijavaZarazneUpdate;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.PrijavaZarazne
{
    public interface DocumentRepository_PortType
    {
        // @formatter:off
        Result<DocumentRepository_RetrieveDocumentSetResponse> DocumentRepository_RetrieveDocumentSet(DocumentRepository_RetrieveDocumentSetRequest request);

        Task<Result<DocumentRepository_RetrieveDocumentSetResponse>> DocumentRepository_RetrieveDocumentSetAsync(DocumentRepository_RetrieveDocumentSetRequest request, CancellationToken ct = default);

        Result<DocumentRepository_ProvideAndRegisterDocumentSetbResponse> DocumentRepository_ProvideAndRegisterDocumentSetb(DocumentRepository_ProvideAndRegisterDocumentSetbRequest request);

        Task<Result<DocumentRepository_ProvideAndRegisterDocumentSetbResponse>> DocumentRepository_ProvideAndRegisterDocumentSetbAsync(DocumentRepository_ProvideAndRegisterDocumentSetbRequest request, CancellationToken ct = default);
        
        Result<DocumentRegistry_UpdateDocumentSetResponse> DocumentRegistry_UpdateDocumentSet(DocumentRegistry_UpdateDocumentSetRequest request);

        Task<Result<DocumentRegistry_UpdateDocumentSetResponse>> DocumentRegistry_UpdateDocumentSetAsync(DocumentRegistry_UpdateDocumentSetRequest request, CancellationToken ct = default);
        // @formatter:on
    }

    public sealed class PrijavaZarazneClient : SoapClientBase, DocumentRepository_PortType
    {
        private readonly PrijavaZarazneOptions _options;
        private readonly X509Certificate2 _cert;

        public PrijavaZarazneClient(PrijavaZarazneOptions options, X509Certificate2 cert) : base(SoapVersion.Soap12)
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

                var result = SendRequest(xml, "urn:ihe:iti:2007:RetrieveDocumentSet", _cert, uri);

                return ProcessRetrieveDocumentSetResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<DocumentRepository_RetrieveDocumentSetResponse>>
            DocumentRepository_RetrieveDocumentSetAsync(DocumentRepository_RetrieveDocumentSetRequest request,
                CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request.RetrieveDocumentSetRequest, Namespaces);
                var uri = new Uri(_options.BaseUri, "/WS/IHE/XDS_DocumentRegistry");

                var result = await SendRequestAsync(xml, "urn:ihe:iti:2007:RetrieveDocumentSet", _cert, uri, ct);

                return ProcessRetrieveDocumentSetResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }


        public Result<DocumentRepository_ProvideAndRegisterDocumentSetbResponse>
            DocumentRepository_ProvideAndRegisterDocumentSetb(
                DocumentRepository_ProvideAndRegisterDocumentSetbRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request.ProvideAndRegisterDocumentSetRequest, Namespaces);
                var uri = new Uri(_options.BaseUri, "/WS/IHE/XDS_DocumentRepository");

                var result = SendRequest(xml, "urn:ihe:iti:2007:ProvideAndRegisterDocumentSet-b", _cert, uri);

                return ProcessProvideAndRegisterResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<DocumentRepository_ProvideAndRegisterDocumentSetbResponse>>
            DocumentRepository_ProvideAndRegisterDocumentSetbAsync(
                DocumentRepository_ProvideAndRegisterDocumentSetbRequest request,
                CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request.ProvideAndRegisterDocumentSetRequest, Namespaces);
                var uri = new Uri(_options.BaseUri, "/WS/IHE/XDS_DocumentRepository");

                var result = await SendRequestAsync(xml, "urn:ihe:iti:2007:ProvideAndRegisterDocumentSet-b", _cert,
                    uri,
                    ct);

                return ProcessProvideAndRegisterResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public Result<DocumentRegistry_UpdateDocumentSetResponse> DocumentRegistry_UpdateDocumentSet(
            DocumentRegistry_UpdateDocumentSetRequest request)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request.SubmitObjectsRequest, Namespaces);
                var uri = new Uri(_options.BaseUri, "/WS/IHE/XDS_UpdateDocumentSet");

                var result = SendRequest(xml, "urn:ihe:iti:2010:UpdateDocumentSet", _cert, uri);

                return ProcessUpdateDocumentSetResponse(result);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public async Task<Result<DocumentRegistry_UpdateDocumentSetResponse>> DocumentRegistry_UpdateDocumentSetAsync(
            DocumentRegistry_UpdateDocumentSetRequest request,
            CancellationToken ct = default)
        {
            try
            {
                var xml = SoapSerializer.Instance.Serialize(request.SubmitObjectsRequest, Namespaces);
                var uri = new Uri(_options.BaseUri, "/WS/IHE/XDS_UpdateDocumentSet");

                var result = await SendRequestAsync(xml, "urn:ihe:iti:2010:UpdateDocumentSet", _cert, uri, ct);

                return ProcessUpdateDocumentSetResponse(result);
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

        private Result<DocumentRepository_ProvideAndRegisterDocumentSetbResponse> ProcessProvideAndRegisterResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<Wsdl.PrijavaZarazne.RegistryResponseType,
                DocumentRepository_ProvideAndRegisterDocumentSetbResponse>(
                result,
                body => new DocumentRepository_ProvideAndRegisterDocumentSetbResponse(body));
        }

        private Result<DocumentRegistry_UpdateDocumentSetResponse> ProcessUpdateDocumentSetResponse(
            SoapRequestResult result)
        {
            return ProcessResponse<Wsdl.PrijavaZarazneUpdate.RegistryResponseType,
                DocumentRegistry_UpdateDocumentSetResponse>(
                result,
                body => new DocumentRegistry_UpdateDocumentSetResponse(body));
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