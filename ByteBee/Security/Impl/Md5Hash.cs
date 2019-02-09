using System.Security.Cryptography;
using ByteBee.Utilities;

namespace ByteBee.Security.Impl
{
    public class Md5Hash : HashAlgorithm
    {
        public override Binary Encode(Binary plain)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] hashed = md5.ComputeHash(plain.ToBytes());
                return new Binary(Stardardize(hashed));
            }
        }
    }
}