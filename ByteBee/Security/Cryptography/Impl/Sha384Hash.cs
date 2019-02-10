using System;
using System.Security.Cryptography;
using ByteBee.Utilities;

namespace ByteBee.Security.Cryptography.Impl
{
    public class Sha384Hash : IHashAlgorithm
    {
        public byte[] Compute(byte[] plain)
        {
            using (var ha = new SHA384CryptoServiceProvider())
            {
                return ha.ComputeHash(plain);
            }
        }
    }

    public class Sha512Hash : IHashAlgorithm
    {
        public byte[] Compute(byte[] plain)
        {
            using (var ha = new SHA512CryptoServiceProvider())
            {
                return ha.ComputeHash(plain);
            }
        }
    }
}