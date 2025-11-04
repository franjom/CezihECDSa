using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    public partial class DocumentationReferencesType
    {
        private string[] documentationReferenceField;


        [XmlElement("DocumentationReference", DataType = "anyURI")]
        public string[] DocumentationReference
        {
            get { return documentationReferenceField; }
            set { documentationReferenceField = value; }
        }
    }
}