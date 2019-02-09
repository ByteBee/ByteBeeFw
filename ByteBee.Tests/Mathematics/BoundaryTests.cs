using ByteBee;
using NUnit.Framework;

namespace ByteBeeTests.Mathematics
{
    [TestFixture]
    public class BoundaryTests
    {
        [TestCase(0, 1, 0)]
        [TestCase(7, 1, 1)]
        [TestCase(7, 2, 2)]
        [TestCase(1, 1, 1)]
        [TestCase(-1, -1, -1)]
        public void GetTheMinOfTwoValues(int a, int b, int e)
        {
            int actually = Bee.Math.Min(a, b);
            Assert.AreEqual(actually, e);
        }

        [TestCase(-1, -1, -1, -1)]
        [TestCase(1, -1, 1, -1)]
        [TestCase(1, 2, 1, 1)]
        [TestCase(1, 2, 2, 1)]
        [TestCase(7, 2, 7, 2)]
        [TestCase(2, 2, 3, 2)]
        public void GetTheMinOfThreeValues(int a, int b, int c, int e)
        {
            int actually = Bee.Math.Min(a, b, c);
            Assert.AreEqual(actually, e);
        }

        [TestCase(0, 1, 1)]
        [TestCase(7, 1, 7)]
        [TestCase(7, 2, 7)]
        [TestCase(1, 1, 1)]
        [TestCase(-1, -1, -1)]
        public void GetTheMaxOfTwoValues(int a, int b, int e)
        {
            int actually = Bee.Math.Max(a, b);
            Assert.AreEqual(actually, e);
        }

        [TestCase(-1, -1, -1, -1)]
        [TestCase(1, -1, 1, 1)]
        [TestCase(1, 2, 1, 2)]
        [TestCase(1, 2, 2, 2)]
        [TestCase(7, 2, 7, 7)]
        [TestCase(2, 2, 3, 3)]
        public void GetTheMaxOfThreeValues(int a, int b, int c, int e)
        {
            int actually = Bee.Math.Max(a, b, c);
            Assert.AreEqual(actually, e);
        }

    }
}