using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SwissKnife.Security
{
    abstract class HashEncryptionEngine : IEncryptionEngine
    {
        protected abstract Encoding _enconding { get; }

        public string Decode(string crypted, string privateKey)
        {
            throw new CryptographicException("Cannot decode a hash back to the original value.");
        }

        public string Encode(string plain) => Encode(plain, Condiment.Salt);
        public string Encode(byte[] plain) => Encode(plain, Condiment.Salt);
        public string Encode(Stream stream) => Encode(stream, Condiment.Salt);
        public string Encode(FileInfo file) => Encode(file, Condiment.Salt);
        public string Decode(string crypted) => Encode(crypted, Condiment.Salt);

        public string Encode(string plain, string privateKey)
            => Encode(_enconding.GetBytes(plain), privateKey);

        protected byte[] CombineArrays(byte[] arr1, string arr2)
        {
            byte[] result = new byte[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = (byte)arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                result[i + arr1.Length] = (byte)arr2[i];
            }

            return result;
        }

        public string Encode(byte[] plain, string privateKey)
        {
            using (var memory = new MemoryStream(plain))
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

        public abstract string Encode(Stream stream, string privateKey);
    }
}
