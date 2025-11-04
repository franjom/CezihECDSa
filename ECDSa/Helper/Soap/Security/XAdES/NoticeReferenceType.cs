using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    public partial class NoticeReferenceType
    {
        private string organizationField;

        private string[] noticeNumbersField;


        public string Organization
        {
            get { return organizationField; }
            set { organizationField = value; }
        }


        [XmlArrayItem("int", DataType = "integer", IsNullable = false)]
        public string[] NoticeNumbers
        {
            get { return noticeNumbersField; }
            set { noticeNumbersField = value; }
        }
    }
}