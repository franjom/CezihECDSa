using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("UnsignedDataObjectProperties", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class UnsignedDataObjectPropertiesType
    {
        private AnyType[] unsignedDataObjectPropertyField;

        private string idField;


        [XmlElement("UnsignedDataObjectProperty")]
        public AnyType[] UnsignedDataObjectProperty
        {
            get { return unsignedDataObjectPropertyField; }
            set { unsignedDataObjectPropertyField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}