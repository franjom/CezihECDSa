using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("Reference", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class ReferenceType
    {
        private TransformType[] transformsField;

        private DigestMethodType digestMethodField;

        private byte[] digestValueField;

        private string idField;

        private string uRIField;

        private string typeField;


        [XmlArrayItem("Transform", IsNullable = false)]
        public TransformType[] Transforms
        {
            get { return transformsField; }
            set { transformsField = value; }
        }


        public DigestMethodType DigestMethod
        {
            get { return digestMethodField; }
            set { digestMethodField = value; }
        }


        [XmlElement(DataType = "base64Binary")]
        public byte[] DigestValue
        {
            get { return digestValueField; }
            set { digestValueField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }


        [XmlAttribute(DataType = "anyURI")]
        public string URI
        {
            get { return uRIField; }
            set { uRIField = value; }
        }


        [XmlAttribute(DataType = "anyURI")]
        public string Type
        {
            get { return typeField; }
            set { typeField = value; }
        }
    }
}