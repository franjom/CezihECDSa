using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    public partial class X509IssuerSerialType
    {
        private string x509IssuerNameField;

        private string x509SerialNumberField;


        public string X509IssuerName
        {
            get { return x509IssuerNameField; }
            set { x509IssuerNameField = value; }
        }


        [XmlElement(DataType = "integer")]
        public string X509SerialNumber
        {
            get { return x509SerialNumberField; }
            set { x509SerialNumberField = value; }
        }
    }
}