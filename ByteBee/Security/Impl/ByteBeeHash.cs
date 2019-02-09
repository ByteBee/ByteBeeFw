using System.Security.Cryptography;
using ByteBee.Utilities;

namespace ByteBee.Security.Impl
{
    public class ByteBeeHash : HashAlgorithm
    {
        public ByteBeeHash() : base() { }
        public ByteBeeHash(string salt) : base(salt) { }

        public override Binary Encode(Binary plain)
        {
            using (SHA512 sha = new SHA512CryptoServiceProvider())
            {
                byte[] hash = sha.ComputeHash(plain.ToBytes());
                byte[] salt = sha.ComputeHash(Salt);
                byte[] peper = sha.ComputeHash(new Binary(Condiment.Pepper).ToBytes());

                var m = Cipher(hash, salt, peper);

                string result = ArrayToString(m);

                return result;
            }
        }

        internal byte[] Cipher(byte[] a, byte[] b, byte[] c)
        {
            var m = new byte[32];

            for (int i = 0; i < 32; i++)
            {
                int f = 0, g = 0;

                if (0 <= i && i <= 7)
                {
                    g = i;
                    f = a[g] ^ (b[g] & (c[g] ^ a[g]));
                }
                else if (8 <= i && i <= 15)
                {
                    g = (5 * i + 1) % 31;
                    f = c[g] ^ (a[g] & (b[g] ^ c[g]));
                }
                else if (16 <= i && i <= 23)
                {
                    g = (3 * i + 5) % 31;
                    f = b[g] ^ c[g] ^ a[g];
                }
                else if (24 <= i && i <= 31)
                {
                    g = (7 * i) % 31;
                    f = c[g] ^ (b[g] | (~a[g]));
                }
                m[i] = (byte)f;
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
            //const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghjiklmnopqrstuvwxyzÀÁḀẤẦẬẰẶḂḄḆĆĈĊČÇḈÐḊḌḎḐḒḔḖḘḚḜẸẼẾỀỆḞḠḢḤḦḨḪḬỊḰḲḴḶḺḼḾṀṂṄṆṈṊØṐṒỌỎỘỠṔṖṘṚṜṞṠṢṪṬṮṰṲṴṶṺỤỨỪỰṼṾẀẂẄẆẈẊẌẎỲỴỸẐẔàáḁấầậằặḃḅḇćĉċčçḉðḋḍḏḑḓḕḗḙḛḝẹẽếềệḟḡḣḥḧḩḫḭịḱḳḵḷḻḽḿṁṃṅṇṉṋøṑṓọỏộỡṕṗṙṛṝṟṡṣṫṭṯṱṳṵṷṻụứừựṽṿẁẃẅẇẉẋẍẏỳỵỹẑẕ";
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghjiklmnopqrstuvwxyz";
            string result = string.Empty;

            do
            {
                int remainder = number % chars.Length;
                number /= chars.Length;

                result = chars[remainder] + result;
            } while (number > 0);

            return result.PadLeft(2, '0');
        }
    }
}