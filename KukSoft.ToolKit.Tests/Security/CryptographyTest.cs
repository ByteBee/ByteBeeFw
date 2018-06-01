using NUnit.Framework;

namespace KukSoft.ToolKit.Security.Tests
{
    [TestFixture]
    public class CryptographyTest
    {
        [TestCase("foobar", "f1ba81c458a534adefd60ef0a08363ee")]
        [TestCase("the quick brown fox", "c2c475dedcdbd1439377541ed6628550")]
        [TestCase("my lazy dog", "6b53aa2e51055da429653b43565b187d")]
        public void TestForMd5(string plain, string crypted)
        {
            string encrypted = Fancy.Cipher.MD5.Encode(plain, "pepper");

            Assert.AreEqual(crypted, encrypted);
        }
    }
}
