using System;
using System.Security.Cryptography;
using ByteBee.Utilities;

namespace ByteBee.Security.Cryptography.Impl
{
    public class Md5Hash : IHashAlgorithm
    {
        public byte[] Compute(byte[] plain)
        {
            using (var hashAlgorithm = new MD5CryptoServiceProvider())
            {
                return hashAlgorithm.ComputeHash(plain);
            }
        }
    }
}