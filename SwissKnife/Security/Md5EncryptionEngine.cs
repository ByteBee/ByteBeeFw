using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using SwissKnife.Extensions;

namespace SwissKnife.Security
{
    class Md5EncryptionEngine : HashEncryptionEngine
    {
        protected override Encoding _enconding => new ASCIIEncoding();

        public override string Encode(Stream stream, string privateKey)
        {
            byte[] buffer = CombineArrays(stream.ToByteArray(), privateKey);

            using (MD5 algo = new MD5CryptoServiceProvider())
            {
                byte[] hash = algo.ComputeHash(buffer);
                byte[] pepper = algo.ComputeHash(_enconding.GetBytes(Condiment.Pepper));
                return Stardardize(Pepperize(hash, pepper));
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
    }
}