using System;
using ByteBee;
using ByteBee.Enums;
using ByteBee.Numerics;
using FluentAssertions;
using NUnit.Framework;

namespace ByteBeeTests.Numerics.TrigTests
{
    public sealed class TestArcusFunc
    {
        /*
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
        public void TestArcusSine(double rad, double deg, double gon, double expected)
        {
            MathTrigonometry.Asin(expected)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:asin({rad})={expected}\r\n");

            MathTrigonometry.Asin(expected, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:asin({rad})={expected}\r\n");

            MathTrigonometry.Asin(expected, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:asin({deg})={expected}\r\n");

            MathTrigonometry.Asin(expected, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:asin({gon})={expected}\r\n");
        }
        




        //#region arcus sine

        //[TestCase(-Math.PI / 2, -1)]                 // -90°
        //[TestCase(-Math.PI / 3, -0.8660254037844)]   // -60°
        //[TestCase(-Math.PI / 4, -0.7071067811865)]   // -45°
        //[TestCase(-Math.PI / 6, -0.5)]               // -30°
        //[TestCase(0, 0)]
        //[TestCase(Math.PI / 6, 0.5)]                // 30°
        //[TestCase(Math.PI / 4, 0.7071067811865)]    // 45°
        //[TestCase(Math.PI / 3, 0.8660254037844)]    // 60°
        //[TestCase(Math.PI / 2, 1)]                  // 90°
        //public void TestArcusSine(double expected, double theta)
        //{
        //    MathTrigonometry.Asin(theta)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}

        //[TestCase(-Math.PI / 2, -1)]                 // -90°
        //[TestCase(-Math.PI / 3, -0.8660254037844)]   // -60°
        //[TestCase(-Math.PI / 4, -0.7071067811865)]   // -45°
        //[TestCase(-Math.PI / 6, -0.5)]               // -30°
        //[TestCase(0, 0)]
        //[TestCase(Math.PI / 6, 0.5)]                // 30°
        //[TestCase(Math.PI / 4, 0.7071067811865)]    // 45°
        //[TestCase(Math.PI / 3, 0.8660254037844)]    // 60°
        //[TestCase(Math.PI / 2, 1)]                  // 90°
        //public void TestArcusSineRad(double expected, double theta)
        //{
        //    MathTrigonometry.Asin(theta, AngleUnit.Rad)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}

        //[TestCase(-1, -90)]
        //[TestCase(-0.8660254037844, -60)]
        //[TestCase(-0.7071067811865, -45)]
        //[TestCase(-0.5, -30)]
        //[TestCase(0, 0)]
        //[TestCase(0.5, 30)]
        //[TestCase(0.7071067811865, 45)]
        //[TestCase(0.8660254037844, 60)]
        //[TestCase(1, 90)]
        //public void TestArcusSineDeg(double theta, double expected)
        //{
        //    MathTrigonometry.Asin(theta, AngleUnit.Deg)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}

        //#endregion

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
        public void TestArcusCosine(double rad, double deg, double gon, double expected)
        {
            MathTrigonometry.Acos(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:acos({rad})={expected}\r\n");

            MathTrigonometry.Acos(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:acos({rad})={expected}\r\n");

            MathTrigonometry.Acos(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:acos({deg})={expected}\r\n");

            MathTrigonometry.Acos(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:acos({gon})={expected}\r\n");
        }



        //#region arcus cosine

        //[TestCase(-1, Math.PI)]
        //[TestCase(-0.8660254037844, 5 * Math.PI / 6)]
        //[TestCase(-0.7071067811865, 3 * Math.PI / 4)]
        //[TestCase(-0.5, 2 * Math.PI / 3)]
        //[TestCase(0, Math.PI / 2)]
        //[TestCase(0.5, Math.PI / 3)]
        //[TestCase(0.7071067811865, Math.PI / 4)]
        //[TestCase(0.8660254037844, Math.PI / 6)]
        //[TestCase(1, 0)]
        //public void TestArcusCosine(double theta, double expected)
        //{
        //    MathTrigonometry.Acos(theta)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}


        //[TestCase(-1, Math.PI)]
        //[TestCase(-0.8660254037844, 5 * Math.PI / 6)]
        //[TestCase(-0.7071067811865, 3 * Math.PI / 4)]
        //[TestCase(-0.5, 2 * Math.PI / 3)]
        //[TestCase(0, Math.PI / 2)]
        //[TestCase(0.5, Math.PI / 3)]
        //[TestCase(0.7071067811865, Math.PI / 4)]
        //[TestCase(0.8660254037844, Math.PI / 6)]
        //[TestCase(1, 0)]
        //public void TestArcusCosineRad(double theta, double expected)
        //{
        //    MathTrigonometry.Acos(theta, AngleUnit.Rad)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}

        //[TestCase(-1, 180)]
        //[TestCase(-0.8660254037844, 150)]
        //[TestCase(-0.7071067811865, 135)]
        //[TestCase(-0.5, 120)]
        //[TestCase(0, 90)]
        //[TestCase(0.5, 60)]
        //[TestCase(0.7071067811865, 45)]
        //[TestCase(0.8660254037844, 30)]
        //[TestCase(1, 0)]
        //public void TestArcusCosineDeg(double theta, double expected)
        //{
        //    MathTrigonometry.Acos(theta, AngleUnit.Deg)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}

        //#endregion

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
        public void TestArcusTangent(double rad, double deg, double gon, double expected)
        {
            MathTrigonometry.Atan(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:atan({rad})={expected}\r\n");

            MathTrigonometry.Atan(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:atan({rad})={expected}\r\n");

            MathTrigonometry.Atan(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:atan({deg})={expected}\r\n");

            MathTrigonometry.Atan(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:atan({gon})={expected}\r\n");
        }



        //#region arcus tangent

        //[TestCase(-1.732050808, -Math.PI / 3)]
        //[TestCase(-1, -Math.PI / 4)]
        //[TestCase(-0.577350269, -Math.PI / 6)]
        //[TestCase(0, 0)]
        //[TestCase(0.577350269, Math.PI / 6)]
        //[TestCase(1, Math.PI / 4)]
        //[TestCase(1.732050808, Math.PI / 3)]
        //public void TestArcusTangent(double theta, double expected)
        //{
        //    MathTrigonometry.Atan(theta)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}

        //[TestCase(-1.732050808, -Math.PI / 3)]
        //[TestCase(-1, -Math.PI / 4)]
        //[TestCase(-0.577350269, -Math.PI / 6)]
        //[TestCase(0, 0)]
        //[TestCase(0.577350269, Math.PI / 6)]
        //[TestCase(1, Math.PI / 4)]
        //[TestCase(1.732050808, Math.PI / 3)]
        //public void TestArcusTangentRad(double theta, double expected)
        //{
        //    MathTrigonometry.Atan(theta, AngleUnit.Rad)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}

        //[TestCase(-1.732050808, -60)]
        //[TestCase(-1, -45)]
        //[TestCase(-0.577350269, -30)]
        //[TestCase(0, 0)]
        //[TestCase(0.577350269, 30)]
        //[TestCase(1, 45)]
        //[TestCase(1.732050808, 60)]
        //public void TestArcusTangentDeg(double theta, double expected)
        //{
        //    MathTrigonometry.Atan(theta, AngleUnit.Deg)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}

        //#endregion

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
        public void TestArcusCosecant(double rad, double deg, double gon, double expected)
        {
            MathTrigonometry.Acsc(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:acsc({rad})={expected}\r\n");

            MathTrigonometry.Acsc(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:acsc({rad})={expected}\r\n");

            MathTrigonometry.Acsc(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:acsc({deg})={expected}\r\n");

            MathTrigonometry.Acsc(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:acsc({gon})={expected}\r\n");
        }



        //#region arcus cosecant

        //[TestCase(-Math.PI / 2, -1)]
        //[TestCase(-Math.PI / 3, -1.1547005383793)]
        //[TestCase(-Math.PI / 4, -1.4142135623731)]
        //[TestCase(-Math.PI / 6, -2)]
        //[TestCase(Math.PI / 6, 2)]
        //[TestCase(Math.PI / 4, 1.4142135623731)]
        //[TestCase(Math.PI / 3, 1.1547005383793)]
        //[TestCase(Math.PI / 2, 1)]
        //public void TestArcusCosecant(double expected, double theta)
        //{
        //    MathTrigonometry.Acsc(theta)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}


        //[TestCase(-Math.PI / 2, -1)]
        //[TestCase(-Math.PI / 3, -1.1547005383793)]
        //[TestCase(-Math.PI / 4, -1.4142135623731)]
        //[TestCase(-Math.PI / 6, -2)]
        //[TestCase(Math.PI / 6, 2)]
        //[TestCase(Math.PI / 4, 1.4142135623731)]
        //[TestCase(Math.PI / 3, 1.1547005383793)]
        //[TestCase(Math.PI / 2, 1)]
        //public void TestArcusCosecantRad(double expected, double theta)
        //{
        //    MathTrigonometry.Acsc(theta, AngleUnit.Rad)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}

        //[TestCase(-90, -1)]
        //[TestCase(-30, -2)]
        //[TestCase(30, 2)]
        //[TestCase(90, 1)]
        //public void TestArcusCosecantDeg(double expected, double theta)
        //{
        //    MathTrigonometry.Acsc(theta, AngleUnit.Deg)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}

        //#endregion

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
        public void TestArcusSecant(double rad, double deg, double gon, double expected)
        {
            MathTrigonometry.Asec(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:asec({rad})={expected}\r\n");

            MathTrigonometry.Asec(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:asec({rad})={expected}\r\n");

            MathTrigonometry.Asec(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:asec({deg})={expected}\r\n");

            MathTrigonometry.Asec(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:asec({gon})={expected}\r\n");
        }

        //#region arcus secant

        //[TestCase(0, 1)]
        //[TestCase(Math.PI / 6, 1.1547005383793)]
        //[TestCase(Math.PI / 4, 1.4142135623731)]
        //[TestCase(Math.PI / 3, 2)]
        //public void TestArcusSecant(double expected, double theta)
        //{
        //    MathTrigonometry.Asec(theta)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}

        //[TestCase(0, 1)]
        //[TestCase(Math.PI / 6, 1.1547005383793)]
        //[TestCase(Math.PI / 4, 1.4142135623731)]
        //[TestCase(Math.PI / 3, 2)]
        //public void TestArcusSecantRad(double expected, double theta)
        //{
        //    MathTrigonometry.Asec(theta, AngleUnit.Rad)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}


        //[TestCase(0, 1)]
        //[TestCase(180, -1)]
        //[TestCase(15, 1.0352761804101)]
        //[TestCase(30, 1.1547005383793)]
        //[TestCase(45, 1.4142135623731)]
        //[TestCase(60, 2)]
        //public void TestArcusSecantDeg(double expected, double theta)
        //{
        //    MathTrigonometry.Asec(theta, AngleUnit.Deg)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}

        //#endregion

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
        public void TestArcusCotangent(double rad, double deg, double gon, double expected)
        {
            MathTrigonometry.Acot(rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nStd:acot({rad})={expected}\r\n");

            MathTrigonometry.Acot(rad, AngleUnit.Rad)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nRad:acot({rad})={expected}\r\n");

            MathTrigonometry.Acot(deg, AngleUnit.Deg)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nDeg:acot({deg})={expected}\r\n");

            MathTrigonometry.Acot(gon, AngleUnit.Gon)
                .Should()
                .BeApproximately(expected, MathConstant.Epsilon, $"\r\nGon:acot({gon})={expected}\r\n");
        }

        //#region arcus cotangent

        //[TestCase(Math.PI / 6, 1.7320508075689)]    // 30°
        //[TestCase(Math.PI / 4, 1)]    // 45°
        //[TestCase(Math.PI / 3, 0.5773502691896)]
        //[TestCase(Math.PI / 2, 0)]
        //public void TestArcusCotangent(double expected, double theta)
        //{
        //    MathTrigonometry.Acot(theta)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}

        //[TestCase(Math.PI / 6, 1.7320508075689)]    // 30°
        //[TestCase(Math.PI / 4, 1)]    // 45°
        //[TestCase(Math.PI / 3, 0.5773502691896)]
        //[TestCase(Math.PI / 2, 0)]
        //public void TestArcusCotangentRad(double expected, double theta)
        //{
        //    MathTrigonometry.Acot(theta, AngleUnit.Rad)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}


        //[TestCase(45, 1)]
        //[TestCase(90, 0)]
        //[TestCase(135, -1)]
        //public void TestArcusCotangentDeg(double expected, double theta)
        //{
        //    MathTrigonometry.Acot(theta, AngleUnit.Deg)
        //        .Should().BeApproximately(expected, Bee.Math.ZeroTolerance);
        //}

        //#endregion
        /**/
    }
}