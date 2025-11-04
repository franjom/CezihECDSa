using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs, IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {
        [XmlEnum("##any:")] Item,


        KeyName,


        KeyValue,


        MgmtData,


        PGPData,


        RetrievalMethod,


        SPKIData,


        X509Data,
    }
}