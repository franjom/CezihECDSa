using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("RevocationValues", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class RevocationValuesType
    {
        private EncapsulatedPKIDataType[] cRLValuesField;

        private EncapsulatedPKIDataType[] oCSPValuesField;

        private AnyType[] otherValuesField;

        private string idField;


        [XmlArrayItem("EncapsulatedCRLValue", IsNullable = false)]
        public EncapsulatedPKIDataType[] CRLValues
        {
            get { return cRLValuesField; }
            set { cRLValuesField = value; }
        }


        [XmlArrayItem("EncapsulatedOCSPValue", IsNullable = false)]
        public EncapsulatedPKIDataType[] OCSPValues
        {
            get { return oCSPValuesField; }
            set { oCSPValuesField = value; }
        }


        [XmlArrayItem("OtherValue", IsNullable = false)]
        public AnyType[] OtherValues
        {
            get { return otherValuesField; }
            set { otherValuesField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}