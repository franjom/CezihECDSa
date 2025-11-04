using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("Signature", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class SignatureType
    {
        private SignedInfoType signedInfoField;

        private SignatureValueType signatureValueField;

        private KeyInfoType keyInfoField;

        private ObjectType[] objectField;

        private string idField;


        public SignedInfoType SignedInfo
        {
            get { return signedInfoField; }
            set { signedInfoField = value; }
        }


        public SignatureValueType SignatureValue
        {
            get { return signatureValueField; }
            set { signatureValueField = value; }
        }


        public KeyInfoType KeyInfo
        {
            get { return keyInfoField; }
            set { keyInfoField = value; }
        }


        [XmlElement("Object")]
        public ObjectType[] Object
        {
            get { return objectField; }
            set { objectField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}