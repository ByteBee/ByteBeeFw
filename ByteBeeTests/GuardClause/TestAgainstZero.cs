using System;
using ByteBee;
using ByteBee.Core;
using ByteBee.Core.GuardClause;
using NUnit.Framework;

namespace ByteBeeTests.GuardClause
{
    [TestFixture]
    public sealed class TestAgainstZero
    {
        [Test]
        public void When_IntegerIsZero_Then_ShouldFail()
        {
            const int sut = 0;
            void PerformTest() => Bee.Guard.Zero(sut, "int was 0");
            Assert.Throws<ArgumentException>(PerformTest);
        }
        
        [Test]
        public void When_ShortIsZero_Then_ShouldFail()
        {
            const short sut = 0;
            void PerformTest() => Bee.Guard.Zero(sut, "short was 0");
            Assert.Throws<ArgumentException>(PerformTest);
        }

        [Test]
        public void When_LongIsZero_Then_ShouldFail()
        {
            const long sut = 0;
            void PerformTest() => Bee.Guard.Zero(sut, "long was 0");
            Assert.Throws<ArgumentException>(PerformTest);
        }

        [Test]
        public void When_FloatIsZero_Then_ShouldFail()
        {
            const float sut = 0;
            void PerformTest() => Bee.Guard.Zero(sut, "float was 0");
            Assert.Throws<ArgumentException>(PerformTest);
        }

        [Test]
        public void When_DoubleIsZero_Then_ShouldFail()
        {
            const double sut = 0;
            void PerformTest() => Bee.Guard.Zero(sut, "double was 0");
            Assert.Throws<ArgumentException>(PerformTest);
        }

        [Test]
        public void When_DecimalIsZero_Then_ShouldFail()
        {
            const decimal sut = 0;
            void PerformTest() => Bee.Guard.Zero(sut, "decimal was 0");
            Assert.Throws<ArgumentException>(PerformTest);
        }

        [Test]
        public void When_StructIsZero_Then_ShouldFail()
        {
            var sut = TimeSpan.Zero;
            void PerformTest() => Bee.Guard.Zero(sut, "struct was 0");
            Assert.Throws<ArgumentException>(PerformTest);
        }

        [Test]
        public void When_StructIsNotZero_Then_ShouldPass()
        {
            var sut = TimeSpan.FromMinutes(42);
            void PerformTest() => Bee.Guard.Zero(sut, "struct was 0");
            Assert.DoesNotThrow(PerformTest);
        }

        [Test]
        public void When_IntegerIsNotZero_Then_ShouldPass()
        {
            const int sut = 42;
            void PerformTest() => Bee.Guard.Zero(sut, "int was 0");
            Assert.DoesNotThrow(PerformTest);
        }

        [Test]
        public void When_ShortIsNotZero_Then_ShouldPass()
        {
            const short sut = 42;
            void PerformTest() => Bee.Guard.Zero(sut, "short was 0");
            Assert.DoesNotThrow(PerformTest);
        }

        [Test]
        public void When_LongIsNotZero_Then_ShouldPass()
        {
            const long sut = 42L;
            void PerformTest() => Bee.Guard.Zero(sut, "long was 0");
            Assert.DoesNotThrow(PerformTest);
        }

        [Test]
        public void When_FloatIsNotZero_Then_ShouldPass()
        {
            const float sut = 42f;
            void PerformTest() => Bee.Guard.Zero(sut, "float was 0");
            Assert.DoesNotThrow(PerformTest);
        }

        [Test]
        public void When_DoubleIsNotZero_Then_ShouldPass()
        {
            const double sut = 42d;
            void PerformTest() => Bee.Guard.Zero(sut, "double was 0");
            Assert.DoesNotThrow(PerformTest);
        }

        [Test]
        public void When_DecimalIsNotZero_Then_ShouldPass()
        {
            const decimal sut = 42m;
            void PerformTest() => Bee.Guard.Zero(sut, "decimal was 0");
            Assert.DoesNotThrow(PerformTest);
        }
    }
}