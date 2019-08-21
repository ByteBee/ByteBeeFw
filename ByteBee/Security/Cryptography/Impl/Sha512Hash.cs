using System.Security.Cryptography;

namespace ByteBee.Security.Cryptography.Impl
{
    public class Sha512Hash : IHashAlgorithm
    {
        public byte[] Compute(byte[] plain)
        {
            using (var hashAlgorithm = new SHA512CryptoServiceProvider())
            {
                return hashAlgorithm.ComputeHash(plain);
            }
        }
    }
}