using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace KukSoft.ToolKit.Security
{
    class Md5Cipher : ICipher
    {
        private UnicodeEncoding _enconding = new UnicodeEncoding();

        public string Encode(string plain, string privateKey)
            => Encode(_enconding.GetBytes(plain), privateKey);

        public string Encode(byte[] plain, string privateKey)
        {
            using(var memory = new MemoryStream(plain))
            {
                return Encode(memory, privateKey);
            }
        }

        public string Encode(FileInfo plain, string privateKey)
        {
            using (var stream = new FileStream(plain.FullName, FileMode.Open))
            {
                return Encode(stream, privateKey);
            }
        }

        public string Encode(Stream stream, string privateKey)
        {
            using (MD5 algo = new MD5CryptoServiceProvider())
            {
                byte[] hash = algo.ComputeHash(stream);
                byte[] salt = algo.ComputeHash(_enconding.GetBytes(privateKey));
                byte[] buffer = Salting(hash, salt);

                return Stardardize(Salting(hash, salt));
            }
        }

        private byte[] Salting(byte[] hash, byte[] salt)
        {
            byte[] salten = new byte[16];

            for (int i = 0; i < 16; i++)
            {
                salten[i] = (byte)(hash[i] ^ salt[i]);
            }

            return salten;
        }

        private string Stardardize(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", string.Empty).ToLowerInvariant();
        }

        public string Decode(string crypted, string privateKey)
        {
            throw new CryptographicException("Cannot decode an MD5 hash back.");
        }

        public string Encode(string plain) => Encode(plain, PKProvider.PrivateKey);
        public string Encode(byte[] plain) => Encode(plain, PKProvider.PrivateKey);
        public string Encode(Stream stream) => Encode(stream, PKProvider.PrivateKey);
        public string Encode(FileInfo file) => Encode(file, PKProvider.PrivateKey);
        public string Decode(string crypted) => Encode(crypted, PKProvider.PrivateKey);
    }
}
