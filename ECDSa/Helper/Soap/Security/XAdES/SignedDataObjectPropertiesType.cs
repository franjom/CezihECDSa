using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("SignedDataObjectProperties", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class SignedDataObjectPropertiesType
    {
        private DataObjectFormatType[] dataObjectFormatField;

        private CommitmentTypeIndicationType[] commitmentTypeIndicationField;

        private XAdESTimeStampType[] allDataObjectsTimeStampField;

        private XAdESTimeStampType[] individualDataObjectsTimeStampField;

        private string idField;


        [XmlElement("DataObjectFormat")]
        public DataObjectFormatType[] DataObjectFormat
        {
            get { return dataObjectFormatField; }
            set { dataObjectFormatField = value; }
        }


        [XmlElement("CommitmentTypeIndication")]
        public CommitmentTypeIndicationType[] CommitmentTypeIndication
        {
            get { return commitmentTypeIndicationField; }
            set { commitmentTypeIndicationField = value; }
        }


        [XmlElement("AllDataObjectsTimeStamp")]
        public XAdESTimeStampType[] AllDataObjectsTimeStamp
        {
            get { return allDataObjectsTimeStampField; }
            set { allDataObjectsTimeStampField = value; }
        }


        [XmlElement("IndividualDataObjectsTimeStamp")]
        public XAdESTimeStampType[] IndividualDataObjectsTimeStamp
        {
            get { return individualDataObjectsTimeStampField; }
            set { individualDataObjectsTimeStampField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}