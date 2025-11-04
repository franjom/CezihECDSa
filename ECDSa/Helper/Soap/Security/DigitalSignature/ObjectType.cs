using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("Object", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class ObjectType
    {
        private System.Xml.XmlNode[] anyField;

        private string idField;

        private string mimeTypeField;

        private string encodingField;


        [XmlText]
        [XmlAnyElement]
        public System.Xml.XmlNode[] Any
        {
            get { return anyField; }
            set { anyField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }


        [XmlAttribute]
        public string MimeType
        {
            get { return mimeTypeField; }
            set { mimeTypeField = value; }
        }


        [XmlAttribute(DataType = "anyURI")]
        public string Encoding
        {
            get { return encodingField; }
            set { encodingField = value; }
        }
    }
}