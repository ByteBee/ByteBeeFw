using ByteBee.Numerics;
using NUnit.Framework;

namespace ByteBeeTests.Numerics.Logarithm
{
    public sealed class TestBase2
    {
        [Test]
        public void Given_2Over1_Then_Minus1()
        {
            CheckFor(1 / 2d, -1);
        }

        [Test]
        public void Given_1_Then_0()
        {
            CheckFor(1, 0);
        }

        [Test]
        public void Given_2_Then_1()
        {
            CheckFor(2, 1);
        }

        [Test]
        public void Given_4_Then_2()
        {
            CheckFor(4, 2);
        }

        [Test]
        public void Given_8_Then_3()
        {
            CheckFor(8, 3);
        }

        [Test]
        public void Given_16_Then_4()
        {
            CheckFor(16, 4);
        }

        [Test]
        public void Given_1024_Then_10()
        {
            CheckFor(1024, 10);
        }

        private void CheckFor(double number, double expected)
        {
            double actual = MathLogarithm.Base2(number);
            Assert.AreEqual(expected, actual, MathConstant.Epsilon);
        }
    }
}