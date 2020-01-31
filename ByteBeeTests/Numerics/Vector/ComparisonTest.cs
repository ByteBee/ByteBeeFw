using System;
using ByteBee.Numerics.LinearAlgebra;
using NUnit.Framework;

namespace ByteBeeTests.MathClause.Algebra.Vector
{
    public class ComparisonTest
    {
        [Test]
        public void check_equality()
        {
            Vector3 v1 = new Vector3(1);
            Vector3 v2 = new Vector3(1);
            Vector3 v3 = new Vector3(2);

            Assert.IsTrue(v1 == v2);
            Assert.IsTrue(v1 != v3);
            Assert.IsTrue(v2 != v3);
        }

        [Test]
        public void check_for_less()
        {
            Vector3 a = new Vector3(8, 4, 2);
            Vector3 b = new Vector3(8, 2, 4);
            Vector3 c = new Vector3(7, 3, 0);

            bool isLess = c.IsLessThan(a);

            Assert.IsTrue(isLess);
            Assert.IsFalse(a < b);
            Assert.IsFalse(b < a);
        }

        [Test]
        public void check_for_less_or_equals()
        {
            Vector3 a = new Vector3(8, 4, 2);
            Vector3 b = new Vector3(8, 2, 4);
            Vector3 c = new Vector3(8, 3, 0);

            bool isLess = c.IsLessThanOrEqual(a);

            Assert.IsTrue(isLess);
            Assert.IsFalse(a <= b);
            Assert.IsFalse(b <= a);

        }

        [Test]
        public void check_for_greater()
        {
            Vector3 a = new Vector3(8, 4, 2);
            Vector3 b = new Vector3(8, 2, 4);
            Vector3 c = new Vector3(9, 5, 7);

            bool isGreater = c.IsGreaterThan(a);

            Assert.IsTrue(isGreater);
            Assert.IsFalse(a > b);
            Assert.IsFalse(b > a);

        }

        [Test]
        public void check_for_greater_or_equals()
        {
            Vector3 a = new Vector3(8, 4, 2);
            Vector3 b = new Vector3(8, 2, 4);
            Vector3 c = new Vector3(8, 5, 7);

            bool isGreater = c.IsGreaterThanOrEqual(a);

            Assert.IsTrue(isGreater);
            Assert.IsFalse(a >= b);
            Assert.IsFalse(b >= a);
        }

        [Test]
        public void check_if_zero_is_zero()
        {
            // this test sounds stupid :-)
            Assert.IsTrue(Vector3.Zero.IsZero());
        }

        [Test]
        public void check_for_equality_with_tolerance()
        {
            var v1 = new Vector3(1.234099, 2.345123, 3.456398741);
            var v2 = new Vector3(1.234100, 2.345007, 3.456314152);

            bool isEqual = v1.IsEqual(v2, 0.001);

            Assert.True(isEqual);
        }

        [Test]
        public void check_equality_with_object()
        {
            var v1 = new Vector3(1, 1, 1);
            object v2 = Vector3.One;

            bool isEqual = v1.Equals(v2);

            Assert.True(isEqual);
        }
    }
}