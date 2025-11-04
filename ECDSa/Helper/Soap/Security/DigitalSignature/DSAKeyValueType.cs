using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("DSAKeyValue", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class DSAKeyValueType
    {
        private byte[] pField;

        private byte[] qField;

        private byte[] gField;

        private byte[] yField;

        private byte[] jField;

        private byte[] seedField;

        private byte[] pgenCounterField;


        [XmlElement(DataType = "base64Binary")]
        public byte[] P
        {
            get { return pField; }
            set { pField = value; }
        }


        [XmlElement(DataType = "base64Binary")]
        public byte[] Q
        {
            get { return qField; }
            set { qField = value; }
        }


        [XmlElement(DataType = "base64Binary")]
        public byte[] G
        {
            get { return gField; }
            set { gField = value; }
        }


        [XmlElement(DataType = "base64Binary")]
        public byte[] Y
        {
            get { return yField; }
            set { yField = value; }
        }


        [XmlElement(DataType = "base64Binary")]
        public byte[] J
        {
            get { return jField; }
            set { jField = value; }
        }


        [XmlElement(DataType = "base64Binary")]
        public byte[] Seed
        {
            get { return seedField; }
            set { seedField = value; }
        }


        [XmlElement(DataType = "base64Binary")]
        public byte[] PgenCounter
        {
            get { return pgenCounterField; }
            set { pgenCounterField = value; }
        }
    }
}