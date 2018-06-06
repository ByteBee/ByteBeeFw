using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace KukSoft.ToolKit.Security
{
    class MyOwnEncryptionEngine : IEncryptionEngine
    {
        private UnicodeEncoding _enconding = new UnicodeEncoding();

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
                byte[] pepr = sha.ComputeHash(_enconding.GetBytes(Condiment.Pepper));
                byte[] salt = sha.ComputeHash(_enconding.GetBytes(privateKey));

                
                var m = Cipher(hash, salt, pepr);
                return ArrayToString(m);
            }
        }

        private byte[] Cipher(byte[]a,byte[]b,byte[]c)
        {
            var m = new byte[32];

            for (int i = 0; i < 32; i++)
            {
                int f = 0, g = 0;

                if (0 <= i && i <= 7)
                {
                    g = i;
                    f = (b[g] & c[g]) | ((~b[g]) & a[g]);
                }
                else if (8 <= i && i <= 15)
                {
                    g = (5 * i + 1) % 32;
                    f = (a[g] & b[g]) | ((~a[g]) & a[g]);
                }
                else if (16 <= i && i <= 23)
                {
                    g = (3 * i + 5) % 32;
                    f = b[g] ^ c[g] ^ a[g];
                }
                else if (24 <= i && i <= 31)
                {
                    g = (7 * i) % 32;
                    f = c[g] ^ (b[g] | (~a[g]));
                }

                Console.WriteLine(f);

                m[i] = (byte)Math.Abs(f);
            }

            return m;
        }

        private string ArrayToString(byte[] m)
        {
            var buffer = new string[16];

            for (int i = 0; i < 16; i++)
            {
                int j = i + 16;

                int x = m[i] + m[j] * 256;

                buffer[i] = NumberToString(x);
            }

            return string.Join(string.Empty, buffer);
        }

        private string NumberToString(int number)
        {
            Console.WriteLine(number);

            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghjiklmnopqrstuvwxyzÀÁḀẤẦẬẰẶḂḄḆĆĈĊČÇḈÐḊḌḎḐḒḔḖḘḚḜẸẼẾỀỆḞḠḢḤḦḨḪḬỊḰḲḴḶḺḼḾṀṂṄṆṈṊØṐṒỌỎỘỠṔṖṘṚṜṞṠṢṪṬṮṰṲṴṶṺỤỨỪỰṼṾẀẂẄẆẈẊẌẎỲỴỸẐẔàáḁấầậằặḃḅḇćĉċčçḉðḋḍḏḑḓḕḗḙḛḝẹẽếềệḟḡḣḥḧḩḫḭịḱḳḵḷḻḽḿṁṃṅṇṉṋøṑṓọỏộỡṕṗṙṛṝṟṡṣṫṭṯṱṳṵṷṻụứừựṽṿẁẃẅẇẉẋẍẏỳỵỹẑẕ";
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
