using System;
using ByteBee.Core.GuardClause;
using ByteBee.Core.Utilities;

namespace ByteBee.Core.Security.Cryptography.Impl
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
            Bee.Guard.NullOrEmpty(salt, "salt");
            return Compute(plain + salt);
        }
        public Binary ComputeWithSaltAndPepper(Binary plain)
            => ComputeWithSaltAndPepper(plain, Condiment.Salt, Condiment.Pepper);

        public Binary ComputeWithSaltAndPepper(Binary plain, string salt)
            => ComputeWithSaltAndPepper(plain, salt, Condiment.Pepper);

        public Binary ComputeWithSaltAndPepper(Binary plain, string salt, string pepper)
        {
            Bee.Guard.NullOrEmpty(salt, "salt");
            Bee.Guard.NullOrEmpty(pepper, "pepper");

            return Compute(plain + salt + pepper);
        }

        private string Standardize(byte[] bytes) =>
            BitConverter.ToString(bytes).Replace("-", string.Empty).ToLowerInvariant();
    }
}