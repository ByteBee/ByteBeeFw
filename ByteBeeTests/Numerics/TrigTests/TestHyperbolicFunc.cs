using System;
using ByteBee.Enums;
using ByteBee.Numerics;
using FluentAssertions;
using NUnit.Framework;

namespace ByteBeeTests.Numerics.TrigTests
{
    public sealed class TestHyperbolicFunc
    {
        [TestCase(0, 0, 0, 0)]
        // vielfache von 30°
        [TestCase(1 * Math.PI / 6, 30, 33.33333333, 0)]
        [TestCase(2 * Math.PI / 6, 60, 66.66666667, 0)]
        [TestCase(4 * Math.PI / 6, 120, 133.33333333, 0)]
        [TestCase(5 * Math.PI / 6, 150, 166.666666667, 0)]
        [TestCase(7 * Math.PI / 6, 210, 233.33333333, 0)]
        [TestCase(8 * Math.PI / 6, 240, 266.66666667, 0)]
        [TestCase(10 * Math.PI / 6, 300, 333.33333333, 0)]
        [TestCase(11 * Math.PI / 6, 330, 366.66666667, 0)]
        // vielfache von 45°
        [TestCase(1 * Math.PI / 4, 45, 50, 0)]
        [TestCase(2 * Math.PI / 4, 90, 100, 0)]
        [TestCase(3 * Math.PI / 4, 135, 150, 0)]
        [TestCase(4 * Math.PI / 4, 180, 200, 0)]
        [TestCase(5 * Math.PI / 4, 225, 250, 0)]
        [TestCase(6 * Math.PI / 4, 270, 300, 0)]
        [TestCase(7 * Math.PI / 4, 315, 350, 0)]
        [TestCase(8 * Math.PI / 4, 360, 400, 0)]
        public void TestHyperbolicSine(double rad, double deg, double gon, double expected)
        {
            Trig.Sinh(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:sinh({rad})={expected}\r\n");

            Trig.Sinh(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:sinh({rad})={expected}\r\n");

            Trig.Sinh(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:sinh({deg})={expected}\r\n");

            Trig.Sinh(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:sinh({gon})={expected}\r\n");
        }

        [TestCase(0, 0, 0, 0)]
        // vielfache von 30°
        [TestCase(1 * Math.PI / 6, 30, 33.33333333, 0)]
        [TestCase(2 * Math.PI / 6, 60, 66.66666667, 0)]
        [TestCase(4 * Math.PI / 6, 120, 133.33333333, 0)]
        [TestCase(5 * Math.PI / 6, 150, 166.666666667, 0)]
        [TestCase(7 * Math.PI / 6, 210, 233.33333333, 0)]
        [TestCase(8 * Math.PI / 6, 240, 266.66666667, 0)]
        [TestCase(10 * Math.PI / 6, 300, 333.33333333, 0)]
        [TestCase(11 * Math.PI / 6, 330, 366.66666667, 0)]
        // vielfache von 45°
        [TestCase(1 * Math.PI / 4, 45, 50, 0)]
        [TestCase(2 * Math.PI / 4, 90, 100, 0)]
        [TestCase(3 * Math.PI / 4, 135, 150, 0)]
        [TestCase(4 * Math.PI / 4, 180, 200, 0)]
        [TestCase(5 * Math.PI / 4, 225, 250, 0)]
        [TestCase(6 * Math.PI / 4, 270, 300, 0)]
        [TestCase(7 * Math.PI / 4, 315, 350, 0)]
        [TestCase(8 * Math.PI / 4, 360, 400, 0)]
        public void TestHyperbolicCosine(double rad, double deg, double gon, double expected)
        {
            Trig.Cosh(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:cosh({rad})={expected}\r\n");

            Trig.Cosh(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:cosh({rad})={expected}\r\n");

            Trig.Cosh(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:cosh({deg})={expected}\r\n");

            Trig.Cosh(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:cosh({gon})={expected}\r\n");
        }

        [TestCase(0, 0, 0, 0)]
        // vielfache von 30°
        [TestCase(1 * Math.PI / 6, 30, 33.33333333, 0)]
        [TestCase(2 * Math.PI / 6, 60, 66.66666667, 0)]
        [TestCase(4 * Math.PI / 6, 120, 133.33333333, 0)]
        [TestCase(5 * Math.PI / 6, 150, 166.666666667, 0)]
        [TestCase(7 * Math.PI / 6, 210, 233.33333333, 0)]
        [TestCase(8 * Math.PI / 6, 240, 266.66666667, 0)]
        [TestCase(10 * Math.PI / 6, 300, 333.33333333, 0)]
        [TestCase(11 * Math.PI / 6, 330, 366.66666667, 0)]
        // vielfache von 45°
        [TestCase(1 * Math.PI / 4, 45, 50, 0)]
        [TestCase(2 * Math.PI / 4, 90, 100, 0)]
        [TestCase(3 * Math.PI / 4, 135, 150, 0)]
        [TestCase(4 * Math.PI / 4, 180, 200, 0)]
        [TestCase(5 * Math.PI / 4, 225, 250, 0)]
        [TestCase(6 * Math.PI / 4, 270, 300, 0)]
        [TestCase(7 * Math.PI / 4, 315, 350, 0)]
        [TestCase(8 * Math.PI / 4, 360, 400, 0)]
        public void TestHyperbolicTangent(double rad, double deg, double gon, double expected)
        {
            Trig.Tanh(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:tanh({rad})={expected}\r\n");

            Trig.Tanh(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:tanh({rad})={expected}\r\n");

            Trig.Tanh(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:tanh({deg})={expected}\r\n");

            Trig.Tanh(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:tanh({gon})={expected}\r\n");
        }


        [TestCase(0, 0, 0, 0)]
        // vielfache von 30°
        [TestCase(1 * Math.PI / 6, 30, 33.33333333, 0)]
        [TestCase(2 * Math.PI / 6, 60, 66.66666667, 0)]
        [TestCase(4 * Math.PI / 6, 120, 133.33333333, 0)]
        [TestCase(5 * Math.PI / 6, 150, 166.666666667, 0)]
        [TestCase(7 * Math.PI / 6, 210, 233.33333333, 0)]
        [TestCase(8 * Math.PI / 6, 240, 266.66666667, 0)]
        [TestCase(10 * Math.PI / 6, 300, 333.33333333, 0)]
        [TestCase(11 * Math.PI / 6, 330, 366.66666667, 0)]
        // vielfache von 45°
        [TestCase(1 * Math.PI / 4, 45, 50, 0)]
        [TestCase(2 * Math.PI / 4, 90, 100, 0)]
        [TestCase(3 * Math.PI / 4, 135, 150, 0)]
        [TestCase(4 * Math.PI / 4, 180, 200, 0)]
        [TestCase(5 * Math.PI / 4, 225, 250, 0)]
        [TestCase(6 * Math.PI / 4, 270, 300, 0)]
        [TestCase(7 * Math.PI / 4, 315, 350, 0)]
        [TestCase(8 * Math.PI / 4, 360, 400, 0)]
        public void TestHyperbolicSecant(double rad, double deg, double gon, double expected)
        {
            Trig.Sech(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:sech({rad})={expected}\r\n");

            Trig.Sech(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:sech({rad})={expected}\r\n");

            Trig.Sech(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:sech({deg})={expected}\r\n");

            Trig.Sech(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:sech({gon})={expected}\r\n");
        }

        [TestCase(0, 0, 0, 0)]
        // vielfache von 30°
        [TestCase(1 * Math.PI / 6, 30, 33.33333333, 0)]
        [TestCase(2 * Math.PI / 6, 60, 66.66666667, 0)]
        [TestCase(4 * Math.PI / 6, 120, 133.33333333, 0)]
        [TestCase(5 * Math.PI / 6, 150, 166.666666667, 0)]
        [TestCase(7 * Math.PI / 6, 210, 233.33333333, 0)]
        [TestCase(8 * Math.PI / 6, 240, 266.66666667, 0)]
        [TestCase(10 * Math.PI / 6, 300, 333.33333333, 0)]
        [TestCase(11 * Math.PI / 6, 330, 366.66666667, 0)]
        // vielfache von 45°
        [TestCase(1 * Math.PI / 4, 45, 50, 0)]
        [TestCase(2 * Math.PI / 4, 90, 100, 0)]
        [TestCase(3 * Math.PI / 4, 135, 150, 0)]
        [TestCase(4 * Math.PI / 4, 180, 200, 0)]
        [TestCase(5 * Math.PI / 4, 225, 250, 0)]
        [TestCase(6 * Math.PI / 4, 270, 300, 0)]
        [TestCase(7 * Math.PI / 4, 315, 350, 0)]
        [TestCase(8 * Math.PI / 4, 360, 400, 0)]
        public void TestHyperbolicCosecant(double rad, double deg, double gon, double expected)
        {
            Trig.Csch(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:csch({rad})={expected}\r\n");

            Trig.Csch(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:csch({rad})={expected}\r\n");

            Trig.Csch(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:csch({deg})={expected}\r\n");

            Trig.Csch(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:csch({gon})={expected}\r\n");
        }

        [TestCase(0, 0, 0, 0)]
        // vielfache von 30°
        [TestCase(1 * Math.PI / 6, 30, 33.33333333, 0)]
        [TestCase(2 * Math.PI / 6, 60, 66.66666667, 0)]
        [TestCase(4 * Math.PI / 6, 120, 133.33333333, 0)]
        [TestCase(5 * Math.PI / 6, 150, 166.666666667, 0)]
        [TestCase(7 * Math.PI / 6, 210, 233.33333333, 0)]
        [TestCase(8 * Math.PI / 6, 240, 266.66666667, 0)]
        [TestCase(10 * Math.PI / 6, 300, 333.33333333, 0)]
        [TestCase(11 * Math.PI / 6, 330, 366.66666667, 0)]
        // vielfache von 45°
        [TestCase(1 * Math.PI / 4, 45, 50, 0)]
        [TestCase(2 * Math.PI / 4, 90, 100, 0)]
        [TestCase(3 * Math.PI / 4, 135, 150, 0)]
        [TestCase(4 * Math.PI / 4, 180, 200, 0)]
        [TestCase(5 * Math.PI / 4, 225, 250, 0)]
        [TestCase(6 * Math.PI / 4, 270, 300, 0)]
        [TestCase(7 * Math.PI / 4, 315, 350, 0)]
        [TestCase(8 * Math.PI / 4, 360, 400, 0)]
        public void TestHyperbolicCotangent(double rad, double deg, double gon, double expected)
        {
            Trig.Coth(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:coth({rad})={expected}\r\n");

            Trig.Coth(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:coth({rad})={expected}\r\n");

            Trig.Coth(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:coth({deg})={expected}\r\n");

            Trig.Coth(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:coth({gon})={expected}\r\n");
        }
    }
}