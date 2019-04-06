using System;
using System.Security.Cryptography;
using ByteBee.Utilities;

namespace ByteBee.Security.Cryptography.Impl
{
    public class Sha384Hash : IHashAlgorithm
    {
        public byte[] Compute(byte[] plain)
        {
            using (var hashAlgorithm = new SHA384CryptoServiceProvider())
            {
                return hashAlgorithm.ComputeHash(plain);
            }
        }
    }
}