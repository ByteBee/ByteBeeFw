using ByteBee.Numerics;
using NUnit.Framework;

namespace ByteBeeTests.Numerics.Logarithm
{
    public sealed class TestBaseEuler
    {
        [Test]
        public void Given_EOver1_Then_Minus1()
        {
            CheckFor(1 / MathConstant.Euler, -1);
        }

        [Test]
        public void Given_1_Then_0()
        {
            CheckFor(1, 0);
        }

        [Test]
        public void Given_E_Then_1()
        {
            CheckFor(MathConstant.Euler, 1);
        }

        private void CheckFor(double number, double expected)
        {
            double actual = MathLogarithm.BaseE(number);
            Assert.AreEqual(expected, actual, MathConstant.Epsilon);
        }
    }
}