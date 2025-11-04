using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("SignatureMethod", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class SignatureMethodType
    {
        private string hMACOutputLengthField;

        private System.Xml.XmlNode[] anyField;

        private string algorithmField;


        [XmlElement(DataType = "integer")]
        public string HMACOutputLength
        {
            get { return hMACOutputLengthField; }
            set { hMACOutputLengthField = value; }
        }


        [XmlText]
        [XmlAnyElement]
        public System.Xml.XmlNode[] Any
        {
            get { return anyField; }
            set { anyField = value; }
        }


        [XmlAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get { return algorithmField; }
            set { algorithmField = value; }
        }
    }
}