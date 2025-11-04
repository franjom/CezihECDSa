using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("SignatureProperty", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class SignaturePropertyType
    {
        private System.Xml.XmlElement[] itemsField;

        private string[] textField;

        private string targetField;

        private string idField;


        [XmlAnyElement]
        public System.Xml.XmlElement[] Items
        {
            get { return itemsField; }
            set { itemsField = value; }
        }


        [XmlText]
        public string[] Text
        {
            get { return textField; }
            set { textField = value; }
        }


        [XmlAttribute(DataType = "anyURI")]
        public string Target
        {
            get { return targetField; }
            set { targetField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}