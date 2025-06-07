using System.Security.Cryptography;

namespace ECDSa.ECDSa
{
    /// <summary>
    /// Provides a custom implementation of <see cref="AsymmetricSignatureFormatter"/> for creating
    /// digital signatures using the ECDSA algorithm.
    /// </summary>
    /// <remarks>
    /// This class is intended for use with cryptographic systems or APIs (such as <see cref="SignedXml"/>)
    /// that expect an <see cref="AsymmetricSignatureFormatter"/>-derived type for ECDSA-based signing.
    /// </remarks>
    internal sealed class ECDsaSignatureFormatter : AsymmetricSignatureFormatter
    {
        private ECDsa _key;

        /// <summary>
        /// Initializes a new instance of the <see cref="ECDsaSignatureFormatter"/> class using the specified ECDSA key.
        /// </summary>
        /// <param name="key">An instance of <see cref="ECDsa"/> used for generating digital signatures.</param>
        public ECDsaSignatureFormatter(ECDsa key)
        {
            _key = key;
        }

        /// <summary>
        /// Sets the asymmetric key used for signature creation.
        /// </summary>
        /// <param name="key">An <see cref="AsymmetricAlgorithm"/> expected to be of type <see cref="ECDsa"/>.</param>
        public override void SetKey(AsymmetricAlgorithm key)
        {
            _key = key as ECDsa;
        }

        /// <summary>
        /// Sets the hash algorithm used to generate the signature.
        /// </summary>
        /// <param name="strName">The name of the hash algorithm. This method is a no-op in this implementation.</param>
        public override void SetHashAlgorithm(string strName)
        {
            // No action needed; ECDsa.SignHash operates directly on the provided hash.
        }

        /// <summary>
        /// Creates the digital signature for the specified hash value.
        /// </summary>
        /// <param name="rgbHash">The hash of the data to sign.</param>
        /// <returns>A byte array representing the ECDSA digital signature.</returns>
        public override byte[] CreateSignature(byte[] rgbHash)
        {
            return _key.SignHash(rgbHash);
        }
    }
}