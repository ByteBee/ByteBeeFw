using ByteBee.Numerics;
using NUnit.Framework;

namespace ByteBeeTests.Numerics.Power
{
    [TestFixture]
    public class TestPowerFunc
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        [TestCase(5, 25)]
        [TestCase(10, 100)]
        [TestCase(42, 1764)]
        [TestCase(-5, 25)]
        public void Test_Pow2(double testCase, double expected)
        {
            double a = MathPower.Base2(testCase);
            Assert.AreEqual(expected, a);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 8)]
        [TestCase(5, 125)]
        [TestCase(10, 1000)]
        [TestCase(42, 74088)]
        [TestCase(-5, -125)]
        public void Test_Pow3(double testCase, double expected)
        {
            double a = MathPower.Base3(testCase);
            Assert.AreEqual(expected, a);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 256)]
        [TestCase(5, 390625)]
        [TestCase(10, 100000000)]
        [TestCase(42, 9682651996416)]
        [TestCase(-5, 390625)]
        public void Test_Pow8(double testCase, double expected)
        {
            double a = MathPower.Base8(testCase);
            Assert.AreEqual(expected, a);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1024)]
        [TestCase(5, 9765625)]
        [TestCase(10, 10000000000)]
        [TestCase(42, 17080198121677824)]
        [TestCase(-5, 9765625)]
        public void Test_Pow10(double testCase, double expected)
        {
            double a = MathPower.Base10(testCase);
            Assert.AreEqual(expected, a);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 65536)]
        [TestCase(5, 152587890625)]
        [TestCase(10, 1E+16)]
        [TestCase(42, 9.375374968369875E+25)]
        [TestCase(-5, 152587890625)]
        public void Test_Pow16(double testCase, double expected)
        {
            double a = MathPower.Base16(testCase);
            Assert.AreEqual(expected, a);
        }
    }
}