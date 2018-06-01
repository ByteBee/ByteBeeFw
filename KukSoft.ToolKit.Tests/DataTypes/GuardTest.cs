using KukSoft.ToolKit.Utilities;
using NUnit.Framework;
using System;

namespace KukSoft.ToolKit.DataTypes.Tests
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
                Fancy.Guard.AgainstNegative(senseOfLife);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                Fancy.Guard.AgainstNegative(-senseOfLife);
            });
        }

        [Test]
        public void DoesNothingGivenNonNullValue()
        {
            Fancy.Guard.AgainstNull("", "string");
            Fancy.Guard.AgainstNull(1, "int");
            Fancy.Guard.AgainstNull(Guid.Empty, "guid");
            Fancy.Guard.AgainstNull(DateTime.Now, "datetime");
            Fancy.Guard.AgainstNull(new Object(), "object");

            Assert.Pass();
        }

        [Test]
        public void ThrowsGivenNullValue()
        {
            Assert.Throws<ArgumentNullException>(() => Fancy.Guard.AgainstNull(null, "null"));
        }

        [Test]
        public void DoesNothingGivenNonEmptyStringValue()
        {
            Fancy.Guard.AgainstNullOrEmpty("a", "string");
            Fancy.Guard.AgainstNullOrEmpty("1", "aNumericString");

            Assert.Pass();
        }

        [Test]
        public void ThrowsGivenNullValueUsing()
        {
            Assert.Throws<ArgumentNullException>(() => Fancy.Guard.AgainstNullOrEmpty(null, "null"));
        }

        [Test]
        public void ThrowsGivenEmptyString()
        {
            Assert.Throws<ArgumentException>(() => Fancy.Guard.AgainstNullOrEmpty("", "emptystring"));
        }

        [Test]
        public void DoesNothingGivenNonEmptyStringValueForOrEmpty()
        {
            Fancy.Guard.AgainstNullOrEmpty("a", "string");
            Fancy.Guard.AgainstNullOrEmpty("1", "aNumericString");

            Assert.Pass();
        }

        [Test]
        public void ThrowsGivenNullValueForOrEmpty()
        {
            Assert.Throws<ArgumentNullException>(() => Fancy.Guard.AgainstNullOrEmpty(null, "null"));
        }

        [Test]
        public void ThrowsGivenEmptyStringForOrEmpty()
        {
            Assert.Throws<ArgumentException>(() => Fancy.Guard.AgainstNullOrEmpty("", "emptystring"));
        }

        [TestCase("a")]
        [TestCase("1")]
        [TestCase("some text")]
        [TestCase(" leading whitespace")]
        [TestCase("trailing whitespace ")]
        public void DoesNothingGivenNonEmptyStringValue(string nonEmptyString)
        {
            Fancy.Guard.AgainstNullOrWhiteSpace(nonEmptyString, "string");
            Fancy.Guard.AgainstNullOrWhiteSpace(nonEmptyString, "aNumericString");

            Assert.Pass();
        }

        [Test]
        public void ThrowsGivenNullValueForOrWhiteSpace()
        {
            Assert.Throws<ArgumentNullException>(() => Fancy.Guard.AgainstNullOrWhiteSpace(null, "null"));
        }

        [Test]
        public void ThrowsGivenEmptyStringForOrWhiteSpace()
        {
            Assert.Throws<ArgumentException>(() => Fancy.Guard.AgainstNullOrWhiteSpace("", "emptystring"));
        }

        [TestCase(" ")]
        [TestCase("   ")]
        public void ThrowsGivenWhiteSpaceString(string whiteSpaceString)
        {
            Assert.Throws<ArgumentException>(() => Fancy.Guard.AgainstNullOrWhiteSpace(whiteSpaceString, "whitespacestring"));
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
            Fancy.Guard.AgainstOutOfRange(input, "index", rangeFrom, rangeTo);

            Assert.Pass();
        }

        [TestCase(1, 3)]
        [TestCase(-4, -3)]
        public void ThrowsGivenOutOfRangeValue(int rangeFromOffset, int rangeToOffset)
        {
            DateTime input = DateTime.Now;
            DateTime rangeFrom = input.AddSeconds(rangeFromOffset);
            DateTime rangeTo = input.AddSeconds(rangeToOffset);
            Assert.Throws<ArgumentOutOfRangeException>(() => Fancy.Guard.AgainstOutOfRange(input, "index", rangeFrom, rangeTo));
        }

        [TestCase(3, 1)]
        [TestCase(3, -1)]
        public void ThrowsGivenInvalidArgumentValue(int rangeFromOffset, int rangeToOffset)
        {
            DateTime input = DateTime.Now;
            DateTime rangeFrom = input.AddSeconds(rangeFromOffset);
            DateTime rangeTo = input.AddSeconds(rangeToOffset);
            Assert.Throws<ArgumentException>(() => Fancy.Guard.AgainstOutOfRange(DateTime.Now, "index", rangeFrom, rangeTo));
        }

        [TestCase(1, 1, 1)]
        [TestCase(1, 1, 3)]
        [TestCase(2, 1, 3)]
        [TestCase(3, 1, 3)]
        public void DoesNothingGivenInRangeValue(int input, int rangeFrom, int rangeTo)
        {
            Fancy.Guard.AgainstOutOfRange(input, "index", rangeFrom, rangeTo);

            Assert.Pass();
        }

        [TestCase(-1, 1, 3)]
        [TestCase(0, 1, 3)]
        [TestCase(4, 1, 3)]
        public void ThrowsGivenOutOfRangeValue(int input, int rangeFrom, int rangeTo)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Fancy.Guard.AgainstOutOfRange(input, "index", rangeFrom, rangeTo));
        }

        [TestCase(-1, 3, 1)]
        [TestCase(0, 3, 1)]
        [TestCase(4, 3, 1)]
        public void ThrowsGivenInvalidArgumentValue(int input, int rangeFrom, int rangeTo)
        {
            Assert.Throws<ArgumentException>(() => Fancy.Guard.AgainstOutOfRange(input, "index", rangeFrom, rangeTo));
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
