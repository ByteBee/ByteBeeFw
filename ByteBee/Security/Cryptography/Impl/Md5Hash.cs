using System.Security.Cryptography;

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