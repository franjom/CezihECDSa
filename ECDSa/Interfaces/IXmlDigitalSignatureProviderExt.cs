using System.Xml;

namespace ECDSa.Interfaces
{
    public interface IXmlDigitalSignatureProviderExt
    {
        XmlDocument SignXml(XmlDocument doc, string part);
    }
}