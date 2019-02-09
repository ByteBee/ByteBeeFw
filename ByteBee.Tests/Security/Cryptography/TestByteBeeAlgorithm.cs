using System.Text;
using ByteBee.Security;
using ByteBee.Security.Impl;
using ByteBee.Utilities;
using NUnit.Framework;

namespace ByteBeeTests.Security.Cryptography
{
    [TestFixture]
    public class TestByteBeeAlgorithm
    {
        [Test]
        public void the_result_should_be_uber_cryptic()
        {
            string assume = "6bK5CuGDK35D107EADBeA905GhM3XeCVtG2E45x5kz2h6ETr";
            byte[] plain = new Binary("ByteBee");
            ICryptoAlgorithm crypt = new ByteBeeHash("Bee");
            // act
            string actual = crypt.Encode(plain).ToString();
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void test_cipher_combination_block1()
        {
            // arrange
            byte[] a = new byte[32];
            byte[] b = new byte[32];
            byte[] c = new byte[32];

            a[0] = 12;
            b[0] = 99;
            c[0] = 85;

            var hash = new ByteBeeHash();

            // act
            var m = hash.Cipher(a, b, c);

            // assert
            Assert.AreEqual(77, m[0]);
        }


        [Test]
        public void test_cipher_combination_block2()
        {
            // arrange
            byte[] a = new byte[32];
            byte[] b = new byte[32];
            byte[] c = new byte[32];

            a[10] = 14;
            b[10] = 16;
            c[10] = 18;

            var hash = new ByteBeeHash();

            // act
            var m = hash.Cipher(a, b, c);

            // assert
            Assert.AreEqual(16, m[8]);
        }

        [Test]
        public void test_cipher_combination_block3()
        {
            // arrange
            byte[] a = new byte[32];
            byte[] b = new byte[32];
            byte[] c = new byte[32];

            a[28] = 9;
            b[28] = 14;
            c[28] = 5;

            var hash = new ByteBeeHash();

            // act
            var m = hash.Cipher(a, b, c);

            // assert
            Assert.AreEqual(2, m[18]);
        }
        [Test]
        public void test_cipher_combination_block4()
        {
            // arrange
            byte[] a = new byte[32];
            byte[] b = new byte[32];
            byte[] c = new byte[32];

            a[3] = 210;
            b[3] = 206;
            c[3] = 204;

            var hash = new ByteBeeHash("Bee");

            // act
            var m = hash.Cipher(a, b, c);

            // assert
            Assert.AreEqual(35, m[27]);
        }
    }
}