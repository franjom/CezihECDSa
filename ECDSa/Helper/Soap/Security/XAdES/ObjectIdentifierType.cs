using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("ObjectIdentifier", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class ObjectIdentifierType
    {
        private IdentifierType identifierField;

        private string descriptionField;

        private DocumentationReferencesType documentationReferencesField;


        public IdentifierType Identifier
        {
            get { return identifierField; }
            set { identifierField = value; }
        }


        public string Description
        {
            get { return descriptionField; }
            set { descriptionField = value; }
        }


        public DocumentationReferencesType DocumentationReferences
        {
            get { return documentationReferencesField; }
            set { documentationReferencesField = value; }
        }
    }
}