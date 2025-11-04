using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("DigestMethod", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class DigestMethodType
    {
        private System.Xml.XmlNode[] anyField;

        private string algorithmField;


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