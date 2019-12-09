using ByteBee.Numerics;
using NUnit.Framework;

namespace ByteBeeTests.Numerics.Logarithm
{
    public class TestCustomBase
    {
        [Test]
        public void EveryLogarithmIsMinusOneToTheSameFraction()
        {
            for (int i = 2; i <= 100; i++)
            {
                double actual = MathLogarithm.BaseN(1 / (double) i, i);
                Assert.AreEqual(-1, actual, MathConstant.Epsilon, $"failed at {i}");
            }
        }

        [Test]
        public void EveryLogarithmIsZeroToOneBase()
        {
            for (int i = 2; i <= 100; i++)
            {
                double actual = MathLogarithm.BaseN(1, i);
                Assert.AreEqual(0, actual, MathConstant.Epsilon, $"failed at {i}");
            }
        }

        [Test]
        public void Log3Of27Is3()
        {
            double actual = MathLogarithm.Base3(27);
            Assert.AreEqual(3, actual, MathConstant.Epsilon);
        }
    }
}