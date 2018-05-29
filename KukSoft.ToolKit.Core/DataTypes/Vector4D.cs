using System;

namespace KukSoft.ToolKit.DataTypes
{
    public struct Vector4D
    {
        private const double Epsilon = 10E-9;

        public double W { get; }
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public static Vector4D Zero => new Vector4D(0, 0, 0, 0);
        public static Vector4D One => new Vector4D(1, 1, 1, 0);
        public static Vector4D Wa => new Vector4D(1, 0, 0, 0);
        public static Vector4D Xa => new Vector4D(0, 1, 0, 0);
        public static Vector4D Ya => new Vector4D(0, 0, 1, 0);
        public static Vector4D Za => new Vector4D(0, 0, 0, 1);

        public Vector4D(double w, double x, double y, double z)
        {
            W = w;
            X = x;
            Y = y;
            Z = z;
        }

        public Vector4D(double[] a) : this(a[0], a[1], a[2], a[3]) { }
        public Vector4D(Vector4D v) : this(v.W, v.X, v.Y, v.Z) { }
        public Vector4D(Tuple<double, double, double, double> t) : this(t.Item1, t.Item2, t.Item3, t.Item4) { }

        public bool Equals(Vector4D v) => IsEqual(v);

        public override string ToString() => $"W:{W}|X:{X}|Y:{Y}|Z:{Z}";

        public static implicit operator Vector4D(Vector2D v) => new Vector4D(0, v.X, v.Y, 0);
        public static implicit operator Vector4D(Vector3D v) => new Vector4D(0, v.X, v.Y, v.Z);
        public static implicit operator double[] (Vector4D v) => new[] { v.W, v.X, v.Y, v.Z };

        public static implicit operator Tuple<double, double, double, double>(Vector4D v)
            => new Tuple<double, double, double, double>(v.W, v.X, v.Y, v.Z);

        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return W;
                    case 1:
                        return X;
                    case 2:
                        return Y;
                    case 3:
                        return Z;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

        public Vector4D Add(Vector4D v) => this + v;
        public Vector4D Add(double s) => this + s;
        public Vector4D Subtract(Vector4D v) => this - v;
        public Vector4D Subtract(double s) => this - s;
        public Vector4D Abs() => +this;
        public Vector4D Negate() => -this;
        public Vector4D Divide(double s) => this / s;
        public Vector4D Divide(Vector4D v) => this / v;

        public Vector4D Multiply(double s) => this * s;
        public Vector4D Multiply(Vector4D v) => this * v;

        public bool IsLessThan(Vector4D v) => this < v;
        public bool IsLessThanOrEqualTo(Vector4D v) => this <= v;
        public bool IsGreaterThan(Vector4D v) => this > v;
        public bool IsGreaterThanOrEqualTo(Vector4D v) => this >= v;

        public Vector4D Round(int precision)
            => new Vector4D(Math.Round(Z, precision), Math.Round(X, precision), Math.Round(Y, precision), Math.Round(Z, precision));

        public double Length => Math.Sqrt(W * W + X * X + Y * Y + Z * Z);

        public bool IsEqual(Vector4D v) => IsEqual(v, Epsilon);
        public bool IsZero => IsEqual(this, Epsilon);

        public bool IsEqual(Vector4D v, double t)
            => Math.Abs(W - v.W) <= t && Math.Abs(X - v.X) <= t && Math.Abs(Y - v.Y) <= t && Math.Abs(Z - v.Z) <= t;

        public static Vector4D operator +(Vector4D a, Vector4D b) => new Vector4D(a.W + b.W, a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        public static Vector4D operator +(Vector4D v, double s) => new Vector4D(v.W + s, v.X + s, v.Y + s, v.Z * s);
        public static Vector4D operator +(double s, Vector4D v) => new Vector4D(s + v.W, s + v.X, s + v.Y, s + v.Z);

        public static Vector4D operator -(Vector4D a, Vector4D b) => new Vector4D(a.W - b.W, a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        public static Vector4D operator -(Vector4D v, double s) => new Vector4D(v.W - s, v.X - s, v.Y - s, v.Z - s);
        public static Vector4D operator -(double s, Vector4D v) => new Vector4D(s - v.W, s - v.X, s - v.Y, s - v.Z);

        public static Vector4D operator +(Vector4D v) => new Vector4D(Math.Abs(v.W), Math.Abs(v.X), Math.Abs(v.Y), Math.Abs(v.Z));
        public static Vector4D operator -(Vector4D v) => new Vector4D(-v.W, -v.X, -v.Y, -v.Z);

        public static Vector4D operator *(Vector4D a, Vector4D b) => new Vector4D(a.W * b.W, a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        public static Vector4D operator *(Vector4D v, double s) => new Vector4D(v.W * s, v.X * s, v.Y * s, v.Z * s);
        public static Vector4D operator *(double s, Vector4D v) => new Vector4D(s * v.W, s * v.X, s * v.Y, s * v.Z);

        public static Vector4D operator /(Vector4D a, Vector4D b) => new Vector4D(a.W / b.W, a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        public static Vector4D operator /(Vector4D v, double s) => new Vector4D(v.W / s, v.X / s, v.Y / s, v.Z / s);
        public static Vector4D operator /(double s, Vector4D v) => new Vector4D(s / v.W, s / v.X, s / v.Y, s / v.Z);

        public static bool operator ==(Vector4D a, Vector4D b) => a.Equals(b);
        public static bool operator !=(Vector4D a, Vector4D b) => !a.Equals(b);
        public static bool operator >(Vector4D a, Vector4D b) => (a.W > b.W) && (a.X > b.X) && (a.Y > b.Y) && (a.Z > b.Z);
        public static bool operator <(Vector4D a, Vector4D b) => (a.W < b.W) && (a.X < b.X) && (a.Y < b.Y) && (a.Z < b.Z);
        public static bool operator >=(Vector4D a, Vector4D b) => (a.W >= b.W) && (a.X >= b.X) && (a.Y >= b.Y) && (a.Z >= b.Z);
        public static bool operator <=(Vector4D a, Vector4D b) => (a.W <= b.W) && (a.X <= b.X) && (a.Y <= b.Y) && (a.Z <= b.Z);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            return obj is Vector4D && Equals((Vector4D)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = W.GetHashCode();
                hashCode = (hashCode * 397) ^ X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                hashCode = (hashCode * 397) ^ Z.GetHashCode();
                return hashCode;
            }
        }

    }
}