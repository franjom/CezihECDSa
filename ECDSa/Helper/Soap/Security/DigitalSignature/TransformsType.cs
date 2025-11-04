using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("Transforms", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class TransformsType
    {
        private TransformType[] transformField;


        [XmlElement("Transform")]
        public TransformType[] Transform
        {
            get { return transformField; }
            set { transformField = value; }
        }
    }
}