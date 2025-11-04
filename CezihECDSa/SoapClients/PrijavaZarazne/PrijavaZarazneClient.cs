using CezihECDSa.Wsdl.PrijavaZarazne;
using CezihECDSa.Wsdl.PrijavaZarazneUpdate;
using ECDSa.Helper;
using ECDSa.Helper.Soap;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
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

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "urn:ihe:iti:2007:RetrieveDocumentSet",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
                });

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

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "urn:ihe:iti:2007:RetrieveDocumentSet",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
                }, ct);

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

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "urn:ihe:iti:2007:ProvideAndRegisterDocumentSet-b",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
                });

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

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "urn:ihe:iti:2007:ProvideAndRegisterDocumentSet-b",
                    IncludeTimestamp = true,
                    Uri = uri,
                    MessageId = Guid.NewGuid(),
                    SignEnvelope = true
                }, ct);

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

                var result = SendRequest(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "urn:ihe:iti:2007:UpdateDocumentSet",
                    IncludeTimestamp = true,
                    Uri = uri,
                    SignEnvelope = true
                });

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

                var result = await SendRequestAsync(new SoapOptions
                {
                    XmlString = xml,
                    Certificate = _cert,
                    SoapAction = "urn:ihe:iti:2007:UpdateDocumentSet",
                    IncludeTimestamp = true,
                    Uri = uri,
                    SignEnvelope = true
                }, ct);

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
            var soapBody = ProcessResponse(result);

            var body = SoapSerializer.Instance.Deserialize<RetrieveDocumentSetResponseType>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName,
                new XmlQualifiedName("", "urn:ihe:iti:xds-b:2007"));

            return new DocumentRepository_RetrieveDocumentSetResponse(body);
        }

        private Result<DocumentRepository_ProvideAndRegisterDocumentSetbResponse> ProcessProvideAndRegisterResponse(
            SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var body = SoapSerializer.Instance.Deserialize<Wsdl.PrijavaZarazne.RegistryResponseType>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName,
                new XmlQualifiedName("", "urn:oasis:names:tc:ebxml-regrep:xsd:rs:3.0"));

            return new DocumentRepository_ProvideAndRegisterDocumentSetbResponse(body);
        }

        private Result<DocumentRegistry_UpdateDocumentSetResponse> ProcessUpdateDocumentSetResponse(
            SoapRequestResult result)
        {
            var soapBody = ProcessResponse(result);

            var body = SoapSerializer.Instance.Deserialize<Wsdl.PrijavaZarazneUpdate.RegistryResponseType>(
                soapBody.Value, soapBody.Value.DocumentElement.LocalName,
                new XmlQualifiedName("", "urn:oasis:names:tc:ebxml-regrep:xsd:rs:3.0"));

            return new DocumentRegistry_UpdateDocumentSetResponse(body);
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