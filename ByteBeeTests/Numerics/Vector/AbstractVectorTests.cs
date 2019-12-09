using ByteBee.Numerics.LinearAlgebra;
using NUnit.Framework;

namespace ByteBeeTests.MathClause.Algebra.Vector
{
    public abstract class AbstractVectorTests
    {
        protected void AssertVector(Vector3 v, double x, double y, double z)
        {
            Assert.AreEqual(x, v.X, 1E-3, "v:X");
            Assert.AreEqual(y, v.Y, 1E-3, "v:Y");
            Assert.AreEqual(z, v.Z, 1E-3, "v:Z");
        }
    }
}