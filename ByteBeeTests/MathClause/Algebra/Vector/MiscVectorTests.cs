using ByteBee.Core.MathClause.Algebra;
using NUnit.Framework;

namespace ByteBeeTests.MathClause.Algebra.Vector
{
    [TestFixture]
    public class MiscVectorTests : AbstractVectorTests
    {
        [Test]
        public void i_can_create_a_vector()
        {
            var v = new Vector3(0);
            Assert.IsNotNull(v);
        }

        [Test]
        public void perform_operations_should_not_change_originals()
        {
            var v1 = new Vector3(1, 2, 3);
            var v2 = new Vector3(3, 2, 1);

            Vector3 v3 = v1 + v2;

            Assert.AreEqual(1, v1.X, "v1");
            Assert.AreEqual(3, v2.X, "v2");
            Assert.AreEqual(4, v3.X, "v3");
        }

        [Test]
        public void check_unit_vectors()
        {
            AssertVector(Vector3.I, 1, 0, 0);
            AssertVector(Vector3.J, 0, 1, 0);
            AssertVector(Vector3.K, 0, 0, 1);

            AssertVector(Vector3.Zero, 0, 0, 0);
            AssertVector(Vector3.One, 1, 1, 1);
        }

        [Test]
        public void check_the_tostring_method()
        {
            Vector3 one = Vector3.One;

            string str = one.ToString();

            Assert.That(str, Is.EqualTo("X:1|Y:1|Z:1"));
        }

        [Test]
        public void round_the_vector_to_two_sig_digs()
        {
            Vector3 v1 = new Vector3(1.2346, 2.3456, 3.4567);
            Vector3 v2 = v1.Round(2);

            AssertVector(v2, 1.23, 2.35, 3.46);
        }

        [Test]
        public void make_an_absolute_vector()
        {
            Vector3 v1 = new Vector3(-20, -34, -42);
            Vector3 v2 = v1.Abs();

            AssertVector(v2, 20, 34, 42);
        }

        [Test]
        public void make_an_absolute_vector_op()
        {
            Vector3 v1 = new Vector3(-20, -34, -42);
            Vector3 v2 = +v1;

            AssertVector(v1, -20, -34, -42);
            AssertVector(v2, 20, 34, 42);
        }

        [Test]
        public void negate_vector()
        {
            Vector3 v1 = new Vector3(-20, 34, -42);
            Vector3 v2 = -v1;

            AssertVector(v1, -20, 34, -42);
            AssertVector(v2, 20, -34, 42);
        }

        [TestCase(1, 2, 2, 3)]
        [TestCase(3, 3, 1, 4.3588)]
        public void length_of_one_vector_should_be_one(double x, double y, double z, double expected)
        {
            var vector = new Vector3(x, y, z);

            double actual = vector.GetLength();

            Assert.AreEqual(expected, actual, 0.001);
        }

        [Test]
        public void calculate_the_hash_code()
        {
            int i = Vector3.I.GetHashCode();
            int j = Vector3.J.GetHashCode();
            int k = Vector3.K.GetHashCode();

            Assert.AreEqual(-982515712, i);
            Assert.AreEqual(657457152, j);
            Assert.AreEqual(1072693248, k);
        }

        [Test]
        public void test_the_normalized_vector()
        {
            var v1 = new Vector3(42, 37, 2);
            var v2 = v1.Normalize();

            AssertVector(v2, 0.749, 0.6606, 0.0357);
        }
    }
}