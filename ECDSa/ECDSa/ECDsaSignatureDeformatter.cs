using System.Security.Cryptography;

namespace ECDSa.ECDSa
{
    /// <summary>
    /// Provides a custom implementation of <see cref="AsymmetricSignatureDeformatter"/> for verifying
    /// digital signatures using the ECDSA algorithm.
    /// </summary>
    /// <remarks>
    /// This class is useful for scenarios that require integration with legacy or custom cryptographic systems
    /// that expect a subclass of <see cref="AsymmetricSignatureDeformatter"/>, such as <see cref="SignedXml"/>.
    /// </remarks>
    internal sealed class ECDsaSignatureDeformatter : AsymmetricSignatureDeformatter
    {
        private ECDsa key;

        /// <summary>
        /// Initializes a new instance of the <see cref="ECDsaSignatureDeformatter"/> class with the specified ECDSA key.
        /// </summary>
        /// <param name="key">An instance of <see cref="ECDsa"/> used to verify digital signatures.</param>
        public ECDsaSignatureDeformatter(ECDsa key)
        {
            this.key = key;
        }

        /// <summary>
        /// Sets the asymmetric algorithm key to use for signature verification.
        /// </summary>
        /// <param name="key">An <see cref="AsymmetricAlgorithm"/> expected to be of type <see cref="ECDsa"/>.</param>
        public override void SetKey(AsymmetricAlgorithm key)
        {
            this.key = key as ECDsa;
        }

        /// <summary>
        /// Sets the hash algorithm used for verifying the signature.
        /// </summary>
        /// <param name="strName">The name of the hash algorithm. This method is a no-op in this implementation.</param>
        public override void SetHashAlgorithm(string strName)
        {
            // No action needed; ECDsa.VerifyHash handles hash algorithm internally.
        }

        /// <summary>
        /// Verifies the specified digital signature against the provided hash.
        /// </summary>
        /// <param name="rgbHash">The hash of the signed data.</param>
        /// <param name="rgbSignature">The digital signature to verify.</param>
        /// <returns><c>true</c> if the signature is valid; otherwise, <c>false</c>.</returns>
        public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
        {
            return key.VerifyHash(rgbHash, rgbSignature);
        }
    }
}