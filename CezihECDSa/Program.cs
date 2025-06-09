using ECDSa;
using ECDSa.ECDSa;
using ECDSa.Helper;
using Net.Pkcs11Interop.X509Store;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace CezihECDSa
{
    internal class Program
    {
        private static readonly string AkdEidPath = Path.Combine(new[]
        {
            "AKD",
            "Certilia Middleware",
            "pkcs11",
            "AkdEidPkcs11.dll"
        });

        private static string xml = @"<?xml version=""1.0"" encoding=""utf-8""?>
<PurchaseOrder Id=""PO123456"">
  <Customer>
    <Name>Jane Doe</Name>
    <Address>
      <Street>123 Main Street</Street>
      <City>Springfield</City>
      <State>IL</State>
      <PostalCode>62704</PostalCode>
    </Address>
    <Email>jane.doe@example.com</Email>
  </Customer>
  <Items>
    <Item>
      <ProductName>Wireless Mouse</ProductName>
      <Quantity>2</Quantity>
      <UnitPrice>25.99</UnitPrice>
    </Item>
    <Item>
      <ProductName>Keyboard</ProductName>
      <Quantity>1</Quantity>
      <UnitPrice>45.50</UnitPrice>
    </Item>
  </Items>
  <TotalAmount>97.48</TotalAmount>
  <OrderDate>2025-06-06</OrderDate>
</PurchaseOrder>";

        static void Main(string[] args)
        {
            // Add this to your executable's entry point, preferably Program.cs and static main, this here is only to be used as an example!
            CryptoConfig.AddAlgorithm(typeof(SHA384Factory), "http://www.w3.org/2001/04/xmlenc#sha384");
            CryptoConfig.AddAlgorithm(typeof(ECDsaSignatureDescription384), SignatureAlgorithm.XmlDsigECDSaSha384Url);

            // good to go

            var programFilesPath = Environment.GetEnvironmentVariable("ProgramW6432");
            var akdeidPath = GetSafePath(programFilesPath, AkdEidPath);

            // provide your actual PIN here
            IPinProvider pinProvider = new PinProvider("123456");
            AsymmetricAlgorithm algorithm;

            // this is for mock data
            var provider = new XmlDigitalSignatureProvider();

            using (var pkcs11Store = new Pkcs11X509Store(akdeidPath, pinProvider))
            {
                // Show general information about the loaded library
                Console.WriteLine("Library");
                Console.WriteLine("  Path:               " + pkcs11Store.Info.LibraryPath);
                Console.WriteLine("  Manufacturer:       " + pkcs11Store.Info.Manufacturer);
                Console.WriteLine("  Description:        " + pkcs11Store.Info.Description);

                // Get list of all available slots
                foreach (var slot in pkcs11Store.Slots)
                {
                    // Show basic information about the slot
                    Console.WriteLine("Slot");
                    Console.WriteLine("  Manufacturer:       " + slot.Info.Manufacturer);
                    Console.WriteLine("  Description:        " + slot.Info.Description);

                    // Continue only if there is a token present in the slot
                    if (slot.Token == null)
                        continue;

                    // Show basic information about the token
                    Console.WriteLine("Token");
                    Console.WriteLine("  Manufacturer:       " + slot.Token.Info.Manufacturer);
                    Console.WriteLine("  Model:              " + slot.Token.Info.Model);
                    Console.WriteLine("  Serial number:      " + slot.Token.Info.SerialNumber);
                    Console.WriteLine("  Label:              " + slot.Token.Info.Label);
                    Console.WriteLine("  Initialized:        " + slot.Token.Info.Initialized);

                    // Continue only if the token is initialized and thus usable
                    if (!slot.Token.Info.Initialized)
                        continue;

                    // Show basic information about the certificates stored on the token
                    foreach (var certificate in slot.Token.Certificates)
                    {
                        Console.WriteLine("Certificate");
                        Console.WriteLine("  Subject:            " + certificate.Info.ParsedCertificate.Subject);
                        Console.WriteLine("  Issuer:             " + certificate.Info.ParsedCertificate.Issuer);
                        Console.WriteLine("  Serial number:      " + certificate.Info.ParsedCertificate.SerialNumber);
                        Console.WriteLine("  Not before:         " + certificate.Info.ParsedCertificate.NotBefore);
                        Console.WriteLine("  Not after:          " + certificate.Info.ParsedCertificate.NotAfter);
                        Console.WriteLine("  Thumbprint:         " + certificate.Info.ParsedCertificate.Thumbprint);
                        Console.WriteLine("  Friendly name:      " + certificate.Info.ParsedCertificate.FriendlyName);

                        foreach (var ext in certificate.Info.ParsedCertificate.Extensions)
                        {
                            if (ext is X509KeyUsageExtension keyUsageExtension)
                            {
                                if ((keyUsageExtension.KeyUsages & X509KeyUsageFlags.DigitalSignature) ==
                                    X509KeyUsageFlags.DigitalSignature)
                                {
                                    provider.Certificate = certificate.Info.ParsedCertificate;

                                    if (certificate.Info.ParsedCertificate.IsEcdsaCertificate())
                                    {
                                        algorithm = certificate.GetECDsaPrivateKey();
                                    }
                                    else
                                    {
                                        algorithm = certificate.GetRSAPrivateKey();
                                    }

                                    var subject = certificate.Info.ParsedCertificate.Subject; // X509Certificate2 cert
                                    var match = Regex.Match(subject, @"SERIALNUMBER\s*=\s*PNOHR-(\d{11})");

                                    if (match.Success)
                                    {
                                        var oib = match.Groups[1].Value;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Number not found.");
                                    }
                                }
                            }
                        }
                    }
                }

                if (provider.Certificate != null)
                {
                    var thumb = provider.Certificate.Thumbprint;

                    if (string.IsNullOrWhiteSpace(thumb))
                    {
                        return;
                    }

                    // we take the cert from store because the one returned by Pkcs11X509Store doesn't have a PK
                    // and also to be compliant with exisint IK interface implementation... if you don't need to be compliant
                    // you can use algorithm that was created above
                    var store = new X509Store();
                    store.Open(OpenFlags.ReadOnly);
                    var certs = store.Certificates.Find(X509FindType.FindByThumbprint, thumb, false);
                    if (certs.Count <= 0)
                    {
                        return;
                    }

                    provider.Certificate = certs[0];

                    var doc = new XmlDocument();
                    doc.LoadXml(xml);

                    provider.SignXml(doc, "PO123456");
                }
            }
        }

        public static string GetSafePath(string path1, string path2)
        {
            const int maxLength = 1024;
            var sb = new StringBuilder(maxLength);
            HelperWin32.GetShortPathName(Path.Combine(path1, path2), sb, maxLength);

            return sb.ToString();
        }
    }
}