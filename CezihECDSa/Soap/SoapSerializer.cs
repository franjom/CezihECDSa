using System;
using System.Collections.Concurrent;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CezihECDSa.Soap
{
    internal sealed class SoapSerializer
    {
        private static readonly Lazy<SoapSerializer> _instance = new Lazy<SoapSerializer>(() => new SoapSerializer());

        public static SoapSerializer Instance => _instance.Value;

        private readonly ConcurrentDictionary<Type, XmlSerializer> _cache =
            new ConcurrentDictionary<Type, XmlSerializer>();

        private SoapSerializer()
        {
        }

        public string Serialize<T>(T obj, XmlSerializerNamespaces namespaces = null)
        {
            var type = typeof(T);
            var serializer = _cache.GetOrAdd(type, t => new XmlSerializer(t));

            using (var memoryStream = new MemoryStream())
            {
                using (var writer = XmlWriter.Create(memoryStream, new XmlWriterSettings
                       {
                           Encoding = Encoding.UTF8
                       }))
                {
                    serializer.Serialize(writer, obj, namespaces);
                    return Encoding.UTF8.GetString(memoryStream.ToArray());
                }
            }
        }

        public T Deserialize<T>(XmlDocument bodyDoc)
        {
            var type = typeof(T);
            var serializer = _cache.GetOrAdd(type, t => new XmlSerializer(t));

            using (XmlReader reader = new XmlNodeReader(bodyDoc))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}