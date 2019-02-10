using System;
using System.Security.Cryptography;
using ByteBee.Utilities;

namespace ByteBee.Security.Cryptography.Impl
{
    public class Sha1Hash : IHashAlgorithm
    {
        public byte[] Compute(byte[] plain)
        {
            using (var ha = new SHA1CryptoServiceProvider())
            {
                return ha.ComputeHash(plain);
            }
        }
    }
}