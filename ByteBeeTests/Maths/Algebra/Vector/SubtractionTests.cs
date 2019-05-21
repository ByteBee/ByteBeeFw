//using ByteBee.Maths.Algebra;
//using NUnit.Framework;

//namespace ByteBeeTests.Maths.Algebra.Vector
//{
//    [TestFixture]
//    public class SubtractionTests : AbstractVectorTests
//    {
//        [Test]
//        public void op_vector_and_vector()
//        {
//            var v1 = new Vector3R(22, 33, 44);
//            var v2 = new Vector3R(2, 3, 4);

//            Vector3R v3 = v1 - v2;
//            AssertVector(v3, 20, 30, 40);
//        }

//        [Test]
//        public void op_vector_and_scalar()
//        {
//            var v1 = new Vector3R(22, 32, 42);

//            Vector3R v2 = v1 - 2;
//            AssertVector(v2, 20, 30, 40);
//        }

//        [Test]
//        public void op_scalar_and_vector()
//        {
//            var v1 = new Vector3R(22, 32, 42);

//            Vector3R v2 = 2 - v1;
//            AssertVector(v2, -20, -30, -40);
//        }

//        [Test]
//        public void fn_vector_and_scalar()
//        {
//            var vector = new Vector3R(23, 43, 63);

//            vector.Subtract(3);

//            AssertVector(vector, 20, 40, 60);
//        }

//        [Test]
//        public void fn_vector_and_vector()
//        {
//            var v1 = new Vector3R(22, 33, 44);
//            var v2 = new Vector3R(2, 3, 4);

//            v1.Subtract(v2);

//            AssertVector(v1, 20, 30, 40);
//        }
//    }
//}