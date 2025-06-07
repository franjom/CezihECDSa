using System.Security.Cryptography.X509Certificates;

namespace ECDSa.Helper
{
    internal static class X509Certificate2Extensions
    {
        public static bool IsEcdsaCertificate(this X509Certificate2 cert)
        {
            return cert.PublicKey.Oid?.Value == "1.2.840.10045.2.1";
        }

        public static bool IsRsaCertificate(this X509Certificate2 cert)
        {
            return cert.PublicKey.Oid?.Value == "1.2.840.113549.1.1.1";
        }
    }
}