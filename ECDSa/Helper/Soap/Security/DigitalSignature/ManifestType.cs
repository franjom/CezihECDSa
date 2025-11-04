using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("Manifest", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class ManifestType
    {
        private ReferenceType[] referenceField;

        private string idField;


        [XmlElement("Reference")]
        public ReferenceType[] Reference
        {
            get { return referenceField; }
            set { referenceField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}