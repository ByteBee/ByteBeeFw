using ByteBee.Numerics;
using NUnit.Framework;

namespace ByteBeeTests.Numerics.Logarithm
{
    public sealed class TestBase10
    {
        [Test]
        public void Given_10Over1_Then_Minus1()
        {
            CheckFor(1 / 10d, -1);
        }

        [Test]
        public void Given_1_Then_0()
        {
            CheckFor(1, 0);
        }

        [Test]
        public void Given_10_Then_1()
        {
            CheckFor(10, 1);
        }

        [Test]
        public void Given_100_Then_2()
        {
            CheckFor(100, 2);
        }

        [Test]
        public void Given_1000_Then_3()
        {
            CheckFor(1000, 3);
        }

        [Test]
        public void Given_10000_Then_4()
        {
            CheckFor(10000, 4);
        }

        private void CheckFor(double number, double expected)
        {
            double actual = MathLogarithm.Base10(number);
            Assert.AreEqual(expected, actual, MathConstant.Epsilon);
        }
    }
}