using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("Any", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class AnyType
    {
        private System.Xml.XmlNode[] anyField;

        private System.Xml.XmlAttribute[] anyAttrField;


        [XmlText]
        [XmlAnyElement]
        public System.Xml.XmlNode[] Any
        {
            get { return anyField; }
            set { anyField = value; }
        }


        [XmlAnyAttribute]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get { return anyAttrField; }
            set { anyAttrField = value; }
        }
    }
}