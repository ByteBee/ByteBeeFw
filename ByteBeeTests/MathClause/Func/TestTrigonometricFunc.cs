using System;
using ByteBee;
using ByteBee.Enums.Impl;
using ByteBee.MathClause;
using FluentAssertions;
using NUnit.Framework;

namespace ByteBeeTests.MathClause.Func
{
    [TestFixture]
    public class TestTrigonometricFunc
    {
        [TestCase(0, 0)]
        [TestCase(30, 0.5)]
        [TestCase(45, 0.7071067811865)]
        [TestCase(60, 0.8660254037844)]
        [TestCase(90, 1)]
        [TestCase(120, 0.8660254037844)]
        [TestCase(135, 0.7071067811865)]
        [TestCase(150, 0.5)]
        [TestCase(180, 0)]
        [TestCase(210, -0.5)]
        [TestCase(225, -0.7071067811865)]
        [TestCase(240, -0.8660254037844)]
        public void TestSineDeg(double theta, double sin)
        {
            Bee.Math.Sin(theta, AngleUnit.Deg)
                .Should().BeApproximately(sin, Bee.Math.Epsilon);
        }


        [TestCase(-Math.PI / 1, 0)]                  // 180°
        [TestCase(-Math.PI / 2, -1)]                 // -90°
        [TestCase(-Math.PI / 3, -0.8660254037844)]   // -60°
        [TestCase(-Math.PI / 4, -0.7071067811865)]   // -45°
        [TestCase(-Math.PI / 6, -0.5)]               // -30°
        [TestCase(0, 0)]
        [TestCase(Math.PI / 6, 0.5)]                // 30°
        [TestCase(Math.PI / 4, 0.7071067811865)]    // 45°
        [TestCase(Math.PI / 3, 0.8660254037844)]    // 60°
        [TestCase(Math.PI / 2, 1)]                  // 90°
        [TestCase(Math.PI / 1, 0)]                  // 180°
        public void TestSineRad(double theta, double expected)
        {
            Bee.Math.Sin(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }


        [TestCase(-180, -1)]
        [TestCase(-150, -0.8660254037844)]
        [TestCase(-120, -0.5)]
        [TestCase(-90, 0)]
        [TestCase(-60, 0.5)]
        [TestCase(-30, 0.8660254037844)]
        [TestCase(0, 1)]
        [TestCase(30, 0.8660254037844)]
        [TestCase(60, 0.5)]
        [TestCase(90, 0)]
        [TestCase(120, -0.5)]
        [TestCase(150, -0.8660254037844)]
        [TestCase(180, -1)]
        public void TestCosineDeg(double theta, double cos)
        {
            Bee.Math.Cos(theta, AngleUnit.Deg)
                .Should().BeApproximately(cos, Bee.Math.Epsilon);
        }

        [TestCase(-Math.PI / 1, -1)]                // -180°
        [TestCase(-Math.PI / 2, 0)]                 // -90°
        [TestCase(-Math.PI / 3, 0.5)]               // -60°
        [TestCase(-Math.PI / 4, 0.7071067811865)]   // -45°
        [TestCase(-Math.PI / 6, 0.8660254037844)]   // -30°
        [TestCase(0, 1)]
        [TestCase(Math.PI / 6, 0.8660254037844)]    // 30°
        [TestCase(Math.PI / 4, 0.7071067811865)]    // 45°
        [TestCase(Math.PI / 3, 0.5)]                // 60°
        [TestCase(Math.PI / 2, 0)]                  // 90°
        [TestCase(Math.PI / 1, -1)]                 // 180°
        public void TestCosineRad(double theta, double cos)
        {
            Bee.Math.Cos(theta, AngleUnit.Rad)
                .Should().BeApproximately(cos, Bee.Math.Epsilon);
        }

        [TestCase(-Math.PI / 1, 0)]
        [TestCase(-Math.PI / 3, -1.732050808)]
        [TestCase(-Math.PI / 4, -1)]
        [TestCase(-Math.PI / 6, -0.577350269)]
        [TestCase(0, 0)]
        [TestCase(Math.PI / 6, 0.577350269)]
        [TestCase(Math.PI / 4, 1)]
        [TestCase(Math.PI / 3, 1.732050808)]
        [TestCase(Math.PI / 1, 0)]
        public void TestTangentRad(double theta, double tan)
        {
            Bee.Math.Tan(theta, AngleUnit.Rad)
                .Should().BeApproximately(tan, Bee.Math.Epsilon);
        }

        [TestCase(-180, 0)]
        [TestCase(-150, 0.5773502691896)]
        [TestCase(-120, 1.7320508075689)]
        //[TestCase(-90, double.PositiveInfinity)]
        [TestCase(-60, -1.7320508075689)]
        [TestCase(-30, -0.5773502691896)]
        [TestCase(0, 0)]
        [TestCase(30, 0.5773502691896)]
        [TestCase(45, 1)]
        [TestCase(60, 1.7320508075689)]
        //[TestCase(90, double.PositiveInfinity)]
        [TestCase(120, -1.7320508075689)]
        [TestCase(135, -1)]
        [TestCase(150, -0.5773502691896)]
        [TestCase(180, 0)]
        public void TestTangentDeg(double theta, double tan)
        {
            Bee.Math.Tan(theta, AngleUnit.Deg)
                .Should().BeApproximately(tan, Bee.Math.Epsilon);
        }

        [TestCase(-180, -1)]
        [TestCase(-120, -2)]
        [TestCase(-60, 2)]
        [TestCase(-45, 1.4142135623731)]
        [TestCase(-30, 1.1547005383793)]
        [TestCase(-15, 1.0352761804101)]
        [TestCase(0, 1)]
        [TestCase(15, 1.0352761804101)]
        [TestCase(30, 1.1547005383793)]
        [TestCase(45, 1.4142135623731)]
        [TestCase(60, 2)]
        [TestCase(120, -2)]
        [TestCase(180, -1)]
        public void TestSecantDeg(double theta, double expected)
        {
            Bee.Math.Sec(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        [TestCase(-Math.PI / 1, -1)]
        [TestCase(-Math.PI / 3, 2)]
        [TestCase(-Math.PI / 4, 1.4142135623731)]
        [TestCase(-Math.PI / 6, 1.1547005383793)]
        [TestCase(0, 1)]
        [TestCase(Math.PI / 6, 1.1547005383793)]
        [TestCase(Math.PI / 4, 1.4142135623731)]
        [TestCase(Math.PI / 3, 2)]
        [TestCase(Math.PI / 1, -1)]
        public void TestSecantRad(double theta, double expected)
        {
            Bee.Math.Sec(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }


        [TestCase(-330, 2)]
        [TestCase(-270, 1)]
        [TestCase(-210, 2)]
        [TestCase(-150, -2)]
        [TestCase(-90, -1)]
        [TestCase(-30, -2)]
        [TestCase(30, 2)]
        [TestCase(90, 1)]
        [TestCase(150, 2)]
        [TestCase(210, -2)]
        [TestCase(270, -1)]
        [TestCase(330, -2)]
        public void TestCosecantDeg(double theta, double expected)
        {
            Bee.Math.Csc(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        [TestCase(-Math.PI / 2, -1)]
        [TestCase(-Math.PI / 3, -1.1547005383793)]
        [TestCase(-Math.PI / 4, -1.4142135623731)]
        [TestCase(-Math.PI / 6, -2)]
        [TestCase(Math.PI / 6, 2)]
        [TestCase(Math.PI / 4, 1.4142135623731)]
        [TestCase(Math.PI / 3, 1.1547005383793)]
        [TestCase(Math.PI / 2, 1)]
        public void TestCosecantRad(double theta, double expected)
        {
            Bee.Math.Csc(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }


        [TestCase(-315, 1)]
        [TestCase(-270, 0)]
        [TestCase(-225, -1)]
        [TestCase(-135, 1)]
        [TestCase(-90, 0)]
        [TestCase(-45, -1)]
        [TestCase(45, 1)]
        [TestCase(90, 0)]
        [TestCase(135, -1)]
        [TestCase(225, 1)]
        [TestCase(270, 0)]
        [TestCase(315, -1)]
        public void TestCotangentDeg(double theta, double expected)
        {
            Bee.Math.Cot(theta, AngleUnit.Deg)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }

        [TestCase(-Math.PI / 2, 0)]
        [TestCase(-Math.PI / 3, -0.5773502691896)]
        [TestCase(-Math.PI / 4, -1)]   // -45°
        [TestCase(-Math.PI / 6, -1.7320508075689)]   // -30°
        [TestCase(Math.PI / 6, 1.7320508075689)]    // 30°
        [TestCase(Math.PI / 4, 1)]    // 45°
        [TestCase(Math.PI / 3, 0.5773502691896)]
        [TestCase(Math.PI / 2, 0)]              
        public void TestCotangentRad(double theta, double expected)
        {
            Bee.Math.Cot(theta, AngleUnit.Rad)
                .Should().BeApproximately(expected, Bee.Math.Epsilon);
        }
    }
}