//using ByteBee.Maths.Algebra;
//using NUnit.Framework;

//namespace ByteBeeTests.Maths.Algebra.Vector
//{
//    [TestFixture]
//    public class MultiplyTests : AbstractVectorTests
//    {
//        [Test]
//        public void op_vector_and_vector()
//        {
//            var v1 = new Vector3R(22, 33, 44);
//            var v2 = new Vector3R(2, 3, 4);

//            Vector3R v3 = v1 * v2;

//            AssertVector(v3, 44, 99, 176);
//        }

//        [Test]
//        public void op_vector_and_scalar()
//        {
//            var v1 = new Vector3R(22, 32, 42);

//            Vector3R v2 = v1 * 2;

//            AssertVector(v2, 44, 64, 84);
//        }

//        [Test]
//        public void op_scalar_and_vector()
//        {
//            var v1 = new Vector3R(22, 32, 42);

//            Vector3R v2 = 2 * v1;

//            AssertVector(v2, 44, 64, 84);
//        }

//        [Test]
//        public void fn_vector_and_scalar()
//        {
//            var vector = new Vector3R(23, 43, 63);

//            vector.Multiply(3);

//            AssertVector(vector, 69, 129, 189);
//        }

//        [Test]
//        public void fn_vector_and_vector()
//        {
//            var v1 = new Vector3R(22, 33, 44);
//            var v2 = new Vector3R(2, 3, 4);

//            v1.Multiply(v2);

//            AssertVector(v1, 44, 99, 176);
//        }
//    }
//}