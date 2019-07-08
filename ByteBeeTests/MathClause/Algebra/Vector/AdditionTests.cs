using ByteBee.MathClause.Algebra;
using NUnit.Framework;

namespace ByteBeeTests.MathClause.Algebra.Vector
{
    [TestFixture]
    public class AdditionTests : AbstractVectorTests
    {
        [Test]
        public void op_vector_and_vector()
        {
            var v1 = new Vector3(20, 30, 40);
            var v2 = new Vector3(2, 3, 4);

            Vector3 v3 = v1 + v2;
            AssertVector(v3, 22, 33, 44);
        }

        [Test]
        public void op_vector_and_scalar()
        {
            var v1 = new Vector3(20, 30, 40);

            Vector3 v2 = v1 + 2;
            AssertVector(v2, 22, 32, 42);
        }

        [Test]
        public void op_scalar_and_vector()
        {
            var v1 = new Vector3(20, 30, 40);

            Vector3 v2 = 2 + v1;
            AssertVector(v2, 22, 32, 42);

        }
        [Test]
        public void fn_vector_and_scalar()
        {
            var v1 = new Vector3(20, 40, 60);
            var v2 = v1.Add(3);

            AssertVector(v1, 20, 40, 60);
            AssertVector(v2, 23, 43, 63);
        }

        [Test]
        public void fn_vector_and_vector()
        {
            var v1 = new Vector3(20, 40, 60);
            var v2 = new Vector3(2, 4, 6);

            Vector3 v3 = v1.Add(v2);

            AssertVector(v1, 20, 40, 60);
            AssertVector(v3, 22, 44, 66);
        }
    }
}