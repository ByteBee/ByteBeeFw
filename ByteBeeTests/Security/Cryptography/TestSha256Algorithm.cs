using ByteBee.Core.Security.Cryptography;
using ByteBee.Core.Security.Cryptography.Impl;
using NUnit.Framework;

namespace ByteBeeTests.Security.Cryptography
{
    [TestFixture]
    public class TestSha256Algorithm
    {
        [Test]
        public void standard_compute()
        {
            // arrange
            string assume = "5da195d05dac3f977b9afea297469bbd3347e3f39ad6b0c48591974cbd5e7a3b";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha256Hash());
            // act
            string actual = hash.Compute(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_standard_salt()
        {
            // arrange
            string assume = "44bd85492662380337156faf56d32dc96e6e1775842ae5e8ece890ed8633b383";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha256Hash());
            // act
            string actual = hash.ComputeWithSalt(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_custom_salt()
        {
            // arrange
            string assume = "70ad478530688767658acbdc1f92cc43c8ff956aeda9977a17e08a22a560f992";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha256Hash());
            // act
            string actual = hash.ComputeWithSalt(plain, "Salt");
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_standard_salt_and_pepper()
        {
            // arrange
            string assume = "bccf680029ae647ee38c675d67579e41fd1f2cb9bfe9c0dcd1703879fa65d12a";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha256Hash());
            // act
            string actual = hash.ComputeWithSaltAndPepper(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_custom_salt_and_standard_pepper()
        {
            // arrange
            string assume = "1896eac4d966fb533426abdce7f258582d4b857894e00a23c707cc559887294b";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha256Hash());
            // act
            string actual = hash.ComputeWithSaltAndPepper(plain, "Salt");
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_custom_salt_and_pepper()
        {
            // arrange
            string assume = "6f8e05255271edd255cc53ebd6036dfbf9abb186572da9d7284db01b039a7f50";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha256Hash());
            // act
            string actual = hash.ComputeWithSaltAndPepper(plain, "Salt", "Pepper");
            // assert
            Assert.AreEqual(assume, actual);
        }

    }
}