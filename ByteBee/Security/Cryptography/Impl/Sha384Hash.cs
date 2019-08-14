using System.Security.Cryptography;

namespace ByteBee.Core.Security.Cryptography.Impl
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