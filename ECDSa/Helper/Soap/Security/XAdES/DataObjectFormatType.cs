using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("DataObjectFormat", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class DataObjectFormatType
    {
        private string descriptionField;

        private ObjectIdentifierType objectIdentifierField;

        private string mimeTypeField;

        private string encodingField;

        private string objectReferenceField;


        public string Description
        {
            get { return descriptionField; }
            set { descriptionField = value; }
        }


        public ObjectIdentifierType ObjectIdentifier
        {
            get { return objectIdentifierField; }
            set { objectIdentifierField = value; }
        }


        public string MimeType
        {
            get { return mimeTypeField; }
            set { mimeTypeField = value; }
        }


        [XmlElement(DataType = "anyURI")]
        public string Encoding
        {
            get { return encodingField; }
            set { encodingField = value; }
        }


        [XmlAttribute(DataType = "anyURI")]
        public string ObjectReference
        {
            get { return objectReferenceField; }
            set { objectReferenceField = value; }
        }
    }
}