using System;
using System.Collections.Concurrent;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap
{
    public sealed class SoapSerializer
    {
        private sealed class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding => Utf8NoBom;
        }

        private static readonly Lazy<SoapSerializer> _instance = new Lazy<SoapSerializer>(() => new SoapSerializer());

        public static SoapSerializer Instance => _instance.Value;

        private static readonly Encoding Utf8NoBom = new UTF8Encoding(false);

        private readonly ConcurrentDictionary<(Type, string?, string?), XmlSerializer> _serializerCache = new();

        private SoapSerializer()
        {
        }

        public string Serialize<T>(T obj)
        {
            return Serialize(obj, null);
        }

        public string Serialize<T>(T obj, XmlSerializerNamespaces? namespaces = null, string? rootName = null,
            XmlQualifiedName? rootNs = null, bool omitXmlDeclaration = false, bool indent = false)
        {
            var serializer = GetOrCreateSerializer(typeof(T), rootName, rootNs);

            using var stringWriter = new Utf8StringWriter();
            using var writer = XmlWriter.Create(stringWriter, new XmlWriterSettings
            {
                Encoding = Utf8NoBom,
                OmitXmlDeclaration = omitXmlDeclaration,
                Indent = indent,
            });

            namespaces ??= new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });

            serializer.Serialize(writer, obj, namespaces);
            return stringWriter.ToString();
        }

        public T Deserialize<T>(XmlDocument bodyDoc, string? rootName = null, XmlQualifiedName? rootNs = null)
        {
            var serializer = GetOrCreateSerializer(typeof(T), rootName, rootNs);
            using var reader = new XmlNodeReader(bodyDoc);
            return (T)serializer.Deserialize(reader);
        }

        public T? Deserialize<T>(string xml, string? rootName = null, XmlQualifiedName? rootNs = null)
        {
            if (string.IsNullOrWhiteSpace(xml))
            {
                return default;
            }

            var serializer = GetOrCreateSerializer(typeof(T), rootName, rootNs);
            using var reader = new StringReader(xml);
            return (T)serializer.Deserialize(reader);
        }

        private XmlSerializer GetOrCreateSerializer(Type type, string? rootName, XmlQualifiedName? rootNs)
        {
            var key = (type, rootName, rootNs?.Namespace);

            return _serializerCache.GetOrAdd(key, _ =>
            {
                if (string.IsNullOrEmpty(rootName))
                {
                    return new XmlSerializer(type);
                }

                var overrides = new XmlAttributeOverrides();
                var attrs = new XmlAttributes
                {
                    XmlRoot = new XmlRootAttribute(rootName)
                    {
                        Namespace = rootNs?.Namespace ?? string.Empty
                    }
                };
                overrides.Add(type, attrs);
                return new XmlSerializer(type, overrides);
            });
        }
    }
}