using System.Security.Cryptography;
using ByteBee.Utilities;

namespace ByteBee.Security.Impl
{
    public class Md5SaltHash : HashAlgorithm
    {
        public Md5SaltHash()
        {
        }

        public Md5SaltHash(string salt) : base(salt)
        {
        }

        public override Binary Encode(Binary plain)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] salten = new Binary(plain + new Binary(Salt));
                byte[] hashed = md5.ComputeHash(salten);

                return Stardardize(hashed);
            }
        }
    }
}