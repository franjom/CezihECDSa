using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("SignedProperties", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class SignedPropertiesType
    {
        private SignedSignaturePropertiesType signedSignaturePropertiesField;

        private SignedDataObjectPropertiesType signedDataObjectPropertiesField;

        private string idField;


        public SignedSignaturePropertiesType SignedSignatureProperties
        {
            get { return signedSignaturePropertiesField; }
            set { signedSignaturePropertiesField = value; }
        }


        public SignedDataObjectPropertiesType SignedDataObjectProperties
        {
            get { return signedDataObjectPropertiesField; }
            set { signedDataObjectPropertiesField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}