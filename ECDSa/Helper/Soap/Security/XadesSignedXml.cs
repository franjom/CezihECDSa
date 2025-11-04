using System.Security.Cryptography.Xml;
using System.Xml;

namespace ECDSa.Helper.Soap.Security;

internal class XadesSignedXml : SignedXml
{
    public XadesSignedXml(XmlDocument doc) : base(doc)
    {
    }

    public override XmlElement? GetIdElement(XmlDocument? doc, string idValue)
    {
        var idElem = base.GetIdElement(doc, idValue);
        if (idElem != null)
        {
            return idElem;
        }

        var pfx = XmlNamespaces.Instance.GetPrefixByNamespace(XmlNamespaces.EtsiNs);

        foreach (DataObject obj in Signature.ObjectList)
        {
            foreach (XmlNode node in obj.Data)
            {
                var nsMgr = new XmlNamespaceManager(node.OwnerDocument!.NameTable);
                nsMgr.AddNamespace(pfx, XmlNamespaces.EtsiNs);

                var el = node.SelectSingleNode($"//{pfx}:*[@Id='{idValue}']", nsMgr) as XmlElement;
                if (el != null)
                {
                    return el;
                }
            }
        }

        return null;
    }
}