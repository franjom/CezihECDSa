using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    public partial class OCSPRefType
    {
        private OCSPIdentifierType oCSPIdentifierField;

        private DigestAlgAndValueType digestAlgAndValueField;


        public OCSPIdentifierType OCSPIdentifier
        {
            get { return oCSPIdentifierField; }
            set { oCSPIdentifierField = value; }
        }


        public DigestAlgAndValueType DigestAlgAndValue
        {
            get { return digestAlgAndValueField; }
            set { digestAlgAndValueField = value; }
        }
    }
}