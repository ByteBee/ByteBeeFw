using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KukSoft.ToolKit.Extension;
using NUnit.Framework;

namespace KukSoft.ToolKit.Extensions.Tests
{
    [TestFixture]
    class StringExtTests
    {
        [Test]
        public void TestIsNullOrEmpty()
        {
            string nullString = null;

            Assert.IsTrue("   ".IsNullOrEmpty());
            Assert.IsTrue("".IsNullOrEmpty());
            Assert.IsTrue(string.Empty.IsNullOrEmpty());
            Assert.IsTrue(nullString.IsNullOrEmpty());
            Assert.IsTrue(nullString.IsNullOrEmpty());
            Assert.IsFalse("foobar".IsNullOrEmpty());
        }

        [Test]
        public void TestIsNullThenEmpty()
        {
            string nullString = null;

            Assert.AreEqual(nullString.IsNullThenEmpty(), string.Empty);
            Assert.AreEqual(string.Empty.IsNullThenEmpty(), string.Empty);
            Assert.AreEqual(" ".IsNullThenEmpty(), " ");
            Assert.AreEqual("foobar".IsNullThenEmpty(), "foobar");
            Assert.AreNotEqual("foobar".IsNullThenEmpty(), string.Empty);
        }

        [Test]
        public void TestIsNullThen()
        {
            string nullString = null;

            Assert.AreEqual(nullString.IsNullThen("foobar"), "foobar");
            Assert.AreEqual("foo".IsNullThen("bar"), "foo");
        }

        [Test]
        public void TestRight()
        {
            string testString = "a quick brown fox jumps over the lazy dog";

            Assert.That(testString.Right(8), Is.EqualTo("lazy dog"));
        }

        [Test]
        public void TestLeft()
        {
            string testString = "a quick brown fox jumps over the lazy dog";

            Assert.That(testString.Left(7), Is.EqualTo("a quick"));
        }

        [Test]
        public void TestStrip()
        {
            string testString = "a quick brown fox jumps over the lazy dog";
            string toRemove = "brown ";
            string expected = "a quick fox jumps over the lazy dog";

            Assert.That(testString.Strip(toRemove), Is.EqualTo(expected));
        }

        [Test]
        public void TestFormated()
        {
            string testString = "a quick {0} fox jumps over the {1} dog";
            string fstArg = "brown";
            string sndArg = "lazy";
            string expected1 = "a quick brown fox jumps over the lazy dog";
            string expected2 = "a quick lazy fox jumps over the brown dog";

            Assert.That(testString.Formated(fstArg, sndArg), Is.EqualTo(expected1));
            Assert.That(testString.Formated(sndArg, fstArg), Is.EqualTo(expected2));
        }
    }
}
