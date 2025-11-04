using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Shared
{
    [Serializable]
    [XmlRoot("Timestamp", Namespace = XmlNamespaces.WsSecurityUtilityNs)]
    public sealed class SoapTimestamp : IXmlSerializable
    {
        public SoapTimestamp()
        {
            //Created = XmlConvert.ToString(DateTime.UtcNow, XmlDateTimeSerializationMode.Utc);
            //Expires = XmlConvert.ToString(DateTime.UtcNow.AddMinutes(5), XmlDateTimeSerializationMode.Utc);
            Created = DateTime.UtcNow.ToString("yyyy-MM-dd'T'HH:mm:ss.fff'Z'");
            Expires = DateTime.UtcNow.AddMinutes(5).ToString("yyyy-MM-dd'T'HH:mm:ss.fff'Z'");
        }

        [XmlAttribute("Id", Namespace = XmlNamespaces.WsSecurityUtilityNs)]
        public string Id { get; set; } = "_0";

        [XmlElement("Created", Namespace = XmlNamespaces.WsSecurityUtilityNs)]
        public string Created { get; set; }

        [XmlElement("Expires", Namespace = XmlNamespaces.WsSecurityUtilityNs)]
        public string Expires { get; set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            Id = reader.GetAttribute("Id", XmlNamespaces.WsSecurityUtilityNs);
            reader.ReadStartElement();
            Created = reader.ReadElementString("Created", XmlNamespaces.WsSecurityUtilityNs);
            Expires = reader.ReadElementString("Expires", XmlNamespaces.WsSecurityUtilityNs);
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            var pfx = XmlNamespaces.Instance.GetPrefixByNamespace(XmlNamespaces.WsSecurityUtilityNs);

            writer.WriteAttributeString(pfx, "Id", XmlNamespaces.WsSecurityUtilityNs, Id);
            writer.WriteElementString(pfx, "Created", XmlNamespaces.WsSecurityUtilityNs, Created);
            writer.WriteElementString(pfx, "Expires", XmlNamespaces.WsSecurityUtilityNs, Expires);
        }
    }
}