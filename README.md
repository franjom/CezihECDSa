# CezihECDSa

A .NET Framework 4.8 solution for digitally signing XML documents using ECDSA (P-384/SHA-384) or RSA certificates, with support for PKCS#11 hardware tokens (e.g., smart cards, HSMs) via Certilia Middleware.

## Features

- **XML Digital Signatures**: Sign XML documents using ECDSA (SHA-384) or RSA certificates.
- **PKCS#11 Integration**: Access certificates and private keys from hardware tokens using the `Pkcs11Interop` library.
- **Custom Crypto Support**: Implements custom SHA-384 and ECDSA signature classes for compatibility with .NET's `SignedXml`.
- **Certificate Filtering**: Automatically selects certificates with digital signature usage.
- **Extensible**: Easily adaptable for other signature algorithms or certificate sources.

## Solution Structure

- **ECDSa**: Core cryptographic logic, including custom SHA-384, ECDSA signature formatter/deformatter, and XML signature provider.
- **CezihECDSa**: Example console application demonstrating how to enumerate PKCS#11 slots/tokens, select a certificate, and sign an XML document.

## Usage

1. **Configure Certilia Middleware**: Ensure the PKCS#11 library (e.g., `AkdEidPkcs11.dll`) is available and the path is correct.
2. **Set PIN**: Update the PIN in `Program.cs` for your token.
3. **Run the Example**: The app will enumerate available tokens, display certificate info, and sign a sample XML purchase order if a suitable certificate is found.

## Requirements

- .NET Framework 4.8 (for the demo app)
- .NET Standard 2.0 (for the ECDSa library)
- Certilia Middleware or compatible PKCS#11 provider
- [Pkcs11Interop.X509Store](https://github.com/Pkcs11Interop/Pkcs11Interop.X509Store)
- [System.Security.Cryptography.Xml](https://www.nuget.org/packages/System.Security.Cryptography.Xml/)

## Building

Open the solution in Visual Studio 2022 and restore NuGet packages. Build both projects. Run `CezihECDSa` as the startup project.

## License

Copyright © 2025

This project is provided for educational and integration purposes. See individual file headers for more details.