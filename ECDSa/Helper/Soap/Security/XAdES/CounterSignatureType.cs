using System;
using System.Xml.Serialization;
using ECDSa.Helper.Soap.Security.DigitalSignature;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("CounterSignature", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class CounterSignatureType
    {
        private SignatureType signatureField;


        [XmlElement(Namespace = XmlNamespaces.XmlDsigNs)]
        public SignatureType Signature
        {
            get { return signatureField; }
            set { signatureField = value; }
        }
    }
}