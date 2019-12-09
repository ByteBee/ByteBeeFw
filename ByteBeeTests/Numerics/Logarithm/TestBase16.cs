using ByteBee.Numerics;
using NUnit.Framework;

namespace ByteBeeTests.Numerics.Logarithm
{
    public sealed class TestBase16
    {
        [Test]
        public void Given_16Over1_Then_Minus1()
        {
            CheckFor(1 / 16d, -1);
        }

        [Test]
        public void Given_1_Then_0()
        {
            CheckFor(1, 0);
        }

        [Test]
        public void Given_16_Then_1()
        {
            CheckFor(16, 1);
        }

        [Test]
        public void Given_256_Then_2()
        {
            CheckFor(256, 2);
        }

        [Test]
        public void Given_4096_Then_3()
        {
            CheckFor(4096, 3);
        }
        
        private void CheckFor(double number, double expected)
        {
            double actual = MathLogarithm.Base16(number);
            Assert.AreEqual(expected, actual, MathConstant.Epsilon);
        }
    }
}