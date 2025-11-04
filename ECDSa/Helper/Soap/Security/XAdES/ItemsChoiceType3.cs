using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs, IncludeInSchema = false)]
    public enum ItemsChoiceType3
    {
        [XmlEnum("##any:")] Item,


        ArchiveTimeStamp,


        AttrAuthoritiesCertValues,


        AttributeCertificateRefs,


        AttributeRevocationRefs,


        AttributeRevocationValues,


        CertificateValues,


        CompleteCertificateRefs,


        CompleteRevocationRefs,


        CounterSignature,


        RefsOnlyTimeStamp,


        RevocationValues,


        SigAndRefsTimeStamp,


        SignatureTimeStamp,
    }
}