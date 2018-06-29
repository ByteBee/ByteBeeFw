using System;
using KukSoft.ToolKit.Utilities;
using NUnit.Framework;

namespace KukSoft.ToolKit.Tests.DataTypes
{
    [TestFixture]
    public class GuardTest
    {
        [Test]
        public void TestForCustomGuard()
        {
            int senseOfLife = 42;

            Assert.DoesNotThrow(() =>
            {
                Fancy.guard.AgainstNegative(senseOfLife);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                Fancy.guard.AgainstNegative(-senseOfLife);
            });
        }

        [Test]
        public void DoesNothingGivenNonNullValue()
        {

            Fancy.guard.AgainstNull("", "string");
            Fancy.guard.AgainstNull(1, "int");
            Fancy.guard.AgainstNull(Guid.Empty, "guid");
            Fancy.guard.AgainstNull(DateTime.Now, "datetime");
            Fancy.guard.AgainstNull(new Object(), "object");

            Assert.Pass();
        }

        [Test]
        public void ThrowsGivenNullValue()
        {
            Assert.Throws<ArgumentNullException>(() => Fancy.guard.AgainstNull(null, "null"));
        }

        [Test]
        public void DoesNothingGivenNonEmptyStringValue()
        {
            Fancy.guard.AgainstNullOrEmpty("a", "string");
            Fancy.guard.AgainstNullOrEmpty("1", "aNumericString");

            Assert.Pass();
        }

        [Test]
        public void ThrowsGivenNullValueUsing()
        {
            Assert.Throws<ArgumentNullException>(() => Fancy.guard.AgainstNullOrEmpty(null, "null"));
        }

        [Test]
        public void ThrowsGivenEmptyString()
        {
            Assert.Throws<ArgumentException>(() => Fancy.guard.AgainstNullOrEmpty("", "emptystring"));
        }

        [Test]
        public void DoesNothingGivenNonEmptyStringValueForOrEmpty()
        {
            Fancy.guard.AgainstNullOrEmpty("a", "string");
            Fancy.guard.AgainstNullOrEmpty("1", "aNumericString");

            Assert.Pass();
        }

        [Test]
        public void ThrowsGivenNullValueForOrEmpty()
        {
            Assert.Throws<ArgumentNullException>(() => Fancy.guard.AgainstNullOrEmpty(null, "null"));
        }

        [Test]
        public void ThrowsGivenEmptyStringForOrEmpty()
        {
            Assert.Throws<ArgumentException>(() => Fancy.guard.AgainstNullOrEmpty("", "emptystring"));
        }

        [TestCase("a")]
        [TestCase("1")]
        [TestCase("some text")]
        [TestCase(" leading whitespace")]
        [TestCase("trailing whitespace ")]
        public void DoesNothingGivenNonEmptyStringValue(string nonEmptyString)
        {
            Fancy.guard.AgainstNullOrWhiteSpace(nonEmptyString, "string");
            Fancy.guard.AgainstNullOrWhiteSpace(nonEmptyString, "aNumericString");

            Assert.Pass();
        }

        [Test]
        public void ThrowsGivenNullValueForOrWhiteSpace()
        {
            Assert.Throws<ArgumentNullException>(() => Fancy.guard.AgainstNullOrWhiteSpace(null, "null"));
        }

        [Test]
        public void ThrowsGivenEmptyStringForOrWhiteSpace()
        {
            Assert.Throws<ArgumentException>(() => Fancy.guard.AgainstNullOrWhiteSpace("", "emptystring"));
        }

        [TestCase(" ")]
        [TestCase("   ")]
        public void ThrowsGivenWhiteSpaceString(string whiteSpaceString)
        {
            Assert.Throws<ArgumentException>(() => Fancy.guard.AgainstNullOrWhiteSpace(whiteSpaceString, "whitespacestring"));
        }

        [TestCase(0, 0)]
        [TestCase(0, 3)]
        [TestCase(-1, 1)]
        [TestCase(-1, 0)]
        public void DoesNothingGivenInRangeValue(int rangeFromOffset, int rangeToOffset)
        {
            DateTime input = DateTime.Now;
            DateTime rangeFrom = input.AddSeconds(rangeFromOffset);
            DateTime rangeTo = input.AddSeconds(rangeToOffset);
            Fancy.guard.AgainstOutOfRange(input, "index", rangeFrom, rangeTo);

            Assert.Pass();
        }

        [TestCase(1, 3)]
        [TestCase(-4, -3)]
        public void ThrowsGivenOutOfRangeValue(int rangeFromOffset, int rangeToOffset)
        {
            DateTime input = DateTime.Now;
            DateTime rangeFrom = input.AddSeconds(rangeFromOffset);
            DateTime rangeTo = input.AddSeconds(rangeToOffset);
            Assert.Throws<ArgumentOutOfRangeException>(() => Fancy.guard.AgainstOutOfRange(input, "index", rangeFrom, rangeTo));
        }

        [TestCase(3, 1)]
        [TestCase(3, -1)]
        public void ThrowsGivenInvalidArgumentValue(int rangeFromOffset, int rangeToOffset)
        {
            DateTime input = DateTime.Now;
            DateTime rangeFrom = input.AddSeconds(rangeFromOffset);
            DateTime rangeTo = input.AddSeconds(rangeToOffset);
            Assert.Throws<ArgumentException>(() => Fancy.guard.AgainstOutOfRange(DateTime.Now, "index", rangeFrom, rangeTo));
        }

        [TestCase(1, 1, 1)]
        [TestCase(1, 1, 3)]
        [TestCase(2, 1, 3)]
        [TestCase(3, 1, 3)]
        public void DoesNothingGivenInRangeValue(int input, int rangeFrom, int rangeTo)
        {
            Fancy.guard.AgainstOutOfRange(input, "index", rangeFrom, rangeTo);

            Assert.Pass();
        }

        [TestCase(-1, 1, 3)]
        [TestCase(0, 1, 3)]
        [TestCase(4, 1, 3)]
        public void ThrowsGivenOutOfRangeValue(int input, int rangeFrom, int rangeTo)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Fancy.guard.AgainstOutOfRange(input, "index", rangeFrom, rangeTo));
        }

        [TestCase(-1, 3, 1)]
        [TestCase(0, 3, 1)]
        [TestCase(4, 3, 1)]
        public void ThrowsGivenInvalidArgumentValue(int input, int rangeFrom, int rangeTo)
        {
            Assert.Throws<ArgumentException>(() => Fancy.guard.AgainstOutOfRange(input, "index", rangeFrom, rangeTo));
        }
    }

    static class GuardExtStub
    {
        public static void AgainstNegative(this IGuard guard, int n)
        {
            if (n < 0)
            {
                throw new ArgumentException($"{nameof(n)} is negative. This should not be so");
            }
        }
    }
}
