//using System.Security.Cryptography.X509Certificates;
//using ByteBee.Maths.Algebra;
//using NUnit.Framework;

//namespace ByteBeeTests.Maths.Algebra.Vector
//{
//    public class ComparisonTest
//    {
//        [Test]
//        public void check_equality()
//        {
//            Vector3R v1 = Vector3R.One;
//            Vector3R v2 = new Vector3R(1);
//            Vector3R v3 = new Vector3R(2);

//            Assert.IsTrue(v1 == v2);
//            Assert.IsTrue(v1 != v3);
//            Assert.IsTrue(v2 != v3);
//        }

//        [Test]
//        public void check_for_less()
//        {
//            Vector3R a = new Vector3R(8, 4, 2);
//            Vector3R b = new Vector3R(8, 2, 4);
//            Vector3R c = new Vector3R(7, 3, 0);

//            bool isLess = c.IsLessThan(a);

//            Assert.IsTrue(isLess);
//            Assert.IsFalse(a < b);
//            Assert.IsFalse(b < a);
//        }

//        [Test]
//        public void check_for_less_or_equals()
//        {
//            Vector3R a = new Vector3R(8, 4, 2);
//            Vector3R b = new Vector3R(8, 2, 4);
//            Vector3R c = new Vector3R(8, 3, 0);

//            bool isLess = c.IsLessThanOrEqual(a);

//            Assert.IsTrue(isLess);
//            Assert.IsFalse(a <= b);
//            Assert.IsFalse(b <= a);

//        }

//        [Test]
//        public void check_for_greater()
//        {
//            Vector3R a = new Vector3R(8, 4, 2);
//            Vector3R b = new Vector3R(8, 2, 4);
//            Vector3R c = new Vector3R(9, 5, 7);

//            bool isGreater = c.IsGreaterThan(a);

//            Assert.IsTrue(isGreater);
//            Assert.IsFalse(a > b);
//            Assert.IsFalse(b > a);

//        }

//        [Test]
//        public void check_for_greater_or_equals()
//        {
//            Vector3R a = new Vector3R(8, 4, 2);
//            Vector3R b = new Vector3R(8, 2, 4);
//            Vector3R c = new Vector3R(8, 5, 7);

//            bool isGreater = c.IsGreaterThanOrEqual(a);

//            Assert.IsTrue(isGreater);
//            Assert.IsFalse(a >= b);
//            Assert.IsFalse(b >= a);
//        }

//        [Test]
//        public void check_if_zero_is_zero()
//        {
//            // this test sounds stupid :-)
//            Assert.IsTrue(Vector3R.Zero.IsZero());
//        }

//        [Test]
//        public void check_for_equality_with_tolerance()
//        {
//            var v1 = new Vector3R(1.234099, 2.345123, 3.456398741);
//            var v2 = new Vector3R(1.234100, 2.345007, 3.456314152);

//            bool isEqual = v1.IsEqual(v2, 0.001);

//            Assert.True(isEqual);
//        }

//        [Test]
//        public void check_equality_with_object()
//        {
//            var v1 = new Vector3R(1,1,1);
//            object v2 = Vector3R.One;

//            bool isEqual = v1.Equals(v2);

//            Assert.True(isEqual);
//        }
//    }
//}