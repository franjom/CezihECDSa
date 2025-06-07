using System;
using System.Security.Cryptography;

namespace ECDSa.ECDSa
{
    /// <summary>
    /// A sealed wrapper class that provides a concrete implementation of the abstract <see cref="SHA384"/> class
    /// by delegating to the default platform <see cref="SHA384.Create"/> implementation.
    /// </summary>
    /// <remarks>
    /// This class can be useful in scenarios where a concrete, non-abstract <see cref="SHA384"/> type is required,
    /// such as when used with certain cryptographic APIs that expect a non-abstract instance.
    /// </remarks>
    public sealed class SHA384Factory : SHA384
    {
        private readonly SHA384 _impl = SHA384.Create();

        /// <summary>
        /// Initializes the internal state of the hash algorithm.
        /// </summary>
        public override void Initialize()
        {
            _impl.Initialize();
        }

        /// <summary>
        /// Routes data written to the object into the internal SHA-384 implementation for hashing.
        /// </summary>
        /// <param name="array">The input data.</param>
        /// <param name="ibStart">The offset into the byte array from which to begin using data.</param>
        /// <param name="cbSize">The number of bytes in the byte array to use as data.</param>
        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            _impl.TransformBlock(array, ibStart, cbSize, null, 0);
        }

        /// <summary>
        /// Finalizes the hash computation after the last data is processed.
        /// </summary>
        /// <returns>The computed hash value.</returns>
        protected override byte[] HashFinal()
        {
            _impl.TransformFinalBlock(Array.Empty<byte>(), 0, 0);
            return _impl.Hash;
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="SHA384Factory"/> and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _impl.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}