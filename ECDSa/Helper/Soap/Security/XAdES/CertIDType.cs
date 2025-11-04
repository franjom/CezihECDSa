using System;
using System.Xml.Serialization;
using ECDSa.Helper.Soap.Security.DigitalSignature;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    public partial class CertIDType
    {
        private DigestAlgAndValueType certDigestField;

        private X509IssuerSerialType issuerSerialField;

        private string uRIField;


        public DigestAlgAndValueType CertDigest
        {
            get { return certDigestField; }
            set { certDigestField = value; }
        }


        public X509IssuerSerialType IssuerSerial
        {
            get { return issuerSerialField; }
            set { issuerSerialField = value; }
        }


        [XmlAttribute(DataType = "anyURI")]
        public string URI
        {
            get { return uRIField; }
            set { uRIField = value; }
        }
    }
}