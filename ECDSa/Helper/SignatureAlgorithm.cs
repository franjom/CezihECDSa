using System.Security.Cryptography.Xml;

namespace ECDSa.Helper
{
    public static class SignatureAlgorithm
    {
        public const string XmlDsigECDSaSha384Url = "http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha384";
        public static string XmlDsigRSASHA1Url => SignedXml.XmlDsigRSASHA1Url;
        public static string XmlDsigRSASHA256Url => SignedXml.XmlDsigRSASHA256Url;
        public static string XmlDsigRSASHA384Url => SignedXml.XmlDsigRSASHA384Url;


        public const string Sha384Ecdsa = "1.2.840.10045.4.3.3";
        public const string Sha1Rsa = "1.2.840.113549.1.1.5";
    }
}