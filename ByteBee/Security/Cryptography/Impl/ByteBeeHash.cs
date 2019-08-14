using System.Security.Cryptography;

namespace ByteBee.Core.Security.Cryptography.Impl
{
    public sealed class ByteBeeHash : IHashAlgorithm
    {
        public byte[] Compute(byte[] plain)
        {
            using (SHA512 hashAlgorithm = new SHA512CryptoServiceProvider())
            {
                byte[] a = hashAlgorithm.ComputeHash(plain);
                byte[] b = hashAlgorithm.ComputeHash(a);
                byte[] c = hashAlgorithm.ComputeHash(b);

                return ComputeHash(a, b, c);
            }
        }

        private byte[] ComputeHash(byte[] a, byte[] b, byte[] c)
        {
            var m = new byte[32];

            for (int i = 0; i < 32; i++)
            {
                int f = 0, g;

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
    }
}