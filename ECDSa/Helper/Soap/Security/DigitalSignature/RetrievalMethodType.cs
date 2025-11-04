using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("RetrievalMethod", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class RetrievalMethodType
    {
        private TransformType[] transformsField;

        private string uRIField;

        private string typeField;


        [XmlArrayItem("Transform", IsNullable = false)]
        public TransformType[] Transforms
        {
            get { return transformsField; }
            set { transformsField = value; }
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