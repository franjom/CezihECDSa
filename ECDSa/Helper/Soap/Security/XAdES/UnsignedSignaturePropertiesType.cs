using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("UnsignedSignatureProperties", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class UnsignedSignaturePropertiesType
    {
        private object[] itemsField;

        private ItemsChoiceType3[] itemsElementNameField;

        private string idField;


        [XmlAnyElement]
        [XmlElement("ArchiveTimeStamp", typeof(XAdESTimeStampType))]
        [XmlElement("AttrAuthoritiesCertValues", typeof(CertificateValuesType))]
        [XmlElement("AttributeCertificateRefs", typeof(CompleteCertificateRefsType))]
        [XmlElement("AttributeRevocationRefs", typeof(CompleteRevocationRefsType))]
        [XmlElement("AttributeRevocationValues", typeof(RevocationValuesType))]
        [XmlElement("CertificateValues", typeof(CertificateValuesType))]
        [XmlElement("CompleteCertificateRefs", typeof(CompleteCertificateRefsType))]
        [XmlElement("CompleteRevocationRefs", typeof(CompleteRevocationRefsType))]
        [XmlElement("CounterSignature", typeof(CounterSignatureType))]
        [XmlElement("RefsOnlyTimeStamp", typeof(XAdESTimeStampType))]
        [XmlElement("RevocationValues", typeof(RevocationValuesType))]
        [XmlElement("SigAndRefsTimeStamp", typeof(XAdESTimeStampType))]
        [XmlElement("SignatureTimeStamp", typeof(XAdESTimeStampType))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get { return itemsField; }
            set { itemsField = value; }
        }


        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType3[] ItemsElementName
        {
            get { return itemsElementNameField; }
            set { itemsElementNameField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}