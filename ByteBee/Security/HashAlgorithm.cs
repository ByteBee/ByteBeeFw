using System;
using System.Security.Cryptography;
using ByteBee.Utilities;

namespace ByteBee.Security
{
    public abstract class HashAlgorithm : ICryptoAlgorithm
    {
        protected readonly byte[] Salt;

        protected HashAlgorithm() : this(Condiment.Salt) { }

        protected HashAlgorithm(string salt)
        {
            if (string.IsNullOrWhiteSpace(salt))
                Salt = new byte[0];

            Salt = new Binary(salt);
        }

        public abstract Binary Encode(Binary plain);

        public Binary Decode(Binary crypted)
        {
            throw new CryptographicUnexpectedOperationException(
                "Cannot decode a hash back to the original value.");
        }

        protected string Stardardize(byte[] bytes) =>
            BitConverter.ToString(bytes).Replace("-", string.Empty).ToLowerInvariant();
    }




}