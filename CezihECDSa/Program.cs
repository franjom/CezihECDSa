using CezihECDSa.Logging;
using CezihECDSa.SoapClients.Cezdlih;
using CezihECDSa.SoapClients.OsigInfo;
using CezihECDSa.SoapClients.PrijavaZarazne;
using CezihECDSa.Wsdl;
using CezihECDSa.Wsdl.PrijavaZarazne;
using ECDSa;
using ECDSa.ECDSa;
using ECDSa.Helper;
using Net.Pkcs11Interop.X509Store;
using System;
using System.IdentityModel.Policy;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;
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

            //var cert = ReadFromSoftCert();
            var cert = ReadFromEcdsaCard();

            //TestXmlSigning(cert);
            TestOsigInfo(cert);
            //TestPrijavaZarazne(cert);
            //TestECezdlih(cert);
        }

        private static X509Certificate2 ReadFromEcdsaCard()
        {
            var programFilesPath = Environment.GetEnvironmentVariable("ProgramW6432");
            var akdeidPath = GetSafePath(programFilesPath, AkdEidPath);

            // provide your actual PIN here
            IPinProvider pinProvider = new PinProvider("123456");
            AsymmetricAlgorithm algorithm;

            X509Certificate2 cert = null;
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
                                    cert = certificate.Info.ParsedCertificate;
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

                if (cert == null)
                {
                    return null;
                }

                var thumb = cert.Thumbprint;

                if (string.IsNullOrWhiteSpace(thumb))
                {
                    return null;
                }

                // we take the cert from store because the one returned by Pkcs11X509Store doesn't have a PK
                // and also to be compliant with existing IK interface implementation... if you don't need to be compliant
                // you can use algorithm that was created above
                var store = new X509Store();
                store.Open(OpenFlags.ReadOnly);
                var certs = store.Certificates.Find(X509FindType.FindByThumbprint, thumb, false);
                if (certs.Count <= 0)
                {
                    return null;
                }

                return certs[0];
            }
        }


        private static X509Certificate2 ReadFromSoftCert()
        {
            const string thumb = "";

            var store = new X509Store();
            store.Open(OpenFlags.ReadOnly);
            var certs = store.Certificates.Find(X509FindType.FindByThumbprint, thumb, false);
            if (certs.Count <= 0)
            {
                return null;
            }

            return certs[0];
        }

        private static void TestXmlSigning(X509Certificate2 cert)
        {
            // this is for mock data
            var provider = new XmlDigitalSignatureProvider
            {
                Certificate = cert
            };

            var doc = new XmlDocument();
            doc.LoadXml(xml);

            provider.SignXml(doc, "PO123456");
        }

        private static void TestOsigInfo(X509Certificate2 cert)
        {
            var opts = new OsigInfoOptions
            {
                BaseUri = new Uri("https://certws.cezih.hr:40443/osiginfo-3"),
                Timeout = TimeSpan.FromSeconds(10)
            };
            var osigInfoClient = new OsigInfoClient(opts, cert);
            var responseSync1 = osigInfoClient.osigInfoForSKZZ("");
            var responseSync2 = osigInfoClient.osigInfoForDoctor("");
            var responseSync3 = osigInfoClient.osigInfoForBIS("");
            var glavarina = osigInfoClient.infoGlavarina("", DateTime.MinValue);
            var chosen = osigInfoClient.chosenDoctor("");
        }

        private static void TestPrijavaZarazne(X509Certificate2 cert)
        {
            var opts = new PrijavaZarazneOptions
            {
                BaseUri = new Uri("https://certws.cezih.hr:48443"),
                Timeout = TimeSpan.FromSeconds(30)
            };

            var prijavaZarazneClient = new PrijavaZarazneClient(opts, cert);

            var extrinsicObjId = $"urn:uuid:{Guid.NewGuid():N}";
            var response = prijavaZarazneClient.DocumentRepository_ProvideAndRegisterDocumentSetb(
                new DocumentRepository_ProvideAndRegisterDocumentSetbRequest(
                    new ProvideAndRegisterDocumentSetRequestType
                    {
                        SubmitObjectsRequest = new SubmitObjectsRequest
                        {
                            id = $"urn:uuid:{Guid.NewGuid():N}",
                            comment = "Test comment",
                            RegistryObjectList = new[]
                            {
                                new ExtrinsicObjectType
                                {
                                    id = extrinsicObjId,
                                    mimeType = "text/xml",
                                    objectType = $"urn:uuid:{Guid.NewGuid():N}",
                                    status = "urn:oasis:names:tc:ebxml-regrep:StatusType:Approved",
                                    Slot = new[]
                                    {
                                        new SlotType1
                                        {
                                            name = "creationTime",
                                            ValueList = new ValueListType
                                            {
                                                Value = new[]
                                                {
                                                    DateTime.Now.ToString("yyyyMMddHHmmss")
                                                }
                                            }
                                        },
                                        new SlotType1
                                        {
                                            name = "languageCode",
                                            ValueList = new ValueListType
                                            {
                                                Value = new[]
                                                {
                                                    "hr-HR"
                                                }
                                            }
                                        },
                                        new SlotType1
                                        {
                                            name = "serviceStartTime",
                                            ValueList = new ValueListType
                                            {
                                                Value = new[]
                                                {
                                                    DateTime.Now.ToString("yyyyMMddHHmmss")
                                                }
                                            }
                                        },
                                        new SlotType1
                                        {
                                            name = "serviceStopTime",
                                            ValueList = new ValueListType
                                            {
                                                Value = new[]
                                                {
                                                    DateTime.Now.ToString("yyyyMMddHHmmss")
                                                }
                                            }
                                        },
                                    }
                                }
                            }
                        },
                        Document = new[]
                        {
                            new ProvideAndRegisterDocumentSetRequestTypeDocument
                            {
                                Value = Array.Empty<byte>()
                            }
                        }
                    }));
        }

        private static void TestECezdlih(X509Certificate2 cert)
        {
            //try
            //{
            //    var request = new PreuzimanjePlanaImunizacijePreuzimanjePlanaImunizacijeRequest
            //    {
            //        IdentifikatorZahtjev = new ZaglavljeZahtjevType
            //        {
            //            VrijemeSlanja = DateTime.Now,
            //            PorukaID = $"{Guid.NewGuid()}",
            //        },
            //        SifraUstanove = "940394030",
            //        Godina = 2025
            //    };

            //    var binding = new CustomBinding("Soap12");
            //    var securityBindingElement = binding.Elements.Find<SecurityBindingElement>();
            //    securityBindingElement.LocalClientSettings.IdentityVerifier = new EverythingIsFineIdentityVerifier();

            //    var uri = new Uri("https://cezdlih-cijepih-test.zdravlje.hr:8443");
            //    var endpoint = new EndpointAddress(uri);
            //    var client = new CEZDLIHWSSoapClient(binding, endpoint);
            //    client.Endpoint.EndpointBehaviors.Add(new LoggingEndpointBehavior());
            //    client.Endpoint.Contract.ProtectionLevel = ProtectionLevel.Sign;
            //    client.ClientCredentials.ClientCertificate.Certificate = cert;
            //    client.ClientCredentials.ServiceCertificate.DefaultCertificate = cert;

            //    var response = client.PreuzimanjePlanaImunizacije(request);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}

            // ovo radi sa RSA ne radi sa ECDSA mora se slati nepotpisani request
            //var opts = new CezdlihOptions
            //{
            //    BaseUri = new Uri("https://cezdlih-cijepih-test.zdravlje.hr:8443"),
            //    Timeout = TimeSpan.FromSeconds(30)
            //};

            // ovo radi sa ECDSA mora se slati potpiani request
            var opts = new CezdlihOptions
            {
                BaseUri = new Uri("https://evaccert.zdravlje.hr/WebServices2/CEZDLIHWS.asmx"),
                Timeout = TimeSpan.FromSeconds(30)
            };

            var cezdlihClient = new CezdlihClient(opts, cert);
            var response = cezdlihClient.PreuzimanjePlanaImunizacije(
                new PreuzimanjePlanaImunizacijeRequest
                {
                    PreuzimanjePlanaImunizacijeRequest1 =
                        new PreuzimanjePlanaImunizacijePreuzimanjePlanaImunizacijeRequest
                        {
                            Godina = 2025,
                            SifraUstanove = "",
                            IdentifikatorZahtjev = new ZaglavljeZahtjevType
                            {
                                PorukaID = $"{Guid.NewGuid()}",
                                VrijemeSlanja = DateTime.Now
                            }
                        }
                });

            var response2 = cezdlihClient.SlanjePlanaImunizacije(new SlanjePlanaImunizacijeRequest(
                new SlanjePlanaImunizacijeSlanjePlanaImunizacijeRequest
                {
                    GodinuZaKojuSeTraziPlan = 2025,
                    SifraUstanove = ""
                }));
        }

        private static string GetSafePath(string path1, string path2)
        {
            const int maxLength = 1024;
            var sb = new StringBuilder(maxLength);
            HelperWin32.GetShortPathName(Path.Combine(path1, path2), sb, maxLength);

            return sb.ToString();
        }
    }

    public class EverythingIsFineIdentityVerifier : IdentityVerifier
    {
        public override bool CheckAccess(EndpointIdentity identity, AuthorizationContext authContext)
        {
            return true;
        }

        public override bool TryGetIdentity(EndpointAddress reference, out EndpointIdentity identity)
        {
            return CreateDefault().TryGetIdentity(reference, out identity);
        }
    }
}