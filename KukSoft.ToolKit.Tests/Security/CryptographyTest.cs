using NUnit.Framework;

namespace KukSoft.ToolKit.Security.Tests
{
    [TestFixture]
    public class CryptographyTest
    {
        [TestCase("", "c3be2d061fd88332148786aa4c27a7ef")]
        [TestCase("foobar", "95e913b20a38e3757173a50413b1d325")]
        [TestCase("my lazy dog", "3a8f2f4a052835eca52d37c47adf20af")]
        [TestCase("the quick brown fox", "d6d08792c028226211282bc48302f24b")]
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
