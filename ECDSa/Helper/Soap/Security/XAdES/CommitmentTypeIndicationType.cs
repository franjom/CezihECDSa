using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("CommitmentTypeIndication", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class CommitmentTypeIndicationType
    {
        private ObjectIdentifierType commitmentTypeIdField;

        private object[] itemsField;

        private AnyType[] commitmentTypeQualifiersField;


        public ObjectIdentifierType CommitmentTypeId
        {
            get { return commitmentTypeIdField; }
            set { commitmentTypeIdField = value; }
        }


        [XmlElement("AllSignedDataObjects", typeof(object))]
        [XmlElement("ObjectReference", typeof(string), DataType = "anyURI")]
        public object[] Items
        {
            get { return itemsField; }
            set { itemsField = value; }
        }


        [XmlArrayItem("CommitmentTypeQualifier", IsNullable = false)]
        public AnyType[] CommitmentTypeQualifiers
        {
            get { return commitmentTypeQualifiersField; }
            set { commitmentTypeQualifiersField = value; }
        }
    }
}