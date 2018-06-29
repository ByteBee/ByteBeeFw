using NUnit.Framework;

namespace KukSoft.ToolKit.Tests.Security
{
    [TestFixture]
    public class CryptographyTest
    {
        [TestCase("",                       "c3be2d061fd88332148786aa4c27a7ef")]
        [TestCase("foobar",                 "95e913b20a38e3757173a50413b1d325")]
        [TestCase("my lazy dog",            "3a8f2f4a052835eca52d37c47adf20af")]
        [TestCase("the quick brown fox",    "d6d08792c028226211282bc48302f24b")]
        public void TestForMd5(string plain, string crypted)
        {
            string encrypted = Fancy.encryption.MD5.Encode(plain);

            Assert.AreEqual(crypted, encrypted);
        }

        [TestCase("",                       "3ḀJJṪḻSẦṑzḝứṒẾàMḥẦṁḑỡÐḅĊỎḦṷḃỊpẕẽ")]
        [TestCase("foobar",                 "ḛ0HJẬĊṒẼEỊḓgṷẼḈQḭpḀỤỡFḋĆẶZĆếtệệỡ")]
        [TestCase("barfoo",                 "ự0Ỵ3ṇTḀḞAzỤAṃḴuẔṢẦḟḨỸFḓḵẍẬṝdỳḗệṓ")]
        [TestCase("foo",                    "Ṝ0ṅBṈỰḟẦḘiẊkpỎḔḫṯḊḀṻỡÐḅḵừṈụḗỠtệẎ")]
        [TestCase("bar",                    "Ṃ0ỏBẎṕṷỀḆỊḷĈḞḴỡḣḃḌḟCỸFḗḵỊJṭzệxệẎ")]
        [TestCase("my lazy dog",            "ḦḀḡBgĊIḂẂØḞEẆỎḠṇṡnḠỤỸÐċḱḄZḱlhḏẕỸ")]
        [TestCase("the quick brown fox",    "IḀZRỀḵḃḪṂdẾḈṚỘṒḐầIḠḨỡFỰĊṫJḫếṚxẕọ")]
        [TestCase("surprise encryption",    "ṓ0K3ẾḻḲṖeØṭEBḆẅḳṯḎṂḫỸFẊÇụ3ṣlẹÁệḛ")]
        public void TestForMyOwnCryptoThing(string plain, string crypted)
        {
            string encrypted = Fancy.encryption.Surprise.Encode(plain);

            Assert.AreEqual(crypted, encrypted);
        }
    }
}
