using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    public partial class IdentifierType
    {
        private QualifierType qualifierField;

        private bool qualifierFieldSpecified;

        private string valueField;


        [XmlAttribute]
        public QualifierType Qualifier
        {
            get { return qualifierField; }
            set { qualifierField = value; }
        }


        [XmlIgnore]
        public bool QualifierSpecified
        {
            get { return qualifierFieldSpecified; }
            set { qualifierFieldSpecified = value; }
        }


        [XmlText(DataType = "anyURI")]
        public string Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
    }
}