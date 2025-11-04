using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.DigitalSignature
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.XmlDsigNs)]
    [XmlRoot("SPKIData", Namespace = XmlNamespaces.XmlDsigNs, IsNullable = false)]
    public partial class SPKIDataType
    {
        private byte[][] sPKISexpField;

        private System.Xml.XmlElement anyField;


        [XmlElement("SPKISexp", DataType = "base64Binary")]
        public byte[][] SPKISexp
        {
            get { return sPKISexpField; }
            set { sPKISexpField = value; }
        }


        [XmlAnyElement]
        public System.Xml.XmlElement Any
        {
            get { return anyField; }
            set { anyField = value; }
        }
    }
}