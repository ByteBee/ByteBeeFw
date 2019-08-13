using System;
using ByteBee;
using ByteBee.Enums.Impl;
using ByteBee.Numerics;
using FluentAssertions;
using NUnit.Framework;

namespace ByteBeeTests.Numerics.TrigTests
{
    public sealed class TestArcusFunc
    {
        #region arcus sine

        [TestCase(-Math.PI / 2, -1)]                 // -90°
        [TestCase(-Math.PI / 3, -0.8660254037844)]   // -60°
        [TestCase(-Math.PI / 4, -0.7071067811865)]   // -45°
        [TestCase(-Math.PI / 6, -0.5)]               // -30°
        [TestCase(0, 0)]
        [TestCase(Math.PI / 6, 0.5)]                // 30°
        [TestCase(Math.PI / 4, 0.7071067811865)]    // 45°
        [TestCase(Math.PI / 3, 0.8660254037844)]    // 60°
        [TestCase(Math.PI / 2, 1)]                  // 90°
        public void TestArcusSine(double expected, double theta)
        {
            Trig.Asin(theta)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }

        [TestCase(-Math.PI / 2, -1)]                 // -90°
        [TestCase(-Math.PI / 3, -0.8660254037844)]   // -60°
        [TestCase(-Math.PI / 4, -0.7071067811865)]   // -45°
        [TestCase(-Math.PI / 6, -0.5)]               // -30°
        [TestCase(0, 0)]
        [TestCase(Math.PI / 6, 0.5)]                // 30°
        [TestCase(Math.PI / 4, 0.7071067811865)]    // 45°
        [TestCase(Math.PI / 3, 0.8660254037844)]    // 60°
        [TestCase(Math.PI / 2, 1)]                  // 90°
        public void TestArcusSineRad(double expected, double theta)
        {
            Trig.Asin(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }

        [TestCase(-1, -90)]
        [TestCase(-0.8660254037844, -60)]
        [TestCase(-0.7071067811865, -45)]
        [TestCase(-0.5, -30)]
        [TestCase(0, 0)]
        [TestCase(0.5, 30)]
        [TestCase(0.7071067811865, 45)]
        [TestCase(0.8660254037844, 60)]
        [TestCase(1, 90)]
        public void TestArcusSineDeg(double theta, double expected)
        {
            Trig.Asin(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }

        #endregion

        #region arcus cosine

        [TestCase(-1, Math.PI)]
        [TestCase(-0.8660254037844, 5 * Math.PI / 6)]
        [TestCase(-0.7071067811865, 3 * Math.PI / 4)]
        [TestCase(-0.5, 2 * Math.PI / 3)]
        [TestCase(0, Math.PI / 2)]
        [TestCase(0.5, Math.PI / 3)]
        [TestCase(0.7071067811865, Math.PI / 4)]
        [TestCase(0.8660254037844, Math.PI / 6)]
        [TestCase(1, 0)]
        public void TestArcusCosine(double theta, double expected)
        {
            Trig.Acos(theta)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }


        [TestCase(-1, Math.PI)]
        [TestCase(-0.8660254037844, 5 * Math.PI / 6)]
        [TestCase(-0.7071067811865, 3 * Math.PI / 4)]
        [TestCase(-0.5, 2 * Math.PI / 3)]
        [TestCase(0, Math.PI / 2)]
        [TestCase(0.5, Math.PI / 3)]
        [TestCase(0.7071067811865, Math.PI / 4)]
        [TestCase(0.8660254037844, Math.PI / 6)]
        [TestCase(1, 0)]
        public void TestArcusCosineRad(double theta, double expected)
        {
            Trig.Acos(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }

        [TestCase(-1, 180)]
        [TestCase(-0.8660254037844, 150)]
        [TestCase(-0.7071067811865, 135)]
        [TestCase(-0.5, 120)]
        [TestCase(0, 90)]
        [TestCase(0.5, 60)]
        [TestCase(0.7071067811865, 45)]
        [TestCase(0.8660254037844, 30)]
        [TestCase(1, 0)]
        public void TestArcusCosineDeg(double theta, double expected)
        {
            Trig.Acos(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }

        #endregion

        #region arcus tangent

        [TestCase(-1.732050808, -Math.PI / 3)]
        [TestCase(-1, -Math.PI / 4)]
        [TestCase(-0.577350269, -Math.PI / 6)]
        [TestCase(0, 0)]
        [TestCase(0.577350269, Math.PI / 6)]
        [TestCase(1, Math.PI / 4)]
        [TestCase(1.732050808, Math.PI / 3)]
        public void TestArcusTangent(double theta, double expected)
        {
            Trig.Atan(theta)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }

        [TestCase(-1.732050808, -Math.PI / 3)]
        [TestCase(-1, -Math.PI / 4)]
        [TestCase(-0.577350269, -Math.PI / 6)]
        [TestCase(0, 0)]
        [TestCase(0.577350269, Math.PI / 6)]
        [TestCase(1, Math.PI / 4)]
        [TestCase(1.732050808, Math.PI / 3)]
        public void TestArcusTangentRad(double theta, double expected)
        {
            Trig.Atan(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }

        [TestCase(-1.732050808, -60)]
        [TestCase(-1, -45)]
        [TestCase(-0.577350269, -30)]
        [TestCase(0, 0)]
        [TestCase(0.577350269, 30)]
        [TestCase(1, 45)]
        [TestCase(1.732050808, 60)]
        public void TestArcusTangentDeg(double theta, double expected)
        {
            Trig.Atan(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }

        #endregion

        #region arcus cosecant

        [TestCase(-Math.PI / 2, -1)]
        [TestCase(-Math.PI / 3, -1.1547005383793)]
        [TestCase(-Math.PI / 4, -1.4142135623731)]
        [TestCase(-Math.PI / 6, -2)]
        [TestCase(Math.PI / 6, 2)]
        [TestCase(Math.PI / 4, 1.4142135623731)]
        [TestCase(Math.PI / 3, 1.1547005383793)]
        [TestCase(Math.PI / 2, 1)]
        public void TestArcusCosecant(double expected, double theta)
        {
            Trig.Acsc(theta)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }


        [TestCase(-Math.PI / 2, -1)]
        [TestCase(-Math.PI / 3, -1.1547005383793)]
        [TestCase(-Math.PI / 4, -1.4142135623731)]
        [TestCase(-Math.PI / 6, -2)]
        [TestCase(Math.PI / 6, 2)]
        [TestCase(Math.PI / 4, 1.4142135623731)]
        [TestCase(Math.PI / 3, 1.1547005383793)]
        [TestCase(Math.PI / 2, 1)]
        public void TestArcusCosecantRad(double expected, double theta)
        {
            Trig.Acsc(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }

        [TestCase(-90, -1)]
        [TestCase(-30, -2)]
        [TestCase(30, 2)]
        [TestCase(90, 1)]
        public void TestArcusCosecantDeg(double expected, double theta)
        {
            Trig.Acsc(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }

        #endregion

        #region arcus secant

        [TestCase(0, 1)]
        [TestCase(Math.PI / 6, 1.1547005383793)]
        [TestCase(Math.PI / 4, 1.4142135623731)]
        [TestCase(Math.PI / 3, 2)]
        public void TestArcusSecant(double expected, double theta)
        {
            Trig.Asec(theta)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }

        [TestCase(0, 1)]
        [TestCase(Math.PI / 6, 1.1547005383793)]
        [TestCase(Math.PI / 4, 1.4142135623731)]
        [TestCase(Math.PI / 3, 2)]
        public void TestArcusSecantRad(double expected, double theta)
        {
            Trig.Asec(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }


        [TestCase(0, 1)]
        [TestCase(180, -1)]
        [TestCase(15, 1.0352761804101)]
        [TestCase(30, 1.1547005383793)]
        [TestCase(45, 1.4142135623731)]
        [TestCase(60, 2)]
        public void TestArcusSecantDeg(double expected, double theta)
        {
            Trig.Asec(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }

        #endregion

        #region arcus cotangent

        [TestCase(Math.PI / 6, 1.7320508075689)]    // 30°
        [TestCase(Math.PI / 4, 1)]    // 45°
        [TestCase(Math.PI / 3, 0.5773502691896)]
        [TestCase(Math.PI / 2, 0)]
        public void TestArcusCotangent(double expected, double theta)
        {
            Trig.Acot(theta)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }

        [TestCase(Math.PI / 6, 1.7320508075689)]    // 30°
        [TestCase(Math.PI / 4, 1)]    // 45°
        [TestCase(Math.PI / 3, 0.5773502691896)]
        [TestCase(Math.PI / 2, 0)]
        public void TestArcusCotangentRad(double expected, double theta)
        {
            Trig.Acot(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }


        [TestCase(45, 1)]
        [TestCase(90, 0)]
        [TestCase(135, -1)]
        public void TestArcusCotangentDeg(double expected, double theta)
        {
            Trig.Acot(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        }

        #endregion

    }
}