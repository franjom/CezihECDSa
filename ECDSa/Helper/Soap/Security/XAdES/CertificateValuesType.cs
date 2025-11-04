using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("CertificateValues", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class CertificateValuesType
    {
        private object[] itemsField;

        private string idField;


        [XmlElement("EncapsulatedX509Certificate", typeof(EncapsulatedPKIDataType))]
        [XmlElement("OtherCertificate", typeof(AnyType))]
        public object[] Items
        {
            get { return itemsField; }
            set { itemsField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}