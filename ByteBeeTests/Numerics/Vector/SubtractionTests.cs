using ByteBee.Numerics.LinearAlgebra;
using NUnit.Framework;

namespace ByteBeeTests.MathClause.Algebra.Vector
{
    [TestFixture]
    public class SubtractionTests : AbstractVectorTests
    {
        [Test]
        public void op_vector_and_vector()
        {
            var v1 = new Vector3(22, 33, 44);
            var v2 = new Vector3(2, 3, 4);

            Vector3 v3 = v1 - v2;
            AssertVector(v3, 20, 30, 40);
        }

        [Test]
        public void op_vector_and_scalar()
        {
            var v1 = new Vector3(22, 32, 42);

            Vector3 v2 = v1 - 2;
            AssertVector(v2, 20, 30, 40);
        }

        [Test]
        public void op_scalar_and_vector()
        {
            var v1 = new Vector3(22, 32, 42);

            Vector3 v2 = 2 - v1;
            AssertVector(v2, -20, -30, -40);
        }

        [Test]
        public void fn_vector_and_scalar()
        {
            var v1 = new Vector3(23, 43, 63);
            var v2 = v1.Subtract(3);

            AssertVector(v2, 20, 40, 60);
        }

        [Test]
        public void fn_vector_and_vector()
        {
            var v1 = new Vector3(22, 33, 44);
            var v2 = new Vector3(2, 3, 4);
            var v3 = v1.Subtract(v2);

            AssertVector(v3, 20, 30, 40);
        }
    }
}