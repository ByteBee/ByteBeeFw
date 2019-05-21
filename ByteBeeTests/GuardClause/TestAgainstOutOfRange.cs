using System;
using ByteBee.GuardClause;
using NUnit.Framework;

namespace ByteBeeTests.GuardClause
{
    [TestFixture]
    public class TestAgainstOutOfRange
    {
        [Test]
        public void When_ValueIsInExactlyOnBounds_Then_ShouldPass()
        {
            void PerformTest() => Guard.Against.OutOfRange(7, 7, 7);
            Assert.DoesNotThrow(PerformTest);
        }

        [Test]
        public void When_ValueIsInExactlyOnUpperBounds_Then_ShouldPass()
        {
            void PerformTest() => Guard.Against.OutOfRange(7, 0, 7);
            Assert.DoesNotThrow(PerformTest);
        }

        [Test]
        public void When_ValueIsInExactlyOnLowerBounds_Then_ShouldPass()
        {
            void PerformTest() => Guard.Against.OutOfRange(0, 0, 7, "input was out of range");
            Assert.DoesNotThrow(PerformTest);
        }
        [Test]
        public void When_ValueIsOutsideLowerBound_Then_ThrowAnException()
        {
            void PerformTest() => Guard.Against.OutOfRange(-7, 0, 7, "input was out of range");
            Assert.Throws<ArgumentOutOfRangeException>(PerformTest);
        }

        [Test]
        public void When_ValueIsOutsideUpperBound_Then_ThrowAnException()
        {
            void PerformTest() => Guard.Against.OutOfRange(10, 0, 7);
            Assert.Throws<ArgumentOutOfRangeException>(PerformTest);
        }

        [Test]
        public void When_LowerAndUpperBoundAreSwitchedButWithinRange_Then_ShouldSwapBoundAndPass()
        {
            void PerformTest() => Guard.Against.OutOfRange(4, 7, 0);
            Assert.DoesNotThrow(PerformTest);
        }
    }
}