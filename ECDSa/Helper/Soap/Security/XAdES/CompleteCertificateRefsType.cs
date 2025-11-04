using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("CompleteCertificateRefs", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class CompleteCertificateRefsType
    {
        private CertIDType[] certRefsField;

        private string idField;


        [XmlArrayItem("Cert", IsNullable = false)]
        public CertIDType[] CertRefs
        {
            get { return certRefsField; }
            set { certRefsField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}