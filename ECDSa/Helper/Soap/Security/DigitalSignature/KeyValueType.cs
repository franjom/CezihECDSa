using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("KeyValue", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class KeyValueType
    {
        private object itemField;

        private string[] textField;


        [XmlAnyElement]
        [XmlElement("DSAKeyValue", typeof(DSAKeyValueType))]
        [XmlElement("RSAKeyValue", typeof(RSAKeyValueType))]
        public object Item
        {
            get { return itemField; }
            set { itemField = value; }
        }


        [XmlText]
        public string[] Text
        {
            get { return textField; }
            set { textField = value; }
        }
    }
}