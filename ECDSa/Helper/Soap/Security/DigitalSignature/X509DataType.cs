using System;
using System.Xml.Serialization;
using ECDSa.Helper.Soap.Security.XAdES;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("X509Data", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class X509DataType
    {
        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;


        [XmlAnyElement]
        [XmlElement("X509CRL", typeof(byte[]), DataType = "base64Binary")]
        [XmlElement("X509Certificate", typeof(byte[]), DataType = "base64Binary")]
        [XmlElement("X509IssuerSerial", typeof(X509IssuerSerialType))]
        [XmlElement("X509SKI", typeof(byte[]), DataType = "base64Binary")]
        [XmlElement("X509SubjectName", typeof(string))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get { return itemsField; }
            set { itemsField = value; }
        }


        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType[] ItemsElementName
        {
            get { return itemsElementNameField; }
            set { itemsElementNameField = value; }
        }
    }
}