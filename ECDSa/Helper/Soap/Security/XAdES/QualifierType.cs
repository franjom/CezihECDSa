using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    public enum QualifierType
    {
        OIDAsURI,


        OIDAsURN,
    }
}