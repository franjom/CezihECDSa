using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("RSAKeyValue", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class RSAKeyValueType
    {
        private byte[] modulusField;

        private byte[] exponentField;


        [XmlElement(DataType = "base64Binary")]
        public byte[] Modulus
        {
            get { return modulusField; }
            set { modulusField = value; }
        }


        [XmlElement(DataType = "base64Binary")]
        public byte[] Exponent
        {
            get { return exponentField; }
            set { exponentField = value; }
        }
    }
}