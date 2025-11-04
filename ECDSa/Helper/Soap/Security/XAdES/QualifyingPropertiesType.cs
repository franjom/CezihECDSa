using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("QualifyingProperties", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class QualifyingPropertiesType
    {
        private SignedPropertiesType signedPropertiesField;

        private UnsignedPropertiesType unsignedPropertiesField;

        private string targetField;

        private string idField;


        public SignedPropertiesType SignedProperties
        {
            get { return signedPropertiesField; }
            set { signedPropertiesField = value; }
        }


        public UnsignedPropertiesType UnsignedProperties
        {
            get { return unsignedPropertiesField; }
            set { unsignedPropertiesField = value; }
        }


        [XmlAttribute(DataType = "anyURI")]
        public string Target
        {
            get { return targetField; }
            set { targetField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}