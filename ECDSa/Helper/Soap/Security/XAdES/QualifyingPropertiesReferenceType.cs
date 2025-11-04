using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("QualifyingPropertiesReference", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class QualifyingPropertiesReferenceType
    {
        private string uRIField;

        private string idField;


        [XmlAttribute(DataType = "anyURI")]
        public string URI
        {
            get { return uRIField; }
            set { uRIField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}