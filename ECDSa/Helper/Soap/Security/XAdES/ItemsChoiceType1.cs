using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs, IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {
        [XmlEnum("##any:")] Item,


        PGPKeyID,


        PGPKeyPacket,
    }
}