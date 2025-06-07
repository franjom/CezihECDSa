using System;
using System.Security.Cryptography;

namespace ECDSa.ECDSa
{
    /// <summary>
    /// Represents a custom signature description for ECDSA using the SHA-384 hash algorithm and a P-384 elliptic curve key.
    /// </summary>
    /// <remarks>
    /// This class is designed to integrate ECDSA with the .NET <see cref="SignedXml"/> infrastructure by specifying
    /// the hash algorithm and formatter/deformatter behavior for ECDSA with SHA-384.
    /// </remarks>
    public class ECDsaSignatureDescription384 : SignatureDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ECDsaSignatureDescription384"/> class.
        /// </summary>
        /// <remarks>
        /// Sets the <see cref="SignatureDescription.KeyAlgorithm"/> property to the fully qualified name of the <see cref="ECDsa"/> type.
        /// </remarks>
        public ECDsaSignatureDescription384()
        {
            KeyAlgorithm = typeof(ECDsa).AssemblyQualifiedName;
        }

        /// <summary>
        /// Creates the hash algorithm used for signing and verifying data.
        /// </summary>
        /// <returns>A new instance of <see cref="SHA384"/>.</returns>
        public override HashAlgorithm CreateDigest()
        {
            return SHA384.Create();
        }

        /// <summary>
        /// Creates a signature formatter used to generate ECDSA signatures.
        /// </summary>
        /// <param name="key">The <see cref="AsymmetricAlgorithm"/> to use for signing. Must be an <see cref="ECDsa"/> key with a 384-bit key size.</param>
        /// <returns>An instance of <see cref="AsymmetricSignatureFormatter"/> that uses ECDSA and SHA-384.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the provided key is not an ECDSA key or does not use the P-384 curve.</exception>
        public override AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key)
        {
            if (!(key is ECDsa ecdsa) || ecdsa.KeySize != 384)
            {
                throw new InvalidOperationException("Requires EC key using P-384");
            }

            return new ECDsaSignatureFormatter(ecdsa);
        }

        /// <summary>
        /// Creates a signature deformatter used to verify ECDSA signatures.
        /// </summary>
        /// <param name="key">The <see cref="AsymmetricAlgorithm"/> to use for verification. Must be an <see cref="ECDsa"/> key with a 384-bit key size.</param>
        /// <returns>An instance of <see cref="AsymmetricSignatureDeformatter"/> that uses ECDSA and SHA-384.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the provided key is not an ECDSA key or does not use the P-384 curve.</exception>
        public override AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key)
        {
            if (!(key is ECDsa ecdsa) || ecdsa.KeySize != 384)
            {
                throw new InvalidOperationException("Requires EC key using P-384");
            }

            return new ECDsaSignatureDeformatter(ecdsa);
        }
    }
}