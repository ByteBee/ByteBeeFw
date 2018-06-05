using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace KukSoft.ToolKit.Security
{
    class Md5EncryptionEngine : IEncryptionEngine
    {
        private ASCIIEncoding _enconding = new ASCIIEncoding();

        public string Encode(string plain, string privateKey)
            => Encode(_enconding.GetBytes(plain), privateKey);

        private byte[] Combine(byte[] arr1, string arr2)
        {
            byte[] result = new byte[arr1.Length + arr2.Length];

            for (int i = 0; i < arr2.Length; i++)
            {
                result[i] = (byte)arr2[i];
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                result[i + arr2.Length] = arr1[i];
            }

            return result;
        }

        public string Encode(byte[] plain, string privateKey)
        {
            using (var memory = new MemoryStream(Combine(plain, Condiment.Salt)))
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
                byte[] pepper = algo.ComputeHash(_enconding.GetBytes(privateKey));
                return Stardardize(Pepperize(hash, pepper));
                //return Stardardize(hash);
            }
        }

        private byte[] Pepperize(byte[] hash, byte[] pepper)
        {
            byte[] hot = new byte[16];

            for (int i = 0; i < 16; i++)
            {
                hot[i] = (byte)(hash[i] ^ pepper[i]);
            }

            return hot;
        }

        private string Stardardize(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", string.Empty).ToLowerInvariant();
        }

        public string Decode(string crypted, string privateKey)
        {
            throw new CryptographicException("Cannot decode an MD5 hash back.");
        }

        public string Encode(string plain) => Encode(plain, Condiment.Pepper);
        public string Encode(byte[] plain) => Encode(plain, Condiment.Pepper);
        public string Encode(Stream stream) => Encode(stream, Condiment.Pepper);
        public string Encode(FileInfo file) => Encode(file, Condiment.Pepper);
        public string Decode(string crypted) => Encode(crypted, Condiment.Pepper);
    }
}
