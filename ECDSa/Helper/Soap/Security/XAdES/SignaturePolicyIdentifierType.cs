using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("SignaturePolicyIdentifier", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class SignaturePolicyIdentifierType
    {
        private object itemField;


        [XmlElement("SignaturePolicyId", typeof(SignaturePolicyIdType))]
        [XmlElement("SignaturePolicyImplied", typeof(object))]
        public object Item
        {
            get { return itemField; }
            set { itemField = value; }
        }
    }
}