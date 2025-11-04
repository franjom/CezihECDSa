using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("EncapsulatedPKIData", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class EncapsulatedPKIDataType
    {
        private string idField;

        private string encodingField;

        private byte[] valueField;


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }


        [XmlAttribute(DataType = "anyURI")]
        public string Encoding
        {
            get { return encodingField; }
            set { encodingField = value; }
        }


        [XmlText(DataType = "base64Binary")]
        public byte[] Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
    }
}