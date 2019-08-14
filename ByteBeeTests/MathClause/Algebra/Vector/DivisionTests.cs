using ByteBee.Core.MathClause.Algebra;
using NUnit.Framework;

namespace ByteBeeTests.MathClause.Algebra.Vector
{
    [TestFixture]
    public class DivisionTests : AbstractVectorTests
    {
        [Test]
        public void op_vector_and_vector()
        {
            var v1 = new Vector3(22, 33, 44);
            var v2 = new Vector3(2, 3, 4);

            Vector3 v3 = v1 / v2;

            AssertVector(v3, 11, 11, 11);
        }

        [Test]
        public void op_vector_and_scalar()
        {
            var v1 = new Vector3(22, 32, 42);

            Vector3 v2 = v1 / 2;

            AssertVector(v2, 11, 16, 21);
        }

        [Test]
        public void op_scalar_and_vector()
        {
            var v1 = new Vector3(23, 32, 42);

            Vector3 v2 = 2 / v1;
            v2.Round(3);

            AssertVector(v2, 0.087, 0.062, 0.048);
        }

        [Test]
        public void fn_vector_and_scalar()
        {
            var v1 = new Vector3(24, 42, 63);
            var v2 = v1.Divide(3);

            AssertVector(v1, 24, 42, 63);
            AssertVector(v2, 8, 14, 21);
        }

        [Test]
        public void fn_vector_and_vector()
        {
            var v1 = new Vector3(22, 33, 44);
            var v2 = new Vector3(2, 3, 4);
            var v3 =  v1.Divide(v2);

            AssertVector(v1, 22, 33, 44);
            AssertVector(v2, 2, 3, 4);
            AssertVector(v3, 11, 11, 11);
        }
    }
}