using System.Security.Cryptography.Xml;
using System.Xml;

namespace ECDSa.Helper.Xml
{
    public class WsSignedXml : SignedXml
    {
        public WsSignedXml(XmlDocument doc) : base(doc)
        {
        }

        public override XmlElement GetIdElement(XmlDocument doc, string idValue)
        {
            var nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("wsu", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd");

            var el = doc.SelectSingleNode($"//*[@wsu:Id='{idValue}']", nsmgr) as XmlElement;
            return el ?? base.GetIdElement(doc, idValue);
        }
    }
}