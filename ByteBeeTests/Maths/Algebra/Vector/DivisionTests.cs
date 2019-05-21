//using ByteBee.Maths.Algebra;
//using NUnit.Framework;

//namespace ByteBeeTests.Maths.Algebra.Vector
//{
//    [TestFixture]
//    public class DivisionTests : AbstractVectorTests
//    {
//        [Test]
//        public void op_vector_and_vector()
//        {
//            var v1 = new Vector3R(22, 33, 44);
//            var v2 = new Vector3R(2, 3, 4);

//            Vector3R v3 = v1 / v2;

//            AssertVector(v3, 11, 11, 11);
//        }

//        [Test]
//        public void op_vector_and_scalar()
//        {
//            var v1 = new Vector3R(22, 32, 42);

//            Vector3R v2 = v1 / 2;

//            AssertVector(v2, 11, 16, 21);
//        }

//        [Test]
//        public void op_scalar_and_vector()
//        {
//            var v1 = new Vector3R(23, 32, 42);

//            Vector3R v2 = 2 / v1;
//            v2.Round(3);

//            AssertVector(v2, 0.087, 0.062, 0.048);
//        }

//        [Test]
//        public void fn_vector_and_scalar()
//        {
//            var vector = new Vector3R(24, 42, 63);

//            vector.Divide(3);

//            AssertVector(vector, 8, 14, 21);
//        }

//        [Test]
//        public void fn_vector_and_vector()
//        {
//            var v1 = new Vector3R(22, 33, 44);
//            var v2 = new Vector3R(2, 3, 4);

//            v1.Divide(v2);

//            AssertVector(v1, 11, 11, 11);
//        }
//    }
//}