using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("SignatureValue", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class SignatureValueType
    {
        private string idField;

        private byte[] valueField;


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }


        [XmlText(DataType = "base64Binary")]
        public byte[] Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
    }
}