using System;
using ByteBee.Exceptions;

namespace ByteBee.MathClause.Algebra
{
    public struct Vector3R : IEquatable<Vector3R>
    {
        public double X { get; private set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Vector3R Zero { get; } = new Vector3R(0, 0, 0);
        public static Vector3R One { get; } = new Vector3R(1, 1, 1);
        public static Vector3R I { get; } = new Vector3R(1, 0, 0);
        public static Vector3R J { get; } = new Vector3R(0, 1, 0);
        public static Vector3R K { get; } = new Vector3R(0, 0, 1);

        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return X;
                    case 1:
                        return Y;
                    case 2:
                        return Z;
                    default:
                        throw new InvalidVectorIndexException();
                }
            }
        }

        public Vector3R(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }


        public Vector3R(double s) : this(s, s, s)
        {
        }


        public Vector3R(double[] a) : this(a[0], a[1], a[2])
        {
        }

        public Vector3R(Vector3R v) : this(v.X, v.Y, v.Z)
        {
        }

        public Vector3R(Tuple<double, double, double> t) : this(t.Item1, t.Item2, t.Item3)
        {
        }

        public override string ToString()
        {
            return $"X:{X}|Y:{Y}|Z:{Z}";
        }

        public static implicit operator Vector3R(double[] arr)
        {
            return new Vector3R(arr);
        }

        public static implicit operator Vector3R(Tuple<double, double, double> tuple)
        {
            return new Vector3R(tuple);
        }

        public static implicit operator double[] (Vector3R v)
        {
            return new[] { v.X, v.Y, v.Z };
        }

        public static implicit operator Tuple<double, double, double>(Vector3R v)
        {
            return new Tuple<double, double, double>(v.X, v.Y, v.Z);
        }

        public void Add(Vector3R v)
        {
            X += v.X;
            Y += v.Y;
            Z += v.Z;
        }

        public void Add(double s)
        {
            X += s;
            Y += s;
            Z += s;
        }

        public void Subtract(Vector3R v)
        {
            X -= v.X;
            Y -= v.Y;
            Z -= v.Z;
        }

        public void Subtract(double s)
        {
            X -= s;
            Y -= s;
            Z -= s;
        }

        public void Multiply(Vector3R v)
        {
            X *= v.X;
            Y *= v.Y;
            Z *= v.Z;
        }

        public void Multiply(double s)
        {
            X *= s;
            Y *= s;
            Z *= s;
        }

        public void Divide(Vector3R v)
        {
            X /= v.X;
            Y /= v.Y;
            Z /= v.Z;
        }

        public void Divide(double s)
        {
            X /= s;
            Y /= s;
            Z /= s;
        }

        public void Round(int precision)
        {
            X = Bee.Math.Round(X, precision);
            Y = Bee.Math.Round(Y, precision);
            Z = Bee.Math.Round(Z, precision);
        }

        public void Abs()
        {
            X = Bee.Math.Abs(X);
            Y = Bee.Math.Abs(Y);
            Z = Bee.Math.Abs(Z);
        }

        public bool IsLessThan(Vector3R v)
        {
            return X < v.X && Y < v.Y && Z < v.Z;
        }

        public bool IsLessThanOrEqual(Vector3R v)
        {
            return X <= v.X && Y <= v.Y && Z <= v.Z;
        }

        public bool IsGreaterThan(Vector3R v)
        {
            return X > v.X && Y > v.Y && Z > v.Z;
        }

        public bool IsGreaterThanOrEqual(Vector3R v)
        {
            return X >= v.X && Y >= v.Y && Z >= v.Z;
        }

        public double GetLength()
        {
            return Bee.Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public void Normalize()
        {
            double length = GetLength();
            Divide(length);
        }

        public bool Equals(Vector3R v)
        {
            return IsEqual(v);
        }

        public bool IsEqual(Vector3R v)
        {
            return IsEqual(v, Bee.Math.ZeroTolerance);
        }

        public bool IsZero()
        {
            return IsEqual(this, Bee.Math.ZeroTolerance);
        }

        public bool IsEqual(Vector3R v, double t)
        {
            bool xAreEqual = Bee.Math.Abs(X - v.X) <= t;
            bool yAreEqual = Bee.Math.Abs(Y - v.Y) <= t;
            bool zAreEqual = Bee.Math.Abs(Z - v.Z) <= t;

            return xAreEqual && yAreEqual && zAreEqual;
        }

        public static Vector3R operator +(Vector3R a, Vector3R b)
        {
            double x = a.X + b.X;
            double y = a.Y + b.Y;
            double z = a.Z + b.Z;
            return new Vector3R(x, y, z);
        }

        public static Vector3R operator +(Vector3R v, double s)
        {
            double x = v.X + s;
            double y = v.Y + s;
            double z = v.Z + s;
            return new Vector3R(x, y, z);
        }

        public static Vector3R operator +(double s, Vector3R v)
        {
            return v + s;
        }

        public static Vector3R operator -(Vector3R a, Vector3R b)
        {
            double x = a.X - b.X;
            double y = a.Y - b.Y;
            double z = a.Z - b.Z;
            return new Vector3R(x, y, z);
        }

        public static Vector3R operator -(Vector3R v, double s)
        {
            double x = v.X - s;
            double y = v.Y - s;
            double z = v.Z - s;
            return new Vector3R(x, y, z);
        }

        public static Vector3R operator -(double s, Vector3R v)
        {
            double x = s - v.X;
            double y = s - v.Y;
            double z = s - v.Z;
            return new Vector3R(x, y, z);
        }

        public static Vector3R operator *(Vector3R a, Vector3R b)
        {
            double x = a.X * b.X;
            double y = a.Y * b.Y;
            double z = a.Z * b.Z;
            return new Vector3R(x, y, z);
        }

        public static Vector3R operator *(Vector3R v, double s)
        {
            double x = v.X * s;
            double y = v.Y * s;
            double z = v.Z * s;
            return new Vector3R(x, y, z);
        }

        public static Vector3R operator *(double s, Vector3R v)
        {
            double x = s * v.X;
            double y = s * v.Y;
            double z = s * v.Z;
            return new Vector3R(x, y, z);
        }

        public static Vector3R operator /(Vector3R a, Vector3R b)
        {
            double x = a.X / b.X;
            double y = a.Y / b.Y;
            double z = a.Z / b.Z;
            return new Vector3R(x, y, z);
        }

        public static Vector3R operator /(Vector3R v, double s)
        {
            double x = v.X / s;
            double y = v.Y / s;
            double z = v.Z / s;
            return new Vector3R(x, y, z);
        }

        public static Vector3R operator /(double s, Vector3R v)
        {
            double x = s / v.X;
            double y = s / v.Y;
            double z = s / v.Z;
            return new Vector3R(x, y, z);
        }

        public static Vector3R operator +(Vector3R v)
        {
            double x = Bee.Math.Abs(v.X);
            double y = Bee.Math.Abs(v.Y);
            double z = Bee.Math.Abs(v.Z);
            return new Vector3R(x, y, z);
        }

        public static Vector3R operator -(Vector3R v)
        {
            double x = -v.X;
            double y = -v.Y;
            double z = -v.Z;
            return new Vector3R(x, y, z);
        }

        public static bool operator ==(Vector3R a, Vector3R b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Vector3R a, Vector3R b)
        {
            return !a.Equals(b);
        }

        public static bool operator >(Vector3R a, Vector3R b)
        {
            return a.IsGreaterThan(b);
        }

        public static bool operator <(Vector3R a, Vector3R b)
        {
            return a.IsLessThan(b);
        }

        public static bool operator >=(Vector3R a, Vector3R b)
        {
            return a.IsGreaterThanOrEqual(b);
        }

        public static bool operator <=(Vector3R a, Vector3R b)
        {
            return a.IsLessThanOrEqual(b);
        }

        public override bool Equals(object obj)
        {
            return !ReferenceEquals(null, obj) && obj is Vector3R v && Equals(v);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                // ReSharper disable NonReadonlyMemberInGetHashCode
                int hashCode = X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                hashCode = (hashCode * 397) ^ Z.GetHashCode();
                // ReSharper restore NonReadonlyMemberInGetHashCode
                return hashCode;
            }
        }
    }
}