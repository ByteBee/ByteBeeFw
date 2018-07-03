using System;
using NUnit.Framework;
using static SwissKnife.Fancy;

namespace SwissKnife.Tests.Mathematics
{
    [TestFixture]
    public class TrigFuncTests
    {
        [TestCase(0, 0)]
        [TestCase(30, 0.5)]
        [TestCase(90, 1)]
        [TestCase(150, 0.5)]
        [TestCase(180, 0)]
        [TestCase(210, -0.5)]
        [TestCase(270, -1)]
        [TestCase(330, -0.5)]
        [TestCase(360, -0)]
        public void SineTest(double tetha, double sin)
            => Assert.IsTrue(math.Approx(sin, math.TrigDeg.Sin(tetha)));

        [TestCase(0, 1)]
        [TestCase(60, 0.5)]
        [TestCase(90, 0)]
        [TestCase(120, -0.5)]
        [TestCase(180, -1)]
        [TestCase(240, -0.5)]
        [TestCase(270, -0)]
        [TestCase(360, 1)]
        public void CosineTest(double tetha, double cos)
            => Assert.IsTrue(math.Approx(cos, math.TrigDeg.Cos(tetha)));

        [TestCase(0, 0)]
        [TestCase(45, 1)]
        [TestCase(90, double.PositiveInfinity)]
        [TestCase(135, -1)]
        [TestCase(180, 0)]
        [TestCase(225, 1)]
        [TestCase(270, double.NegativeInfinity)]
        [TestCase(315, -1)]
        [TestCase(360, 0)]
        public void TangentTest(double tetha, double tan)
            => Assert.IsTrue(math.Approx(tan, math.TrigDeg.Tan(tetha)));

        [TestCase(-1, -90)]
        [TestCase(-0.5, -30)]
        [TestCase(0, 0)]
        [TestCase(0.5, 30)]
        [TestCase(1, 90)]
        public void ArcusSineTest(double tetha, double asin) 
            => Assert.IsTrue(math.Approx(asin, math.TrigDeg.Asin(tetha)), math.TrigDeg.Asin(tetha).ToString("E"));

        [TestCase(-1, 180)]
        [TestCase(-0.5, 120)]
        [TestCase(0, 90)]
        [TestCase(0.5, 60)]
        [TestCase(1, 0)]
        public void ArcusCosineTest(double tetha, double acos) 
            => Assert.IsTrue(math.Approx(acos, math.TrigDeg.Acos(tetha)));

        [TestCase(double.PositiveInfinity, 90)]
        [TestCase(-1, -45)]
        [TestCase(0, 0)]
        [TestCase(1, 45)]
        [TestCase(double.NegativeInfinity, -90)]
        public void ArcusTangentTest(double tetha, double atan) 
            => Assert.IsTrue(math.Approx(atan, math.TrigDeg.Atan(tetha)));
    }
}