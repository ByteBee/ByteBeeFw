using System;
using ByteBee.Utilities;

namespace ByteBee.Security.Cryptography.Impl
{
    public class HashFactory : IHashFactory
    {
        private readonly IHashAlgorithm _algorithm;

        public HashFactory(IHashAlgorithm algorithm)
        {
            _algorithm = algorithm;
        }

        public Binary Compute(Binary plain)
        {
            byte[] hash = _algorithm.Compute(plain);
            return Standardize(hash);
        }

        public Binary ComputeWithSalt(Binary plain) => ComputeWithSalt(plain, Condiment.Salt);

        public Binary ComputeWithSalt(Binary plain, string salt)
        {
            Guard.AgainstNullOrEmpty(salt, "salt");
            return Compute(plain + salt);
        }
        public Binary ComputeWithSaltAndPepper(Binary plain)
            => ComputeWithSaltAndPepper(plain, Condiment.Salt, Condiment.Pepper);

        public Binary ComputeWithSaltAndPepper(Binary plain, string salt)
            => ComputeWithSaltAndPepper(plain, salt, Condiment.Pepper);

        public Binary ComputeWithSaltAndPepper(Binary plain, string salt, string pepper)
        {
            Guard.AgainstNullOrEmpty(salt, "salt");
            Guard.AgainstNullOrEmpty(pepper, "pepper");

            return Compute(plain + salt + pepper);
        }

        private string Standardize(byte[] bytes) =>
            BitConverter.ToString(bytes).Replace("-", string.Empty).ToLowerInvariant();
    }
}