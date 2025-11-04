using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("Include", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class IncludeType
    {
        private string uRIField;

        private bool referencedDataField;

        private bool referencedDataFieldSpecified;


        [XmlAttribute(DataType = "anyURI")]
        public string URI
        {
            get { return uRIField; }
            set { uRIField = value; }
        }


        [XmlAttribute]
        public bool referencedData
        {
            get { return referencedDataField; }
            set { referencedDataField = value; }
        }


        [XmlIgnore]
        public bool referencedDataSpecified
        {
            get { return referencedDataFieldSpecified; }
            set { referencedDataFieldSpecified = value; }
        }
    }
}