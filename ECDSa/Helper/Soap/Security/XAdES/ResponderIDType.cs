using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    public partial class ResponderIDType
    {
        private object itemField;


        [XmlElement("ByKey", typeof(byte[]), DataType = "base64Binary")]
        [XmlElement("ByName", typeof(string))]
        public object Item
        {
            get { return itemField; }
            set { itemField = value; }
        }
    }
}