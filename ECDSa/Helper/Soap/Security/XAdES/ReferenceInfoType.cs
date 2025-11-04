using System;
using System.Xml.Serialization;
using ECDSa.Helper.Soap.Security.DigitalSignature;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("ReferenceInfo", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class ReferenceInfoType
    {
        private DigestMethodType digestMethodField;

        private byte[] digestValueField;

        private string idField;

        private string uRIField;


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


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }


        [XmlAttribute(DataType = "anyURI")]
        public string URI
        {
            get { return uRIField; }
            set { uRIField = value; }
        }
    }
}