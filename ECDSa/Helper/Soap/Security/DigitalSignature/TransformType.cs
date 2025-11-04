using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("Transform", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class TransformType
    {
        private object[] itemsField;

        private string[] textField;

        private string algorithmField;


        [XmlAnyElement]
        [XmlElement("XPath", typeof(string))]
        public object[] Items
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
        public string Algorithm
        {
            get { return algorithmField; }
            set { algorithmField = value; }
        }
    }
}