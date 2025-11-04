using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs, IncludeInSchema = false)]
    public enum ItemsChoiceType
    {
        [XmlEnum("##any:")] Item,


        X509CRL,


        X509Certificate,


        X509IssuerSerial,


        X509SKI,


        X509SubjectName,
    }
}