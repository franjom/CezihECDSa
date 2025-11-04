using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("SPUserNotice", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class SPUserNoticeType
    {
        private NoticeReferenceType noticeRefField;

        private string explicitTextField;


        public NoticeReferenceType NoticeRef
        {
            get { return noticeRefField; }
            set { noticeRefField = value; }
        }


        public string ExplicitText
        {
            get { return explicitTextField; }
            set { explicitTextField = value; }
        }
    }
}