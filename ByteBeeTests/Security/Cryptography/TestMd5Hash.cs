using System;
using ByteBee.Security.Cryptography;
using ByteBee.Security.Cryptography.Impl;
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
            IHashFactory crypt = new HashFactory(new Md5Hash());
            // act
            string actual = crypt.Compute(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }


        [Test]
        public void salt_cannot_be_null()
        {
            // arrange
            Binary plain = new Binary("ByteBee");
            IHashFactory crypt = new HashFactory(new Md5Hash());
            // act
            void Test()
            {
                crypt.ComputeWithSalt(plain, null);
            }

            // assert
            Assert.Throws<ArgumentNullException>(Test);
        }


        [Test]
        public void a_salten_hash_should_differ_from_the_original()
        {
            // arrange
            string assume = "cf985ee7afa0196e3ebd0e92f75c3844";
            Binary plain = new Binary("ByteBee");
            IHashFactory crypt = new HashFactory(new Md5Hash());
            // act
            string actual = crypt.ComputeWithSalt(plain, "Bee");
            // assert
            Assert.AreNotEqual(assume, actual);
        }

        [Test]
        public void salten_hash_should_be_as_expected()
        {
            // arrange
            string assume = "e6d55636e956e6e6be970ba0a1ab6727";
            Binary plain = new Binary("ByteBee");
            IHashFactory crypt = new HashFactory(new Md5Hash());
            // act
            string actual = crypt.ComputeWithSalt(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }
        [Test]
        public void salted_and_peppered_hashes_should_not_like_original()
        {
            string plain = "ByteBee";
            IHashFactory crypt = new HashFactory(new Md5Hash());

            string hash = crypt.Compute(plain);
            string salted = crypt.ComputeWithSalt(plain);
            string peppered = crypt.ComputeWithSaltAndPepper(plain);


            Assert.AreNotEqual(hash, salted);
            Assert.AreNotEqual(hash, peppered);

            Assert.AreEqual("cf985ee7afa0196e3ebd0e92f75c3844", hash);
            Assert.AreEqual("e6d55636e956e6e6be970ba0a1ab6727", salted);
            Assert.AreEqual("6c399b62a9e21d4a8f5f144c575311da", peppered);
            
        }
    }
}