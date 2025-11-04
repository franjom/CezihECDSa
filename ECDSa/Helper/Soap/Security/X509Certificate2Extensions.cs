using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace ECDSa.Helper.Soap.Security
{
    public static class X509Certificate2Extensions
    {
        public static bool IsEcdsaCertificate(this X509Certificate2 cert)
        {
            return cert.PublicKey.Oid?.Value == "1.2.840.10045.2.1";
        }

        public static bool IsRsaCertificate(this X509Certificate2 cert)
        {
            return cert.PublicKey.Oid?.Value == "1.2.840.113549.1.1.1";
        }

        public static string GetSerial(this X509Certificate2 cert)
        {
            var serialBytes = cert.GetSerialNumber();
            var unsignedSerialBytes = new byte[serialBytes.Length + 1];
            Buffer.BlockCopy(serialBytes, 0, unsignedSerialBytes, 1, serialBytes.Length);
            var serialNumber = new BigInteger(unsignedSerialBytes).ToString();

            return serialNumber;
        }
    }
}