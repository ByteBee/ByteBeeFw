using ByteBee.MathClause.Algebra;
using NUnit.Framework;

namespace ByteBeeTests.MathClause.Algebra.Vector
{
    [TestFixture]
    public class MiscVectorTests : AbstractVectorTests
    {
        [Test]
        public void i_can_create_a_vector()
        {
            var v = new Vector3R();
            Assert.IsNotNull(v);
        }

        [Test]
        public void perform_operations_should_not_change_originals()
        {
            var v1 = new Vector3R(1, 2, 3);
            var v2 = new Vector3R(3, 2, 1);

            Vector3R v3 = v1 + v2;

            Assert.AreEqual(1, v1.X, "v1");
            Assert.AreEqual(3, v2.X, "v2");
            Assert.AreEqual(4, v3.X, "v3");
        }

        [Test]
        public void check_unit_vectors()
        {
            AssertVector(Vector3R.I, 1, 0, 0);
            AssertVector(Vector3R.J, 0, 1, 0);
            AssertVector(Vector3R.K, 0, 0, 1);

            AssertVector(Vector3R.Zero, 0, 0, 0);
            AssertVector(Vector3R.One, 1, 1, 1);
        }

        [Test]
        public void check_the_tostring_method()
        {
            Vector3R one = Vector3R.One;

            string str = one.ToString();

            Assert.That(str, Is.EqualTo("X:1|Y:1|Z:1"));
        }

        [Test]
        public void round_the_vector_to_two_sig_digs()
        {
            Vector3R vector = new Vector3R(1.2346, 2.3456, 3.4567);

            vector.Round(2);

            AssertVector(vector, 1.23, 2.35, 3.46);
        }

        [Test]
        public void make_an_absolute_vector()
        {
            Vector3R vector = new Vector3R(-20, -34, -42);

            vector.Abs();

            AssertVector(vector, 20, 34, 42);
        }

        [Test]
        public void make_an_absolute_vector_op()
        {
            Vector3R v1 = new Vector3R(-20, -34, -42);
            Vector3R v2 = +v1;

            AssertVector(v1, -20, -34, -42);
            AssertVector(v2, 20, 34, 42);
        }

        [Test]
        public void negate_vector()
        {
            Vector3R v1 = new Vector3R(-20, 34, -42);
            Vector3R v2 = -v1;

            AssertVector(v1, -20, 34, -42);
            AssertVector(v2, 20, -34, 42);
        }

        [TestCase(1, 2, 2, 3)]
        [TestCase(3, 3, 1, 4.3588)]
        public void length_of_one_vector_should_be_one(double x, double y, double z, double expected)
        {
            var vector = new Vector3R(x, y, z);

            double actual = vector.GetLength();

            Assert.AreEqual(expected, actual, 0.001);
        }

        [Test]
        public void calculate_the_hash_code()
        {
            int i = Vector3R.I.GetHashCode();
            int j = Vector3R.J.GetHashCode();
            int k = Vector3R.K.GetHashCode();

            Assert.AreEqual(-982515712, i);
            Assert.AreEqual(657457152, j);
            Assert.AreEqual(1072693248, k);
        }

        [Test]
        public void test_the_normalized_vector()
        {
            var v = new Vector3R(42, 37, 2);

            v.Normalize();

            AssertVector(v, 0.749, 0.6606, 0.0357);
        }
    }
}