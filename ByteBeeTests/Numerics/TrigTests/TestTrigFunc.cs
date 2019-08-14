using System;
using ByteBee.Core;
using ByteBee.Core.Enums;
using ByteBee.Core.Numerics;
using FluentAssertions;
using NUnit.Framework;

namespace ByteBeeTests.Numerics.TrigTests
{
    public sealed class TestTrigFunc
    {
        [TestCase(0, 0, 0, 0)]
        // vielfache von 30°
        [TestCase(1 * Math.PI / 6, 30, 33.3333333, 0.5)]
        [TestCase(2 * Math.PI / 6, 60, 66.6666667, 0.8660254037844)]
        [TestCase(4 * Math.PI / 6, 120, 133.3333333, 0.8660254037844)]
        [TestCase(5 * Math.PI / 6, 150, 166.6666667, 0.5)]
        [TestCase(7 * Math.PI / 6, 210, 233.3333333, -0.5)]
        [TestCase(8 * Math.PI / 6, 240, 266.6666667, -0.8660254037844)]
        [TestCase(10 * Math.PI / 6, 300, 333.3333333, -0.8660254037844)]
        [TestCase(11 * Math.PI / 6, 330, 366.6666667, -0.5)]
        // vielfache von 45°
        [TestCase(1 * Math.PI / 4, 45, 50, 0.7071067811865)]
        [TestCase(2 * Math.PI / 4, 90, 100, 1)]
        [TestCase(3 * Math.PI / 4, 135, 150, 0.7071067811865)]
        [TestCase(4 * Math.PI / 4, 180, 200, 0)]
        [TestCase(5 * Math.PI / 4, 225, 250, -0.7071067811865)]
        [TestCase(6 * Math.PI / 4, 270, 300, -1)]
        [TestCase(7 * Math.PI / 4, 315, 350, -0.7071067811865)]
        [TestCase(8 * Math.PI / 4, 360, 400, 0)]
        public void TestSine(double rad, double deg, double gon, double expected)
        {
            Trig.Sin(rad)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nStd:sin({rad})={expected}\r\n");

            Trig.Sin(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nRad:sin({rad})={expected}\r\n");

            Trig.Sin(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nDeg:sin({deg})={expected}\r\n");

            Trig.Sin(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nGon:sin({gon})={expected}\r\n");
        }

        [TestCase(0, 0, 0, 1)]
        // vielfache von 30°
        [TestCase(1 * Math.PI / 6, 30, 33.3333333, 0.8660254037844)]
        [TestCase(2 * Math.PI / 6, 60, 66.6666667, 0.5)]
        [TestCase(4 * Math.PI / 6, 120, 133.3333333, -0.5)]
        [TestCase(5 * Math.PI / 6, 150, 166.66666667, -0.8660254037844)]
        [TestCase(7 * Math.PI / 6, 210, 233.3333333, -0.8660254037844)]
        [TestCase(8 * Math.PI / 6, 240, 266.6666667, -0.5)]
        [TestCase(10 * Math.PI / 6, 300, 333.3333333, 0.5)]
        [TestCase(11 * Math.PI / 6, 330, 366.6666667, 0.8660254037844)]
        // vielfache von 45°
        [TestCase(1 * Math.PI / 4, 45, 50, 0.7071067811865)]
        [TestCase(2 * Math.PI / 4, 90, 100, 0)]
        [TestCase(3 * Math.PI / 4, 135, 150, -0.7071067811865)]
        [TestCase(4 * Math.PI / 4, 180, 200, -1)]
        [TestCase(5 * Math.PI / 4, 225, 250, -0.7071067811865)]
        [TestCase(6 * Math.PI / 4, 270, 300, 0)]
        [TestCase(7 * Math.PI / 4, 315, 350, 0.7071067811865)]
        [TestCase(8 * Math.PI / 4, 360, 400, 1)]
        public void TestCosine(double rad, double deg, double gon, double expected)
        {
            Trig.Cos(rad)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nStd:cos({rad})={expected}\r\n");

            Trig.Cos(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nRad:cos({rad})={expected}\r\n");

            Trig.Cos(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nDeg:cos({deg})={expected}\r\n");

            Trig.Cos(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nGon:cos({gon})={expected}\r\n");
        }

        [TestCase(0, 0, 0, 0)]
        // vielfache von 30°
        [TestCase(1 * Math.PI / 6, 30, 33.33333333, 0.5773502691896)]
        [TestCase(2 * Math.PI / 6, 60, 66.66666667, 1.7320508075689)]
        [TestCase(4 * Math.PI / 6, 120, 133.33333333, -1.7320508075689)]
        [TestCase(5 * Math.PI / 6, 150, 166.666666667, -0.5773502691896)]
        [TestCase(7 * Math.PI / 6, 210, 233.33333333, 0.5773502691896)]
        [TestCase(8 * Math.PI / 6, 240, 266.66666667, 1.732050807568)]
        [TestCase(10 * Math.PI / 6, 300, 333.33333333, -1.732050807568)]
        [TestCase(11 * Math.PI / 6, 330, 366.66666667, -0.5773502691896)]
        // vielfache von 45°
        [TestCase(1 * Math.PI / 4, 45, 50, 1)]
        [TestCase(2 * Math.PI / 4, 90, 100, 0)] // ?
        [TestCase(3 * Math.PI / 4, 135, 150, -1)]
        [TestCase(4 * Math.PI / 4, 180, 200, 0)]
        [TestCase(5 * Math.PI / 4, 225, 250, 1)]
        [TestCase(6 * Math.PI / 4, 270, 300, 0)] // ?
        [TestCase(7 * Math.PI / 4, 315, 350, -1)]
        [TestCase(8 * Math.PI / 4, 360, 400, 0)]
        public void TestTangent(double rad, double deg, double gon, double expected)
        {
            Trig.Tan(rad)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nStd:tan({rad})={expected}\r\n");

            Trig.Tan(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nRad:tan({rad})={expected}\r\n");

            Trig.Tan(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nDeg:tan({deg})={expected}\r\n");

            Trig.Tan(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nGon:tan({gon})={expected}\r\n");
        }

        [TestCase(0, 0, 0, 1)]
        // vielfache von 30°
        [TestCase(1 * Math.PI / 6, 30, 33.33333333, 1.1547005383793)]
        [TestCase(2 * Math.PI / 6, 60, 66.66666667, 2)]
        [TestCase(4 * Math.PI / 6, 120, 133.33333333, -2)]
        [TestCase(5 * Math.PI / 6, 150, 166.666666667, -1.1547005383793)]
        [TestCase(7 * Math.PI / 6, 210, 233.33333333, -1.1547005383793)]
        [TestCase(8 * Math.PI / 6, 240, 266.66666667, -2)]
        [TestCase(10 * Math.PI / 6, 300, 333.33333333, 2)]
        [TestCase(11 * Math.PI / 6, 330, 366.66666667, 1.1547005383793)]
        // vielfache von 45°
        [TestCase(1 * Math.PI / 4, 45, 50, 1.4142135623731)]
        [TestCase(2 * Math.PI / 4, 90, 100, 0)] // ?
        [TestCase(3 * Math.PI / 4, 135, 150, -1.4142135623731)]
        [TestCase(4 * Math.PI / 4, 180, 200, -1)]
        [TestCase(5 * Math.PI / 4, 225, 250, -1.4142135623731)]
        [TestCase(6 * Math.PI / 4, 270, 300, 0)] // ?
        [TestCase(7 * Math.PI / 4, 315, 350, 1.4142135623731)]
        [TestCase(8 * Math.PI / 4, 360, 400, 1)]
        public void TestSecant(double rad, double deg, double gon, double expected)
        {
            Trig.Sec(rad)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nStd:sec({rad})={expected}\r\n");

            Trig.Sec(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nRad:sec({rad})={expected}\r\n");

            Trig.Sec(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nDeg:sec({deg})={expected}\r\n");

            Trig.Sec(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nGon:sec({gon})={expected}\r\n");
        }

        [TestCase(0, 0, 0, 0)] // ?
        // vielfache von 30°
        [TestCase(1 * Math.PI / 6, 30, 33.33333333, 2)]
        [TestCase(2 * Math.PI / 6, 60, 66.66666667, 1.1547005383793)]
        [TestCase(4 * Math.PI / 6, 120, 133.33333333, 1.1547005383793)]
        [TestCase(5 * Math.PI / 6, 150, 166.666666667, 2)]
        [TestCase(7 * Math.PI / 6, 210, 233.33333333, -2)]
        [TestCase(8 * Math.PI / 6, 240, 266.66666667, -1.1547005383793)]
        [TestCase(10 * Math.PI / 6, 300, 333.33333333, -1.1547005383793)]
        [TestCase(11 * Math.PI / 6, 330, 366.66666667, -2)]
        // vielfache von 45°
        [TestCase(1 * Math.PI / 4, 45, 50, 1.4142135623731)]
        [TestCase(2 * Math.PI / 4, 90, 100, 1)]
        [TestCase(3 * Math.PI / 4, 135, 150, 1.4142135623731)]
        [TestCase(4 * Math.PI / 4, 180, 200, 0)] // ?
        [TestCase(5 * Math.PI / 4, 225, 250, -1.4142135623731)]
        [TestCase(6 * Math.PI / 4, 270, 300, -1)]
        [TestCase(7 * Math.PI / 4, 315, 350, -1.4142135623731)]
        [TestCase(8 * Math.PI / 4, 360, 400, 0)] // ?
        public void TestCosecant(double rad, double deg, double gon, double expected)
        {
            Trig.Csc(rad)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nStd:csc({rad})={expected}\r\n");

            Trig.Csc(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nRad:csc({rad})={expected}\r\n");

            Trig.Csc(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nDeg:csc({deg})={expected}\r\n");

            Trig.Csc(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nGon:csc({gon})={expected}\r\n");
        }

        [TestCase(0, 0, 0, 0)] // ?
        // vielfache von 30°
        [TestCase(1 * Math.PI / 6, 30, 33.33333333, 1.7320508075689)]
        [TestCase(2 * Math.PI / 6, 60, 66.66666667, 0.5773502691896)]
        [TestCase(4 * Math.PI / 6, 120, 133.33333333, -0.5773502691896)]
        [TestCase(5 * Math.PI / 6, 150, 166.666666667, -1.7320508075689)]
        [TestCase(7 * Math.PI / 6, 210, 233.33333333, 1.7320508075689)]
        [TestCase(8 * Math.PI / 6, 240, 266.66666667, 0.5773502691896)]
        [TestCase(10 * Math.PI / 6, 300, 333.33333333, -0.5773502691896)]
        [TestCase(11 * Math.PI / 6, 330, 366.66666667, -1.7320508075689)]
        // vielfache von 45°
        [TestCase(1 * Math.PI / 4, 45, 50, 1)]
        [TestCase(2 * Math.PI / 4, 90, 100, 0)]
        [TestCase(3 * Math.PI / 4, 135, 150, -1)]
        [TestCase(4 * Math.PI / 4, 180, 200, 0)] // ?
        [TestCase(5 * Math.PI / 4, 225, 250, 1)]
        [TestCase(6 * Math.PI / 4, 270, 300, 0)]
        [TestCase(7 * Math.PI / 4, 315, 350, -1)]
        [TestCase(8 * Math.PI / 4, 360, 400, 0)] // ?
        public void TestCotangent(double rad, double deg, double gon, double expected)
        {
            Trig.Cot(rad)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nStd:cot({rad})={expected}\r\n");

            Trig.Cot(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nRad:cot({rad})={expected}\r\n");

            Trig.Cot(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nDeg:cot({deg})={expected}\r\n");

            Trig.Cot(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, Bee.Math.Epsilon, $"\r\nGon:cot({gon})={expected}\r\n");
        }
    }
}