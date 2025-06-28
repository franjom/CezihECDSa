using System;
using System.Security.Cryptography.X509Certificates;

namespace ECDSa.Helper.Soap
{
    public struct SoapOptions
    {
        public X509Certificate2 Certificate { get; set; }
        public string XmlString { get; set; }
        public string SoapAction { get; set; }
        public Uri Uri { get; set; }
        public Uri ReplyTo { get; set; }
        public bool IncludeTimestamp { get; set; }
        public Guid MessageId { get; set; }
    }
}