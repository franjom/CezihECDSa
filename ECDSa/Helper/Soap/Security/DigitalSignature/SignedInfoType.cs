using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("SignedInfo", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class SignedInfoType
    {
        private CanonicalizationMethodType canonicalizationMethodField;

        private SignatureMethodType signatureMethodField;

        private ReferenceType[] referenceField;

        private string idField;


        public CanonicalizationMethodType CanonicalizationMethod
        {
            get { return canonicalizationMethodField; }
            set { canonicalizationMethodField = value; }
        }


        public SignatureMethodType SignatureMethod
        {
            get { return signatureMethodField; }
            set { signatureMethodField = value; }
        }


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