using ByteBee.Security.Cryptography;
using ByteBee.Security.Cryptography.Impl;
using NUnit.Framework;

namespace ByteBeeTests.Security.Cryptography
{
    [TestFixture]
    public class TestSha384Algorithm
    {
        [Test]
        public void standard_compute()
        {
            // arrange
            string assume = "a169cb6486006b017496e396dbb8b9c646fbf8caa1a8fc1e8e748d4da0d2dbd0252209154fa8aabf18a786d7f5d4a755";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha384Hash());
            // act
            string actual = hash.Compute(plain);
            
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_standard_salt()
        {
            // arrange
            string assume = "b564211a0f2f55d8e077532c6b4c97d005303c3945d179a62b8a8a8f958493374fdb5f7c4c11f0d399d32f23a8993cf5";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha384Hash());
            // act
            string actual = hash.ComputeWithSalt(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_custom_salt()
        {
            // arrange
            string assume = "b06238efbaec03a0cc37fcb5d7ee4d8b3f1dedfb6a3c22150dd459de10859a93691c785d699942a636946ab31e96fce2";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha384Hash());
            // act
            string actual = hash.ComputeWithSalt(plain, "Salt");
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_standard_salt_and_pepper()
        {
            // arrange
            string assume = "015b57beb34e3d08d39221b003599857e0bd7681233864f99bafd2d4cf034a05f1d64d6189de91acce6ef4a1a6ab8058";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha384Hash());
            // act
            string actual = hash.ComputeWithSaltAndPepper(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_custom_salt_and_standard_pepper()
        {
            // arrange
            string assume = "8c9078b610b02c4b7f9b7932105777dfe6635229cdd92e0723d82384df67dd4106c46268d791c09baaa757809fd83465";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha384Hash());
            // act
            string actual = hash.ComputeWithSaltAndPepper(plain, "Salt");
            
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_custom_salt_and_pepper()
        {
            // arrange
            string assume = "1f2b08f381a56102fa0dbc4fc0280cc5e70f6b24e83e0c79def62e2ace37a2d06111963973af53424535526f97a68c44";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha384Hash());
            // act
            string actual = hash.ComputeWithSaltAndPepper(plain, "Salt", "Pepper");
            // assert
            Assert.AreEqual(assume, actual);
        }
    }
}