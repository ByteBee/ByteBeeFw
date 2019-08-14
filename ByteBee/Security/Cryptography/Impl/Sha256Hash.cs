using System.Security.Cryptography;

namespace ByteBee.Core.Security.Cryptography.Impl
{
    public class Sha256Hash : IHashAlgorithm
    {
        public byte[] Compute(byte[] plain)
        {
            using (var hashAlgorithm = new SHA256CryptoServiceProvider())
            {
                return hashAlgorithm.ComputeHash(plain);
            }
        }
    }
}