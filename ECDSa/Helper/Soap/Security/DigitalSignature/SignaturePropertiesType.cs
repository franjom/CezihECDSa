using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("SignatureProperties", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class SignaturePropertiesType
    {
        private SignaturePropertyType[] signaturePropertyField;

        private string idField;


        [XmlElement("SignatureProperty")]
        public SignaturePropertyType[] SignatureProperty
        {
            get { return signaturePropertyField; }
            set { signaturePropertyField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}