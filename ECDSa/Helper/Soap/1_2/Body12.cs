using System;
using System.Xml;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_2
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.SoapNs12)]
    [XmlRoot("Body", Namespace = XmlNamespaces.SoapNs12, IsNullable = false)]
    public class Body12
    {
        [XmlNamespaceDeclarations] 
        public XmlSerializerNamespaces Namespaces = new XmlSerializerNamespaces();

        public Body12()
        {
            Namespaces.Add("xsd", "http://www.w3.org/2001/XMLSchema");
            Namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        }

        [XmlElement(ElementName = "Fault", Namespace = XmlNamespaces.SoapNs12)]
        public Fault12 Fault { get; set; }

        [XmlAttribute("Id", Namespace = XmlNamespaces.WsSecurityUtilityNs)]
        public string? Id { get; set; }

        [XmlAnyElement]
        public XmlElement[] Payload { get; set; }
    }
}