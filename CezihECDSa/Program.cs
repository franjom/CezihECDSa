using CezihECDSa.Logging;
using CezihECDSa.SoapClients.Cezdlih;
using CezihECDSa.SoapClients.Evidencije;
using CezihECDSa.SoapClients.InfoOthers;
using CezihECDSa.SoapClients.InfoOthers.Wrappers;
using CezihECDSa.SoapClients.OsigInfo;
using CezihECDSa.SoapClients.PrijavaZarazne;
using CezihECDSa.Wsdl;
using CezihECDSa.Wsdl.PrijavaZarazne;
using ECDSa;
using ECDSa.ECDSa;
using ECDSa.Helper;
using Net.Pkcs11Interop.X509Store;
using System;
using System.Collections.Generic;
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
            //TestOsigInfo(cert);
            //TestPrijavaZarazne(cert);
            //TestInfoOthers(cert);
            //TestECezdlih(cert);
            TestEvidencije(cert);
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
            const string thumb = "d6d708bb76ca6812f07d8ec6a0dd032ddc8884c6";

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
                BaseUri = new Uri(""),
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
                BaseUri = new Uri(""),
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
            // ovo radi sa ECDSA mora se slati potpiani request
            var opts = new CezdlihOptions
            {
                BaseUri = new Uri(""),
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

            var response3 = cezdlihClient.SlanjeNarudzbenica(new SlanjeNarudzbenicaRequest(
                new SlanjeNarudzbenicaSlanjeNarudzbenicaRequest
                {
                    SifraUstanoveNarucitelj = "",
                    PodaciOSkladistu = "",
                    PodaciOLokacijiSkladista = "",
                    SifraUstanoveOdKojegSeNarucuje = "",
                    BrojNarudzbenice = "",
                    DatumKreiranjaNarudzbenice = DateTime.Now,
                    Cjepiva = new List<ArrayOfSlanjeNarudzbenicaZahtjevCjepivoCjepivo>
                    {
                        new ArrayOfSlanjeNarudzbenicaZahtjevCjepivoCjepivo
                        {
                            SifraVrsteCjepivo = 0,
                            TrazenaKolicina = 0,
                            Napomena = ""
                        }
                    }.ToArray(),
                    IdentifikatorZahtjev = new ZaglavljeZahtjevType
                    {
                        PorukaID = $"{Guid.NewGuid()}",
                        VrijemeSlanja = DateTime.Now
                    }
                }));

            var response4 = cezdlihClient.PreuzimanjeOtpremnice(new PreuzimanjeOtpremniceRequest(
                new PreuzimanjeOtpremnicePreuzimanjeOtpremniceRequest
                {
                    SifraUstanove = "",
                    BrojNarudzbenice = "",
                    IdentifikatorZahtjev = new ZaglavljeZahtjevType
                    {
                        PorukaID = $"{Guid.NewGuid()}",
                        VrijemeSlanja = DateTime.Now
                    }
                }));

            var response5 = cezdlihClient.SlanjePrimke(new SlanjePrimkeRequest(
                new SlanjePrimkeSlanjePrimkeRequest
                {
                    SifraUstanove = "",
                    BrojNarudzbenice = "",
                    BrojOtpremnice = "",
                    BrojPrimke = "",
                    Cjepiva = new List<ArrayOfStavkeCjepivaTypeCjepivoCjepivo>
                    {
                        new ArrayOfStavkeCjepivaTypeCjepivoCjepivo
                        {
                            JedinstvenaSifraCjepiva = "",
                            GenerickoImeCjepiva = "",
                            ZasticenoImeCjepiva = "",
                            SifraVrsteCjepiva = 0,
                            NazivProizvodacaCjepiva = "",
                            ATK10SifraCjepiva = "",
                            JedinicaMjere = "",
                            Serija = "",
                            RokUporabe = DateTime.Now,
                            Doza = 0,
                            KolicinaOriginalnihPakiranja = null,
                            PrezentacijaCjepiva = "",
                        }
                    }.ToArray(),
                    IdentifikatorZahtjev = new ZaglavljeZahtjevType
                    {
                        PorukaID = $"{Guid.NewGuid()}",
                        VrijemeSlanja = DateTime.Now
                    }
                }));

            var response13 = cezdlihClient.PreuzimanjeZip(new PreuzimanjeZipRequest(
                new PreuzimanjeZipPreuzimanjeZipRequest
                {
                    SifraUstanove = "",
                    IdentifikatorZahtjev = new ZaglavljeZahtjevType
                    {
                        PorukaID = $"{Guid.NewGuid()}",
                        VrijemeSlanja = DateTime.Now
                    }
                }));

            var response15 = cezdlihClient.StatusLijecenjaPacijenta(new StatusLijecenjaPacijentaZahtjevZaStatusLijecenjaPacijenta
            {
                StatusLijecenjaPacijenta = new List<ArrayOfStatusLijecenjaPacijentaTypeStatusLijecenjaPacijentaType>
                {
                    new ArrayOfStatusLijecenjaPacijentaTypeStatusLijecenjaPacijentaType
                    {
                        SifraUstanoveKojaUpucuje = "",
                        DatumVrijemeStatusa = DateTime.Now,
                        Status = 0,
                        Covid = false,
                        AsimptomatskiIzDomova = false,
                        IntenzitetSimptoma = 0,
                        IshodLijecenja = 0,
                        Oprema = "",
                        Pacijent = new ArrayOfStatusLijecenjaPacijentaTypeStatusLijecenjaPacijentaTypePacijent
                        {
                            Item = "",
                            ItemElementName = ItemChoiceType2.EUKartica,
                            Ime = "",
                            Prezime = "",
                            Spol = Spol.Nepoznato,
                            DatumRodjenja = DateTime.Now,
                            DrzavaOsiguranjaZaStrance = ""
                        },
                        Dijagnoza = new List<ArrayOfStatusLijecenjaPacijentaTypeStatusLijecenjaPacijentaTypeDijagnoza>
                        {
                            new ArrayOfStatusLijecenjaPacijentaTypeStatusLijecenjaPacijentaTypeDijagnoza
                            {
                                Sifra = "",
                            }
                        }.ToArray(),
                    }
                }.ToArray(),
                IdentifikatorZahtjev = new ZaglavljeZahtjevType
                {
                    PorukaID = $"{Guid.NewGuid()}",
                    VrijemeSlanja = DateTime.Now
                }
            });

            Console.WriteLine("done");
        }

        private static void TestInfoOthers(X509Certificate2 cert)
        {
            var opts = new InfoOthersOptions 
            {
                BaseUri = new Uri("https://servistest.hzzo.hr/InfoOthers/InfoOthers.svc/s11"),
                Timeout = TimeSpan.FromSeconds(30)
            };
            var infoOthersClient = new InfoOthersClient(opts, cert);
            //var responseSync1 = infoOthersClient.DohvatiOthers(new WDohvatiOthersRequest("", "54968374901"));
            var responseSync = infoOthersClient.DohvatiOthers(new WDohvatiOthersRequest("03276147", "990000767"));
            //var responseSync2 = infoOthersClient.DohvatiOthersNaDan(new WDohvatiOthersNaDanRequest("03276147", "990000767", DateTime.Today, true));
            //var responseSync3 = infoOthersClient.AutorizacijaOthers(new WAutorizacijaOthersRequest(
            //                        osiguravateljsifra: string.Empty,
            //                        pacijentoib: "12345678901",
            //                        brojKartice: string.Empty,
            //                        dattroska: DateTime.Now,
            //                        dattroskaSpecified: false,
            //                        transiznos: 0m,
            //                        trnsiznosSpecified: false,
            //                        transtip: 0,
            //                        transtipSpecified: false,
            //                        ustanovasifra: string.Empty
            //                    ));
            //var responseSync4 = infoOthersClient.AutorizacijaOthersPharmacy(new WAutorizacijaOthersPharmacyRequest(
            //                        osiguravateljsifra: string.Empty,  // Empty string for OsiguravateljSifra
            //                        pacijentoib: "12345678901",
            //                        brojKartice: string.Empty,         // Empty string for BrojKartice
            //                        dattroska: DateTime.Now,
            //                        dattroskaSpecified: false,         // False for DatTrosakSpecified
            //                        transiznos: 0m,                    // Default decimal value (0)
            //                        trnsiznosSpecified: false,         // False for TrnsIznosSpecified
            //                        transtip: 0,                       // Default short value (0)
            //                        transtipSpecified: false,          // False for TransTipSpecified
            //                        recsb: string.Empty,               // Empty string for Recsb
            //                        erecid: string.Empty,              // Empty string for Erecid
            //                        ustanovasifra: string.Empty        // Empty string for UstanovaSifra
            //                    ));

            //var responseSync5 = infoOthersClient.StornoOthers(new WStornoOthersRequest(
            //                        osiguravateljsifra: string.Empty,  // Empty string for OsiguravateljSifra
            //                        pacijentoib: "12345678901",
            //                        brojKartice: string.Empty,         // Empty string for BrojKartice
            //                        dattroska: DateTime.Now,
            //                        dattroskaSpecified: false,         // False for DatTrosakSpecified
            //                        transiznos: 0m,                    // Default decimal value (0)
            //                        trnsiznosSpecified: false,         // False for TrnsIznosSpecified
            //                        transtip: 0,                       // Default short value (0)
            //                        transtipSpecified: false,          // False for TransTipSpecified
            //                        autkod: string.Empty               // Empty string for AutKod
            //                    ));

            Console.WriteLine("done");
        }

        private static void TestEvidencije(X509Certificate2 cert)
        {
            var opts = new EvidencijeOptions 
            {
                BaseUri = new Uri("https://servis.hzzo.hr/cezih/Evidencije.svc"),
                Timeout = TimeSpan.FromSeconds(30)
            };
            var infoOthersClient = new EvidencijeClient(opts, cert);
            var responseSync = infoOthersClient.PrijedlogZaProvjeruVozaca(new WPrijedlogZaProvjeruVozacaRequest("990000767", "03276147"));
            var responseSync2 = infoOthersClient.PrijedlogZaProvjeruVozaca(new WPrijedlogZaProvjeruVozacaRequest("990000767", "03276147"));
            var responseSync3 = infoOthersClient.PrijedlogZaProvjeruVozaca(new WPrijedlogZaProvjeruVozacaRequest("990000767", "03276147"));
            var responseSync4 = infoOthersClient.PrijedlogZaProvjeruVozaca(new WPrijedlogZaProvjeruVozacaRequest("990000767", "03276147"));

            Console.WriteLine("done");
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