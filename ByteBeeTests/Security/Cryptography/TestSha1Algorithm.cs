using ByteBee.Security.Cryptography;
using ByteBee.Security.Cryptography.Impl;
using NUnit.Framework;

namespace ByteBeeTests.Security.Cryptography
{
    [TestFixture]
    public class TestSha1Algorithm
    {
        [Test]
        public void standard_compute()
        {
            // arrange
            string assume = "4e96485b48c8019163d43041349b488b4c83d2b0";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha1Hash());
            // act
            string actual = hash.Compute(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_standard_salt()
        {
            // arrange
            string assume = "2ab485057a9d9df47bcf13062c284b787201d820";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha1Hash());
            // act
            string actual = hash.ComputeWithSalt(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_custom_salt()
        {
            // arrange
            string assume = "8aca36151036421088c6cca1982cfa4424de482a";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha1Hash());
            // act
            string actual = hash.ComputeWithSalt(plain, "Salt");
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_standard_salt_and_pepper()
        {
            // arrange
            string assume = "089f03e9e86d19960dcc32c74d5e03cff52a6752";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha1Hash());
            // act
            string actual = hash.ComputeWithSaltAndPepper(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_custom_salt_and_standard_pepper()
        {
            // arrange
            string assume = "55b5b1301f3042e4f676a18fd6ba602000da5ac7";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha1Hash());
            // act
            string actual = hash.ComputeWithSaltAndPepper(plain, "Salt");
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_custom_salt_and_pepper()
        {
            // arrange
            string assume = "7d89f8c37cf774882876effc0a8d138a9ab378b7";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha1Hash());
            // act
            string actual = hash.ComputeWithSaltAndPepper(plain, "Salt", "Pepper");
            // assert
            Assert.AreEqual(assume, actual);
        }
    }
}