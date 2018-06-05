using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace KukSoft.ToolKit.Security
{
    class MyOwnEncryptionEngine : IEncryptionEngine
    {
        private ASCIIEncoding _enconding = new ASCIIEncoding();

        public string Decode(string crypted) => Decode(crypted, Condiment.Salt);
        public string Decode(string crypted, string privateKey) => throw new NotSupportedException();
        public string Encode(string plain) => Encode(plain, Condiment.Salt);
        public string Encode(byte[] plain) => Encode(plain, Condiment.Salt);
        public string Encode(Stream stream) => Encode(stream, Condiment.Salt);
        public string Encode(FileInfo file) => Encode(file, Condiment.Salt);

        public string Encode(string plain, string privateKey) => Encode(_enconding.GetBytes(plain), privateKey);
        public string Encode(byte[] plain, string privateKey)
        {
            using (SHA256 sha = new SHA256CryptoServiceProvider())
            {
                byte[] hash = sha.ComputeHash(plain);
                byte[] pepper = sha.ComputeHash(_enconding.GetBytes(Condiment.Pepper));
                byte[] salt = sha.ComputeHash(_enconding.GetBytes(privateKey));

                var buffer = new string[8];

                var prepared = new int[32];

                for (int i = 0; i < 32; i++)
                {
                    int tmp = ((hash[i] + pepper[31 - i]) ^ salt[i]);
                    prepared[i] = tmp;

                }

                for (int i = 0; i < 8; i++)
                {
                    int j = 0;
                    int tmp = prepared[j + i];
                    tmp += hash[i + j] | salt[i + j];
                    tmp += pepper[i + j] | hash[i + j];
                    tmp += salt[i + j] | pepper[i + j];
                    j = 8;
                    tmp += prepared[j + i];
                    tmp += hash[i + j] | salt[i + j];
                    tmp += pepper[i + j] | hash[i + j];
                    tmp += salt[i + j] | pepper[i + j];
                    j = 16;
                    tmp += prepared[j + i];
                    tmp += hash[i + j] | salt[i + j];
                    tmp += pepper[i + j] | hash[i + j];
                    tmp += salt[i + j] | pepper[i + j];
                    j = 24;
                    tmp += prepared[j + i];
                    tmp += hash[i + j] | salt[i + j];
                    tmp += pepper[i + j] | hash[i + j];
                    tmp += salt[i + j] | pepper[i + j];

                    Console.WriteLine(tmp);
                    buffer[i] = NumToFun(tmp);
                }


                return string.Join("-", buffer);
            }
        }

        private string NumToFun(int number)
        {
            //const string chars = "0123456789abcdefABCDEF!\"§$%&/()=";
            const string chars = "!\"#$%&'( )*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghjiklmnopqrstuvwxyz{|}~´^°²³";
            string result = string.Empty;

            do
            {
                int remainder = number % chars.Length;
                number /= chars.Length;

                result = chars[remainder] + result;


            } while (number > 0);

            return result.PadLeft(2, '0');
        }

        public string Encode(Stream stream, string privateKey) => throw new NotImplementedException();
        public string Encode(FileInfo file, string privateKey) => throw new NotImplementedException();
    }
}
