using KukSoft.ToolKit.DataTypes;
using NUnit.Framework;

namespace KukSoft.ToolKit.Tests.DataTypes
{
    [TestFixture]
    public class Vector2Test
    {
        [Test]
        public void TestForVectorAdditionWithOtherVector()
        {
            var v = new Vector2D(5.4, 3.6);

            Vector2D a = v.Add(new Vector2D(0.6, 2.4)).Round(3);
            Vector2D b = (v + new Vector2D(-2.4, -0.6)).Round(3);

            Assert.That(a, Is.EqualTo(new Vector2D(6, 6)));
            Assert.That(b, Is.EqualTo(new Vector2D(3, 3)));
        }

        [Test]
        public void TestForVectorAdditionWithScalar()
        {
            var v = new Vector2D(5.4, 3.6);

            Vector2D a = v.Add(2).Round(3);
            Vector2D b = (v + 3).Round(3);
            Vector2D c = (3 + v).Round(3);

            Assert.That(a, Is.EqualTo(new Vector2D(7.4, 5.6)));
            Assert.That(b, Is.EqualTo(new Vector2D(8.4, 6.6)));
            Assert.That(c, Is.EqualTo(new Vector2D(8.4, 6.6)));
        }
        [Test]
        public void TestForVectorSubstractionWithOtherVector()
        {
            var v = new Vector2D(5.4, 3.6);

            Vector2D a = v.Subtract(new Vector2D(0.6, 2.4)).Round(3);
            Vector2D b = (v - new Vector2D(-2.4, -0.6)).Round(3);

            Assert.That(a, Is.EqualTo(new Vector2D(4.8, 1.2)));
            Assert.That(b, Is.EqualTo(new Vector2D(7.8, 4.2)));

        }
        [Test]
        public void TestForVectorSubstractionWithScalar()
        {
            var v = new Vector2D(5.4, 3.6);

            Vector2D a = v.Subtract(2).Round(3);
            Vector2D b = (v - 3).Round(3);
            Vector2D c = (3 - v).Round(3);

            Assert.That(a, Is.EqualTo(new Vector2D(3.4, 1.6)));
            Assert.That(b, Is.EqualTo(new Vector2D(2.4, 0.6)));
            Assert.That(c, Is.EqualTo(new Vector2D(-2.4, -0.6)));
        }


        [Test]
        public void TestForVectorDivisionWithOtherVector()
        {
            var v = new Vector2D(5.4, 3.6);

            Vector2D a = v.Divide(new Vector2D(0.6, 2.4)).Round(3);
            Vector2D b = (v / new Vector2D(-2.4, -0.6)).Round(3);

            Assert.That(a, Is.EqualTo(new Vector2D(9, 1.5)));
            Assert.That(b, Is.EqualTo(new Vector2D(-2.25, -6)));

        }

        [Test]
        public void TestForVectorDivisionWithScalar()
        {
            var v = new Vector2D(5.4, 3.6);

            Vector2D a = v.Divide(2).Round(3);
            Vector2D b = (v / 3).Round(3);
            Vector2D c = (3 / v).Round(3);

            Assert.That(a, Is.EqualTo(new Vector2D(2.7, 1.8)));
            Assert.That(b, Is.EqualTo(new Vector2D(1.8, 1.2)));
            Assert.That(c, Is.EqualTo(new Vector2D(0.556, 0.833)));
        }
        [Test]
        public void TestForVectorMultiplyWithOtherVector()
        {
            var v = new Vector2D(5.4, 3.6);

            Vector2D a = v.Multiply(new Vector2D(0.6, 2.4)).Round(3);
            Vector2D b = (v * new Vector2D(-2.4, -0.6)).Round(3);

            Assert.That(a, Is.EqualTo(new Vector2D(3.24, 8.64)));
            Assert.That(b, Is.EqualTo(new Vector2D(-12.96, -2.16)));

        }

        [Test]
        public void TestForVectorMultiplyWithScalar()
        {
            var v = new Vector2D(5.4, 3.6);

            Vector2D a = v.Multiply(2).Round(3);
            Vector2D b = (v * 3).Round(3);
            Vector2D c = (3 * v).Round(3);

            Assert.That(a, Is.EqualTo(new Vector2D(10.8, 7.2)));
            Assert.That(b, Is.EqualTo(new Vector2D(16.2, 10.8)));
            Assert.That(c, Is.EqualTo(new Vector2D(16.2, 10.8)));
        }

        [Test]
        public void TestForStrangeLesserAndGreater()
        {
            var a = new Vector2D(2, 7);
            var b = new Vector2D(3, 6);

            Assert.That(a.IsGreaterThan(b), Is.False);
            Assert.That(a.IsLessThan(b), Is.False);
        }
    }
}