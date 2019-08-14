using System.Security.Cryptography;

namespace ByteBee.Core.Security.Cryptography.Impl
{
    public class Sha1Hash : IHashAlgorithm
    {
        public byte[] Compute(byte[] plain)
        {
            using (var hashAlgorithm = new SHA1CryptoServiceProvider())
            {
                return hashAlgorithm.ComputeHash(plain);
            }
        }
    }
}