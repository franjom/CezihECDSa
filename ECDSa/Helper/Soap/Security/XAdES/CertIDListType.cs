using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("SigningCertificate", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class CertIDListType
    {
        private CertIDType[] certField;


        [XmlElement("Cert")]
        public CertIDType[] Cert
        {
            get { return certField; }
            set { certField = value; }
        }
    }
}