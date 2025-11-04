using System.Security.Cryptography.Xml;

namespace ECDSa.Helper
{
    public static class SignatureAlgorithm
    {
        public const string XmlDsigECDSaSha256Url = "http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha256";
        public const string XmlDsigECDSaSha384Url = "http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha384";
        public const string XmlDsigECDSaSha512Url = "http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha512";
        public static string XmlDsigRSASHA1Url => SignedXml.XmlDsigRSASHA1Url;
        public static string XmlDsigRSASHA256Url => SignedXml.XmlDsigRSASHA256Url;
        public static string XmlDsigRSASHA384Url => SignedXml.XmlDsigRSASHA384Url;
        public static string XmlDsigRSASHA512Url => SignedXml.XmlDsigRSASHA512Url;

        public const string Sha256Ecdsa = "1.2.840.10045.4.3.2";
        public const string Sha384Ecdsa = "1.2.840.10045.4.3.3";
        public const string Sha512Ecdsa = "1.2.840.10045.4.3.4";

        public const string Sha1Rsa = "1.2.840.113549.1.1.5";
        public const string Sha256Rsa = "1.2.840.113549.1.1.11";
        public const string Sha384Rsa = "1.2.840.113549.1.1.12";
        public const string Sha512Rsa = "1.2.840.113549.1.1.13";
    }
}