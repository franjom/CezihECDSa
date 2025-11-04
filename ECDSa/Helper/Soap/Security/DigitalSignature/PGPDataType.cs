using System;
using System.Xml.Serialization;
using ECDSa.Helper.Soap.Security.XAdES;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("PGPData", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class PGPDataType
    {
        private object[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;


        [XmlAnyElement]
        [XmlElement("PGPKeyID", typeof(byte[]), DataType = "base64Binary")]
        [XmlElement("PGPKeyPacket", typeof(byte[]), DataType = "base64Binary")]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get { return itemsField; }
            set { itemsField = value; }
        }


        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType1[] ItemsElementName
        {
            get { return itemsElementNameField; }
            set { itemsElementNameField = value; }
        }
    }
}