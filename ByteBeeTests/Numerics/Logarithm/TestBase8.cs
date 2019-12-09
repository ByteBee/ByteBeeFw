using ByteBee.Numerics;
using NUnit.Framework;

namespace ByteBeeTests.Numerics.Logarithm
{
    public sealed class TestBase8
    {
        [Test]
        public void Given_8Over1_Then_Minus1()
        {
            CheckFor(1 / 8d, -1);
        }

        [Test]
        public void Given_1_Then_0()
        {
            CheckFor(1, 0);
        }

        [Test]
        public void Given_8_Then_1()
        {
            CheckFor(8, 1);
        }

        [Test]
        public void Given_64_Then_2()
        {
            CheckFor(64, 2);
        }

        [Test]
        public void Given_512_Then_3()
        {
            CheckFor(512, 3);
        }

        [Test]
        public void Given_4096_Then_4()
        {
            CheckFor(4096, 4);
        }

        private void CheckFor(double number, double expected)
        {
            double actual = MathLogarithm.Base8(number);
            Assert.AreEqual(expected, actual, MathConstant.Epsilon);
        }
    }
}