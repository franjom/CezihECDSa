using System;
using System.Xml.Serialization;
using ECDSa.Helper.Soap.Security.DigitalSignature;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    public partial class DigestAlgAndValueType
    {
        private DigestMethodType digestMethodField;

        private byte[] digestValueField;


        [XmlElement(Namespace = XmlNamespaces.XmlDsigNs)]
        public DigestMethodType DigestMethod
        {
            get { return digestMethodField; }
            set { digestMethodField = value; }
        }


        [XmlElement(Namespace = XmlNamespaces.XmlDsigNs, DataType = "base64Binary")]
        public byte[] DigestValue
        {
            get { return digestValueField; }
            set { digestValueField = value; }
        }
    }
}