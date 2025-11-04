using System;
using System.Xml;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap._1_1
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.SoapNs11)]
    [XmlRoot("Body", Namespace = XmlNamespaces.SoapNs11, IsNullable = false)]
    public class Body11
    {
        [XmlNamespaceDeclarations] 
        public XmlSerializerNamespaces Namespaces = new XmlSerializerNamespaces();

        public Body11()
        {
            Namespaces.Add("xsd", "http://www.w3.org/2001/XMLSchema");
            Namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        }

        [XmlElement(ElementName = "Fault", Namespace = XmlNamespaces.SoapNs11)]
        public Fault11? Fault { get; set; }

        [XmlAttribute("Id", Namespace = XmlNamespaces.WsSecurityUtilityNs)]
        public string? Id { get; set; }

        [XmlAnyElement]
        public XmlElement[] Payload { get; set; }
    }
}