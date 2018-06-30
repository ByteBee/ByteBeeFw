using System;
using System.Collections.Generic;
using static SwissKnife.Fancy;

namespace SwissKnife.Mathematics.Vector
{
    public struct Vector3D : IEquatable<Vector3D>
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public static Vector3D Zero => new Vector3D(0, 0, 0);
        public static Vector3D One => new Vector3D(1, 1, 1);
        public static Vector3D Xa => new Vector3D(1, 0, 0);
        public static Vector3D Ya => new Vector3D(0, 1, 0);
        public static Vector3D Za => new Vector3D(0, 0, 1);

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3D(double[] a) : this(a[0], a[1], a[2]) { }
        public Vector3D(Vector3D v) : this(v.X, v.Y, v.Z) { }
        public Vector3D(Tuple<double, double, double> t) : this(t.Item1, t.Item2, t.Item3) { }

        public bool Equals(Vector3D v) => IsEqual(v);

        public override string ToString() => $"X:{X}|Y:{Y}|Z:{Z}";

        public static implicit operator Vector3D(Vector2D v) => new Vector3D(v.X, v.Y, 0);
        public static implicit operator Vector3D(Vector4D v) => new Vector3D(v.X, v.Y, v.Z);
        public static implicit operator Vector3D(Vector2I v) => new Vector3D(v.X, v.Y, 0);
        public static implicit operator Vector3D(Vector3I v) => new Vector3D(v.X, v.Y, 0);
        public static implicit operator Vector3D(Vector4I v) => new Vector3D(v.X, v.Y, v.Z);
        public static implicit operator Vector3D(double[] arr) => new Vector3D(arr);
        public static implicit operator Vector3D(Tuple<double, double, double> tuple) => new Vector3D(tuple);

        public static implicit operator double[] (Vector3D v) => new[] { v.X, v.Y, v.Z };
        public static implicit operator Tuple<double, double, double>(Vector3D v)
            => new Tuple<double, double, double>(v.X, v.Y, v.Z);

        

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
                        throw new IndexOutOfRangeException();
                }
            }
        }

        public Vector3D Add(Vector3D v) => this + v;
        public Vector3D Add(double s) => this + s;
        public Vector3D Subtract(Vector3D v) => this - v;
        public Vector3D Subtract(double s) => this - s;
        public Vector3D Abs() => +this;
        public Vector3D Negate() => -this;
        public Vector3D Divide(double s) => this / s;
        public Vector3D Divide(Vector3D v) => this / v;

        public Vector3D Multiply(double s) => this * s;
        public Vector3D Multiply(Vector3D v) => this * v;

        public bool IsLessThan(Vector3D v) => this < v;
        public bool IsLessThanOrEqualTo(Vector3D v) => this <= v;
        public bool IsGreaterThan(Vector3D v) => this > v;
        public bool IsGreaterThanOrEqualTo(Vector3D v) => this >= v;

        public Vector3D Round(int precision)
            => new Vector3D(Math.Round(X, precision), Math.Round(Y, precision), Math.Round(Z, precision));

        public double Length => Math.Sqrt(X * X + Y * Y + Z * Z);

        public bool IsEqual(Vector3D v) => IsEqual(v, math.ZeroTolerance);
        public bool IsZero => IsEqual(this, math.ZeroTolerance);

        public bool IsEqual(Vector3D v, double t)
            => Math.Abs(X - v.X) <= t && Math.Abs(Y - v.Y) <= t && Math.Abs(Z - v.Z) <= t;

        public static Vector3D operator +(Vector3D a, Vector3D b) => new Vector3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        public static Vector3D operator +(Vector3D v, double s) => new Vector3D(v.X + s, v.Y + s, v.Z * s);
        public static Vector3D operator +(double s, Vector3D v) => new Vector3D(s + v.X, s + v.Y, s + v.Z);

        public static Vector3D operator -(Vector3D a, Vector3D b) => new Vector3D(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        public static Vector3D operator -(Vector3D v, double s) => new Vector3D(v.X - s, v.Y - s, v.Z - s);
        public static Vector3D operator -(double s, Vector3D v) => new Vector3D(s - v.X, s - v.Y, s - v.Z);

        public static Vector3D operator +(Vector3D v) => new Vector3D(Math.Abs(v.X), Math.Abs(v.Y), Math.Abs(v.Z));
        public static Vector3D operator -(Vector3D v) => new Vector3D(-v.X, -v.Y, -v.Z);

        public static Vector3D operator *(Vector3D a, Vector3D b) => new Vector3D(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        public static Vector3D operator *(Vector3D v, double s) => new Vector3D(v.X * s, v.Y * s, v.Z * s);
        public static Vector3D operator *(double s, Vector3D v) => new Vector3D(s * v.X, s * v.Y, s * v.Z);

        public static Vector3D operator /(Vector3D a, Vector3D b) => new Vector3D(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        public static Vector3D operator /(Vector3D v, double s) => new Vector3D(v.X / s, v.Y / s, v.Z / s);
        public static Vector3D operator /(double s, Vector3D v) => new Vector3D(s / v.X, s / v.Y, s / v.Z);

        public static bool operator ==(Vector3D a, Vector3D b) => a.Equals(b);
        public static bool operator !=(Vector3D a, Vector3D b) => !a.Equals(b);
        public static bool operator >(Vector3D a, Vector3D b) => (a.X > b.X) && (a.Y > b.Y) && (a.Z > b.Z);
        public static bool operator <(Vector3D a, Vector3D b) => (a.X < b.X) && (a.Y < b.Y) && (a.Z < b.Z);
        public static bool operator >=(Vector3D a, Vector3D b) => (a.X >= b.X) && (a.Y >= b.Y) && (a.Z >= b.Z);
        public static bool operator <=(Vector3D a, Vector3D b) => (a.X <= b.X) && (a.Y <= b.Y) && (a.Z <= b.Z);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            return obj is Vector3D && Equals((Vector3D)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                hashCode = (hashCode * 397) ^ Z.GetHashCode();
                return hashCode;
            }
        }
    }
}