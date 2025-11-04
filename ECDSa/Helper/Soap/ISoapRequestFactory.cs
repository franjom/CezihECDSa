using System.Net.Http;
using System.Xml;

namespace ECDSa.Helper.Soap
{
    public interface ISoapRequestFactory
    {
        HttpRequestMessage CreateSoapRequest(SoapOptions o);
        Result<XmlDocument> ProcessResponse(SoapRequestResult result);
    }
}