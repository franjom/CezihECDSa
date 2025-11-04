using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    public partial class CRLIdentifierType
    {
        private string issuerField;

        private System.DateTime issueTimeField;

        private string numberField;

        private string uRIField;


        public string Issuer
        {
            get { return issuerField; }
            set { issuerField = value; }
        }


        public System.DateTime IssueTime
        {
            get { return issueTimeField; }
            set { issueTimeField = value; }
        }


        [XmlElement(DataType = "integer")]
        public string Number
        {
            get { return numberField; }
            set { numberField = value; }
        }


        [XmlAttribute(DataType = "anyURI")]
        public string URI
        {
            get { return uRIField; }
            set { uRIField = value; }
        }
    }
}