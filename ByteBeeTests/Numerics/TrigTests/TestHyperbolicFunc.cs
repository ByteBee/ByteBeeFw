using ByteBee;
using ByteBee.Core;
using ByteBee.Core.Enums;
using ByteBee.Core.Numerics;
using FluentAssertions;

namespace ByteBeeTests.Numerics.TrigTests
{
    public class TestHyperbolicFunc
    {
        #region hyperbolic sine

        public void TestHyperbolicSine(double theta, double expected)
        {
            Trig.Sinh(theta)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicSineRad(double theta, double expected)
        {
            Trig.Sinh(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicSineDeg(double theta, double expected)
        {
            Trig.Sinh(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        #endregion

        #region hyperbolic cosine

        public void TestHyperbolicCosine(double theta, double expected)
        {
            Trig.Cosh(theta)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicCosineRad(double theta, double expected)
        {
            Trig.Cosh(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicCosineDeg(double theta, double expected)
        {
            Trig.Cosh(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        #endregion

        #region hyperbolic tangent

        public void TestHyperbolicTangent(double theta, double expected)
        {
            Trig.Tanh(theta)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicTangentRad(double theta, double expected)
        {
            Trig.Tanh(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicTangentDeg(double theta, double expected)
        {
            Trig.Tanh(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        #endregion

        #region hyperbolic secant

        public void TestHyperbolicSecant(double theta, double expected)
        {
            Trig.Sech(theta)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicSecantRad(double theta, double expected)
        {
            Trig.Sech(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicSecantDeg(double theta, double expected)
        {
            Trig.Sech(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        #endregion

        #region hyperbolic cosecant

        public void TestHyperbolicCosecant(double theta, double expected)
        {
            Trig.Csch(theta)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicCosecantRad(double theta, double expected)
        {
            Trig.Csch(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicCosecantDeg(double theta, double expected)
        {
            Trig.Csch(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        #endregion

        #region hyperbolic cotangent

        public void TestHyperbolicCotangent(double theta, double expected)
        {
            Trig.Coth(theta)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicCotangentRad(double theta, double expected)
        {
            Trig.Coth(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicCotangentDeg(double theta, double expected)
        {
            Trig.Coth(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        #endregion
    }
}