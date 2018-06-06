using NUnit.Framework;

namespace KukSoft.ToolKit.Security.Tests
{
    [TestFixture]
    public class CryptographyTest
    {
        [TestCase("", "c3be2d061fd88332148786aa4c27a7ef")]
        [TestCase("foobar", "17dbfa2f130a7c44e615b0eba5fb6f27")]
        [TestCase("my lazy dog", "b39a4224c86a441ec3b1c86fb1624043")]
        [TestCase("the quick brown fox", "750e40ddd834af47ad091eca94509c4e")]
        public void TestForMd5(string plain, string crypted)
        {
            string encrypted = Fancy.Encryption.MD5.Encode(plain);

            Assert.AreEqual(crypted, encrypted);
        }

        [TestCase("", "ḗḀỴJṰḻịẦČz2ứċẾṰMṵpẆḙḰṛoWeḊE0ḫ0ẾṞ")]
        [TestCase("foobar", "ḻ0ḱJhĊAẼừỊṖgṠẼẏQḛdṮṓṂựyYṘGḾ0ḣYẸḀ")]
        [TestCase("barfoo", "Ṡ053ḫTứḞṘzầA6Ḵ7ẔẏL5ḟḰṾyYeḟḈWḫYỡY")]
        [TestCase("foo", "Ṅ0ṬBJỰḖẦḎiNkỆỎHḫḇtṮṲḰGWYuḟḈfḩYỡẬ")]
        [TestCase("bar", "a0ḠBḟṕếỀṅỊṓĈḚḴẌḣẍJ5ṲḰḊO3ṘṼ6e5Wỡḣ")]
        [TestCase("my lazy dog", "ṺḀṑBÇĊṰḂMØṵEḶỎẋṇṵHṬ8ḰXyWṂ0kWṠ2ḳḤ")]
        [TestCase("the quick brown fox", "ỨḀṠRỸḵwḪấdSḈṳỘẼḐẏp5ḀḰðwXÀḀkWṞ0ḺḢ")]
        [TestCase("surprise encryption", "Ỡ0Ị3ỳḻaṖỘØḽEḎḆJḳṴ7ṬmṂṾQ0Ṃ0k0ḡYỆṡ")]
        public void TestForMyOwnCryptoThing(string plain, string crypted)
        {
            string encrypted = Fancy.Encryption.Surprise.Encode(plain);

            Assert.AreEqual(crypted, encrypted);
        }
    }
}
