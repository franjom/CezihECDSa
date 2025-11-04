using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("OtherTimeStamp", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class OtherTimeStampType : GenericTimeStampType
    {
    }
}