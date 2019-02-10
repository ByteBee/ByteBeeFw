using ByteBee.Security.Cryptography;
using ByteBee.Security.Cryptography.Impl;
using NUnit.Framework;

namespace ByteBeeTests.Security.Cryptography
{
    [TestFixture]
    public class TestSha512Algorithm
    {
        [Test]
        public void standard_compute()
        {
            // arrange
            string assume = "b2b15fdf5b3bed25d8ef561c13c4b8ff4fe6d2dc7b8693f0741033b214d12bc02821760ed247b9a27bc570eb1d8d509ce8036e9b1c0b5bb25f5ef91d6c13ad20";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha512Hash());
            // act
            string actual = hash.Compute(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_standard_salt()
        {
            // arrange
            string assume = "6060eb5a9dc14c39462a7104956051875b91df856c3f9692682b9d8889fac9471bb14af1f6eadfc424f62cbd56d6ba033c58a81017ec70395a1a3539d8cf4874";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha512Hash());
            // act
            string actual = hash.ComputeWithSalt(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_custom_salt()
        {
            // arrange
            string assume = "3f9db01f1ab911b801d396428dc59f17ba3e22c33df7239533c1cb73fcbf25495f7479da29abc9e6e5112c73e4dc71e991714bf0e600226a6bccc63dcc2b3654";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha512Hash());
            // act
            string actual = hash.ComputeWithSalt(plain, "Salt");
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_standard_salt_and_pepper()
        {
            // arrange
            string assume = "f5b6a202d68d07ebbf15d97967ed69647b3c2942ce6beadc10750d3df633d5fc6e06b4780db2a1d11a24110996957fe9692a88ce64b24ac72bf9a7602b141a44";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha512Hash());
            // act
            string actual = hash.ComputeWithSaltAndPepper(plain);
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_custom_salt_and_standard_pepper()
        {
            // arrange
            string assume = "e1958ca4112d345d0a5dfea6772f0a0edbb02040d925473b07efd5cd0c0cb2a78532161c18cce67e097b7465996d58a96cd5ac3986e385b1b071aca0e3ad8106";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha512Hash());
            // act
            string actual = hash.ComputeWithSaltAndPepper(plain, "Salt");
            // assert
            Assert.AreEqual(assume, actual);
        }

        [Test]
        public void compute_with_custom_salt_and_pepper()
        {
            // arrange
            string assume = "e59c3b33181a313c44caee2a870660c63ca2cdb42e16e989ac18cbf028fd7adbfd9e2019806fbf6a8a10f6e6245bf06039793709c5ac716b0e5edb56fd8ae910";
            string plain = "ByteBee";
            IHashFactory hash = new HashFactory(new Sha512Hash());
            // act
            string actual = hash.ComputeWithSaltAndPepper(plain, "Salt", "Pepper");
            // assert
            Assert.AreEqual(assume, actual);
        }
    }
}