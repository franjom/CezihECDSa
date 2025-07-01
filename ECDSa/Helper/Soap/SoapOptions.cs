using System;
using System.Security.Cryptography.X509Certificates;

namespace ECDSa.Helper.Soap
{
    /// <summary>
    /// Represents configuration options used for generating a SOAP message,
    /// including WS-Addressing and WS-Security headers.
    /// </summary>
    public struct SoapOptions
    {
        /// <summary>
        /// Gets or sets the X.509 certificate used to sign or secure the SOAP message.
        /// Optional. Required only if the SOAP header or body needs to be signed.
        /// </summary>
        public X509Certificate2 Certificate { get; set; }

        /// <summary>
        /// Gets or sets the raw XML payload to be included in the SOAP body.
        /// <b>Mandatory.</b> This is the actual business payload of the SOAP message.
        /// </summary>
        public string XmlString { get; set; }

        /// <summary>
        /// Gets or sets the SOAP action URI that indicates the intent of the SOAP message.
        /// <b>Mandatory.</b> Included in the WS-Addressing <c>Action</c> header.
        /// </summary>
        public string SoapAction { get; set; }

        /// <summary>
        /// Gets or sets the target endpoint URI of the SOAP service.
        /// <b>Mandatory.</b> Included in the WS-Addressing <c>To</c> header and HTTP request.
        /// </summary>
        public Uri Uri { get; set; }

        /// <summary>
        /// Gets or sets the address to which a reply should be sent.
        /// Optional. If not set, defaults to WS-Addressing <c>anonymous</c> address.
        /// </summary>
        public Uri ReplyTo { get; set; }

        /// <summary>
        /// Gets or sets the address of the final recipient of the message.
        /// Optional. If not set, <see cref="Uri"/> will be used as the <c>To</c> header.
        /// </summary>
        public Uri To { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a WS-Security timestamp should be included in the SOAP header.
        /// Optional. Recommended for message freshness and replay protection.
        /// </summary>
        public bool IncludeTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the unique message identifier (UUID) for the SOAP message.
        /// Optional but recommended. Included in the WS-Addressing <c>MessageID</c> header.
        /// </summary>
        public Guid MessageId { get; set; }
    }
}