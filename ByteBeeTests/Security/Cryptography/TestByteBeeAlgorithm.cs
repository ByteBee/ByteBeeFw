using ByteBee.Security.Cryptography;
using ByteBee.Security.Cryptography.Impl;
using NUnit.Framework;

namespace ByteBeeTests.Security.Cryptography
{
    [TestFixture]
    public class TestByteBeeAlgorithm
    {
        [Test]
        public void standard_compute()
        {
            // arrange
            string assume = "b1e85b551f32ce25ca59bf70514e39357710b4e874444b754829f6ab23a4d61e";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new ByteBeeHash());
            // act
            string actual = hash.Compute(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }
        [Test]
        public void compute_with_standard_salt() {
            // arrange
            string assume = "98706b71c1595c39b48a74b6d37f403f4d8a300514ca1378dc878dca0bb64263";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new ByteBeeHash());
            // act
            string actual = hash.ComputeWithSalt(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_custom_salt()
        {
            // arrange
            string assume = "2f95f75f1af9500ed62ec5e1ae2024f5a7d7876a979e556f780f10283d63e495";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new ByteBeeHash());
            // act
            string actual = hash.ComputeWithSalt(plain, "Salt");
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_standard_salt_and_pepper()
        {
            // arrange
            string assume = "6d9f8ec9569f318bd81a111b9ad2e1a66f83430730c984127ca0630626db72f0";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new ByteBeeHash());
            // act
            string actual = hash.ComputeWithSaltAndPepper(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }
        [Test]
        public void compute_with_custom_salt_and_standard_pepper()
        {
            // arrange
            string assume = "41d6a58cd7423947b3d576793fc659eae683d6519652779e9b41fb6190e8daae";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new ByteBeeHash());
            // act
            string actual = hash.ComputeWithSaltAndPepper(plain, "Salt");
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_custom_salt_and_pepper()
        {
            // arrange
            string assume = "b434323320c9f26cf47460f9e4bf41b86f80c92c1714d006599fc8ec2b8f4bcb";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new ByteBeeHash());
            // act
            string actual = hash.ComputeWithSaltAndPepper(plain, "Salt", "Pepper");
            // assert
            Assert.AreEqual(assume, actual);
        }
    }
}