using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("UnsignedProperties", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class UnsignedPropertiesType
    {
        private UnsignedSignaturePropertiesType unsignedSignaturePropertiesField;

        private UnsignedDataObjectPropertiesType unsignedDataObjectPropertiesField;

        private string idField;


        public UnsignedSignaturePropertiesType UnsignedSignatureProperties
        {
            get { return unsignedSignaturePropertiesField; }
            set { unsignedSignaturePropertiesField = value; }
        }


        public UnsignedDataObjectPropertiesType UnsignedDataObjectProperties
        {
            get { return unsignedDataObjectPropertiesField; }
            set { unsignedDataObjectPropertiesField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}