using System;
using ByteBee.Enums;
using ByteBee.Numerics;
using NUnit.Framework;

namespace ByteBeeTests.Numerics.TrigTests
{
    public sealed class TestAreaFunc
    {
        /*
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
        public void TestHyperbolicAreaSine(double rad, double deg, double gon, double expected)
        {
            MathTrigonometry.Asinh(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:asinh({rad})={expected}\r\n");

            MathTrigonometry.Asinh(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:asinh({rad})={expected}\r\n");

            MathTrigonometry.Asinh(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:asinh({deg})={expected}\r\n");

            MathTrigonometry.Asinh(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:asinh({gon})={expected}\r\n");
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
        public void TestHyperbolicAreaCosine(double rad, double deg, double gon, double expected)
        {
            MathTrigonometry.Acosh(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:acosh({rad})={expected}\r\n");

            MathTrigonometry.Acosh(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:acosh({rad})={expected}\r\n");

            MathTrigonometry.Acosh(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:acosh({deg})={expected}\r\n");

            MathTrigonometry.Acosh(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:acosh({gon})={expected}\r\n");
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
        public void TestHyperbolicAreaTangent(double rad, double deg, double gon, double expected)
        {
            MathTrigonometry.Atanh(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:atanh({rad})={expected}\r\n");

            MathTrigonometry.Atanh(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:atanh({rad})={expected}\r\n");

            MathTrigonometry.Atanh(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:atanh({deg})={expected}\r\n");

            MathTrigonometry.Atanh(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:atanh({gon})={expected}\r\n");
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
        public void TestHyperbolicAreaSecant(double rad, double deg, double gon, double expected)
        {
            MathTrigonometry.Asech(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:asech({rad})={expected}\r\n");

            MathTrigonometry.Asech(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:asech({rad})={expected}\r\n");

            MathTrigonometry.Asech(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:asech({deg})={expected}\r\n");

            MathTrigonometry.Asech(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:asech({gon})={expected}\r\n");
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
        public void TestHyperbolicAreaCosecant(double rad, double deg, double gon, double expected)
        {
            MathTrigonometry.Acsch(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:acsch({rad})={expected}\r\n");

            MathTrigonometry.Acsch(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:acsch({rad})={expected}\r\n");

            MathTrigonometry.Acsch(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:acsch({deg})={expected}\r\n");

            MathTrigonometry.Acsch(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:acsch({gon})={expected}\r\n");
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
        public void TestHyperbolicAreaCotangent(double rad, double deg, double gon, double expected)
        {
            MathTrigonometry.Acoth(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:acoth({rad})={expected}\r\n");

            MathTrigonometry.Acoth(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:acoth({rad})={expected}\r\n");

            MathTrigonometry.Acoth(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:acoth({deg})={expected}\r\n");

            MathTrigonometry.Acoth(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:acoth({gon})={expected}\r\n");
        }
        /**/
    }
}