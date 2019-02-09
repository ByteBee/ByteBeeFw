using System.Security.Cryptography;
using ByteBee.Security;
using ByteBee.Security.Impl;
using ByteBee.Utilities;
using NUnit.Framework;

namespace ByteBeeTests.Security.Cryptography
{
    [TestFixture]
    public class TestMd5Hash
    {
        [Test]
        public void create_well_known_hash()
        {
            // arrange
            string assume = "cf985ee7afa0196e3ebd0e92f75c3844";
            Binary plain = new Binary("ByteBee");
            ICryptoAlgorithm crypt = new Md5Hash();
            // act
            string actual = crypt.Encode(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void trying_to_decode_a_hash_should_not_be_possible()
        {
            // arrange
            ICryptoAlgorithm crypt = new Md5Hash();
            // act
            void ThisShouldNotWork()
            {
                crypt.Decode("cf985ee7afa0196e3ebd0e92f75c3844");
            }
            // assert
            Assert.Throws<CryptographicUnexpectedOperationException>(ThisShouldNotWork);
        }


        [Test]
        public void a_salten_hash_should_differ_from_the_original()
        {
            // arrange
            string assume = "cf985ee7afa0196e3ebd0e92f75c3844";
            Binary plain = new Binary("ByteBee");
            ICryptoAlgorithm crypt = new Md5SaltHash(null);
            // act
            string actual = crypt.Encode(plain);
            // assert
            Assert.AreNotEqual(assume, actual);
        }

        [Test]
        public void salten_hash_should_be_as_expected()
        {
            // arrange
            string assume = "e6d55636e956e6e6be970ba0a1ab6727";
            Binary plain = new Binary("ByteBee");
            ICryptoAlgorithm crypt = new Md5SaltHash();
            // act
            string actual = crypt.Encode(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }
    }
}