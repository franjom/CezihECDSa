using System;
using System.Xml.Serialization;
using ECDSa.Helper.Soap.Security.DigitalSignature;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    public partial class SignaturePolicyIdType
    {
        private ObjectIdentifierType sigPolicyIdField;

        private TransformType[] transformsField;

        private DigestAlgAndValueType sigPolicyHashField;

        private AnyType[] sigPolicyQualifiersField;


        public ObjectIdentifierType SigPolicyId
        {
            get { return sigPolicyIdField; }
            set { sigPolicyIdField = value; }
        }


        [XmlArray(Namespace = XmlNamespaces.XmlDsigNs)]
        [XmlArrayItem("Transform", IsNullable = false)]
        public TransformType[] Transforms
        {
            get { return transformsField; }
            set { transformsField = value; }
        }


        public DigestAlgAndValueType SigPolicyHash
        {
            get { return sigPolicyHashField; }
            set { sigPolicyHashField = value; }
        }


        [XmlArrayItem("SigPolicyQualifier", IsNullable = false)]
        public AnyType[] SigPolicyQualifiers
        {
            get { return sigPolicyQualifiersField; }
            set { sigPolicyQualifiersField = value; }
        }
    }
}