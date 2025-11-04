using System;
using System.Xml.Serialization;
using ECDSa.Helper.Soap.Security.DigitalSignature;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [XmlInclude(typeof(OtherTimeStampType))]
    [XmlInclude(typeof(XAdESTimeStampType))]
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    public abstract partial class GenericTimeStampType
    {
        private object[] itemsField;

        private CanonicalizationMethodType canonicalizationMethodField;

        private object[] items1Field;

        private string idField;


        [XmlElement("Include", typeof(IncludeType))]
        [XmlElement("ReferenceInfo", typeof(ReferenceInfoType))]
        public object[] Items
        {
            get { return itemsField; }
            set { itemsField = value; }
        }


        [XmlElement(Namespace = XmlNamespaces.XmlDsigNs)]
        public CanonicalizationMethodType CanonicalizationMethod
        {
            get { return canonicalizationMethodField; }
            set { canonicalizationMethodField = value; }
        }


        [XmlElement("EncapsulatedTimeStamp", typeof(EncapsulatedPKIDataType))]
        [XmlElement("XMLTimeStamp", typeof(AnyType))]
        public object[] Items1
        {
            get { return items1Field; }
            set { items1Field = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}