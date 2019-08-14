using ByteBee.Core;
using ByteBee.Core.Enums;
using ByteBee.Core.Numerics;
using FluentAssertions;

namespace ByteBeeTests.Numerics.TrigTests
{
    public class TestAreaFunc
    {
        #region hyperbolic area sine

        public void TestHyperbolicAreaSine(double theta, double expected)
        {
            Trig.Asinh(theta)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicAreaSineRad(double theta, double expected)
        {
            Trig.Asinh(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicAreaSineDeg(double theta, double expected)
        {
            Trig.Asinh(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        #endregion

        #region hyperbolic area cosine

        public void TestHyperbolicAreaCosine(double theta, double expected)
        {
            Trig.Acosh(theta)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicAreaCosineRad(double theta, double expected)
        {
            Trig.Acosh(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicAreaCosineDeg(double theta, double expected)
        {
            Trig.Acosh(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        #endregion

        #region hyperbolic area tangent

        public void TestHyperbolicAreaTangent(double theta, double expected)
        {
            Trig.Atanh(theta)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicAreaTangentRad(double theta, double expected)
        {
            Trig.Atanh(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicAreaTangentDeg(double theta, double expected)
        {
            Trig.Atanh(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        #endregion

        #region hyperbolic area secant

        public void TestHyperbolicAreaSecant(double theta, double expected)
        {
            Trig.Asech(theta)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicAreaSecantRad(double theta, double expected)
        {
            Trig.Asech(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicAreaSecantDeg(double theta, double expected)
        {
            Trig.Asech(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        #endregion

        #region hyperbolic area cosecant

        public void TestHyperbolicAreaCosecant(double theta, double expected)
        {
            Trig.Acsch(theta)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicAreaCosecantRad(double theta, double expected)
        {
            Trig.Acsch(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicAreaCosecantDeg(double theta, double expected)
        {
            Trig.Acsch(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        #endregion

        #region hyperbolic area cotangent

        public void TestHyperbolicAreaCotangent(double theta, double expected)
        {
            Trig.Acoth(theta)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicAreaCotangentRad(double theta, double expected)
        {
            Trig.Acoth(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        public void TestHyperbolicAreaCotangentDeg(double theta, double expected)
        {
            Trig.Acoth(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        #endregion

    }
}