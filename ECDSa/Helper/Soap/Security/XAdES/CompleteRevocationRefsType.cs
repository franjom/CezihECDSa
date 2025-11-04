using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("CompleteRevocationRefs", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class CompleteRevocationRefsType
    {
        private CRLRefType[] cRLRefsField;

        private OCSPRefType[] oCSPRefsField;

        private AnyType[] otherRefsField;

        private string idField;


        [XmlArrayItem("CRLRef", IsNullable = false)]
        public CRLRefType[] CRLRefs
        {
            get { return cRLRefsField; }
            set { cRLRefsField = value; }
        }


        [XmlArrayItem("OCSPRef", IsNullable = false)]
        public OCSPRefType[] OCSPRefs
        {
            get { return oCSPRefsField; }
            set { oCSPRefsField = value; }
        }


        [XmlArrayItem("OtherRef", IsNullable = false)]
        public AnyType[] OtherRefs
        {
            get { return otherRefsField; }
            set { otherRefsField = value; }
        }


        [XmlAttribute(DataType = "ID")]
        public string Id
        {
            get { return idField; }
            set { idField = value; }
        }
    }
}