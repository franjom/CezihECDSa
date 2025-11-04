using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("ArchiveTimeStampV2", Namespace = "http://uri.etsi.org/01903/v1.4.1#", IsNullable = false)]
    public partial class XAdESTimeStampType : GenericTimeStampType
    {
    }
}