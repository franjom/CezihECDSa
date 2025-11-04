using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("SignedSignatureProperties", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class SignedSignaturePropertiesType
    {
        private System.DateTime signingTimeField;

        private bool signingTimeFieldSpecified;

        private CertIDType[] signingCertificateField;

        private SignaturePolicyIdentifierType signaturePolicyIdentifierField;

        private SignatureProductionPlaceType signatureProductionPlaceField;

        private SignerRoleType signerRoleField;

        private string idField;


        public System.DateTime SigningTime
        {
            get { return signingTimeField; }
            set { signingTimeField = value; }
        }


        [XmlIgnore]
        public bool SigningTimeSpecified
        {
            get { return signingTimeFieldSpecified; }
            set { signingTimeFieldSpecified = value; }
        }


        [XmlArrayItem("Cert", IsNullable = false)]
        public CertIDType[] SigningCertificate
        {
            get { return signingCertificateField; }
            set { signingCertificateField = value; }
        }


        public SignaturePolicyIdentifierType SignaturePolicyIdentifier
        {
            get { return signaturePolicyIdentifierField; }
            set { signaturePolicyIdentifierField = value; }
        }


        public SignatureProductionPlaceType SignatureProductionPlace
        {
            get { return signatureProductionPlaceField; }
            set { signatureProductionPlaceField = value; }
        }


        public SignerRoleType SignerRole
        {
            get { return signerRoleField; }
            set { signerRoleField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}