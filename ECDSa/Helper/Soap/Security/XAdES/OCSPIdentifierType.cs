using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    public partial class OCSPIdentifierType
    {
        private ResponderIDType responderIDField;

        private System.DateTime producedAtField;

        private string uRIField;


        public ResponderIDType ResponderID
        {
            get { return responderIDField; }
            set { responderIDField = value; }
        }


        public System.DateTime ProducedAt
        {
            get { return producedAtField; }
            set { producedAtField = value; }
        }


        [XmlAttribute(DataType = "anyURI")]
        public string URI
        {
            get { return uRIField; }
            set { uRIField = value; }
        }
    }
}