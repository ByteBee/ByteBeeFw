using System;
using ByteBee;
using ByteBee.Utilities.Guard;
using NUnit.Framework;

namespace ByteBeeTests.DataTypes
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
                Bee.Guard.AgainstNegative(senseOfLife);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                Bee.Guard.AgainstNegative(-senseOfLife);
            });
        }

        [Test]
        public void DoesNothingGivenNonNullValue()
        {

            Bee.Guard.Against.Null("", "string");
            Bee.Guard.Against.Null(1, "int");
            Bee.Guard.Against.Null(Guid.Empty, "guid");
            Bee.Guard.Against.Null(DateTime.Now, "datetime");
            Bee.Guard.Against.Null(new object(), "object");

            Assert.Pass();
        }

        [Test]
        public void ThrowsGivenNullValue()
        {
            Assert.Throws<ArgumentNullException>(() => Bee.Guard.Against.Null(null, "null"));
        }

        [Test]
        public void DoesNothingGivenNonEmptyStringValue()
        {
            Bee.Guard.Against.NullOrEmpty("a", "string");
            Bee.Guard.Against.NullOrEmpty("1", "aNumericString");

            Assert.Pass();
        }

        [Test]
        public void ThrowsGivenNullValueUsing()
        {
            Assert.Throws<ArgumentNullException>(() => Bee.Guard.Against.NullOrEmpty(null, "null"));
        }

        [Test]
        public void ThrowsGivenEmptyString()
        {
            Assert.Throws<ArgumentException>(() => Bee.Guard.Against.NullOrEmpty("", "emptystring"));
        }

        [Test]
        public void DoesNothingGivenNonEmptyStringValueForOrEmpty()
        {
            Bee.Guard.Against.NullOrEmpty("a", "string");
            Bee.Guard.Against.NullOrEmpty("1", "aNumericString");

            Assert.Pass();
        }

        [Test]
        public void ThrowsGivenNullValueForOrEmpty()
        {
            Assert.Throws<ArgumentNullException>(() => Bee.Guard.Against.NullOrEmpty(null, "null"));
        }

        [Test]
        public void ThrowsGivenEmptyStringForOrEmpty()
        {
            Assert.Throws<ArgumentException>(() => Bee.Guard.Against.NullOrEmpty("", "emptystring"));
        }

        [TestCase("a")]
        [TestCase("1")]
        [TestCase("some text")]
        [TestCase(" leading whitespace")]
        [TestCase("trailing whitespace ")]
        public void DoesNothingGivenNonEmptyStringValue(string nonEmptyString)
        {
            Bee.Guard.Against.NullOrWhiteSpace(nonEmptyString, "string");
            Bee.Guard.Against.NullOrWhiteSpace(nonEmptyString, "aNumericString");

            Assert.Pass();
        }

        [Test]
        public void ThrowsGivenNullValueForOrWhiteSpace()
        {
            Assert.Throws<ArgumentNullException>(() => Bee.Guard.Against.NullOrWhiteSpace(null, "null"));
        }

        [Test]
        public void ThrowsGivenEmptyStringForOrWhiteSpace()
        {
            Assert.Throws<ArgumentException>(() => Bee.Guard.Against.NullOrWhiteSpace("", "emptystring"));
        }

        [TestCase(" ")]
        [TestCase("   ")]
        public void ThrowsGivenWhiteSpaceString(string whiteSpaceString)
        {
            Assert.Throws<ArgumentException>(() => Bee.Guard.Against.NullOrWhiteSpace(whiteSpaceString, "whitespacestring"));
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
            Bee.Guard.Against.OutOfRange(input, "index", rangeFrom, rangeTo);

            Assert.Pass();
        }

        [TestCase(1, 3)]
        [TestCase(-4, -3)]
        public void ThrowsGivenOutOfRangeValue(int rangeFromOffset, int rangeToOffset)
        {
            DateTime input = DateTime.Now;
            DateTime rangeFrom = input.AddSeconds(rangeFromOffset);
            DateTime rangeTo = input.AddSeconds(rangeToOffset);
            Assert.Throws<ArgumentOutOfRangeException>(() => Bee.Guard.Against.OutOfRange(input, "index", rangeFrom, rangeTo));
        }

        [TestCase(3, 1)]
        [TestCase(3, -1)]
        public void ThrowsGivenInvalidArgumentValue(int rangeFromOffset, int rangeToOffset)
        {
            DateTime input = DateTime.Now;
            DateTime rangeFrom = input.AddSeconds(rangeFromOffset);
            DateTime rangeTo = input.AddSeconds(rangeToOffset);
            Assert.Throws<ArgumentException>(() => Bee.Guard.Against.OutOfRange(DateTime.Now, "index", rangeFrom, rangeTo));
        }

        [TestCase(1, 1, 1)]
        [TestCase(1, 1, 3)]
        [TestCase(2, 1, 3)]
        [TestCase(3, 1, 3)]
        public void DoesNothingGivenInRangeValue(int input, int rangeFrom, int rangeTo)
        {
            Bee.Guard.Against.OutOfRange(input, "index", rangeFrom, rangeTo);

            Assert.Pass();
        }

        [TestCase(-1, 1, 3)]
        [TestCase(0, 1, 3)]
        [TestCase(4, 1, 3)]
        public void ThrowsGivenOutOfRangeValue(int input, int rangeFrom, int rangeTo)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Bee.Guard.Against.OutOfRange(input, "index", rangeFrom, rangeTo));
        }

        [TestCase(-1, 3, 1)]
        [TestCase(0, 3, 1)]
        [TestCase(4, 3, 1)]
        public void ThrowsGivenInvalidArgumentValue(int input, int rangeFrom, int rangeTo)
        {
            Assert.Throws<ArgumentException>(() => Bee.Guard.Against.OutOfRange(input, "index", rangeFrom, rangeTo));
        }
    }

    static class GuardExtStub
    {
        public static void AgainstNegative(this IGuardClause guard, int n)
        {
            if (n < 0)
            {
                throw new ArgumentException($"{nameof(n)} is negative. This should not be so");
            }
        }
    }
}
