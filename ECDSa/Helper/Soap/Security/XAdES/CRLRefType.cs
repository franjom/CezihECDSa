using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    public partial class CRLRefType
    {
        private DigestAlgAndValueType digestAlgAndValueField;

        private CRLIdentifierType cRLIdentifierField;


        public DigestAlgAndValueType DigestAlgAndValue
        {
            get { return digestAlgAndValueField; }
            set { digestAlgAndValueField = value; }
        }


        public CRLIdentifierType CRLIdentifier
        {
            get { return cRLIdentifierField; }
            set { cRLIdentifierField = value; }
        }
    }
}