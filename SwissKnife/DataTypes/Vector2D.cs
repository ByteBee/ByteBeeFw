using System;
using System.Collections.Generic;

namespace SwissKnife.DataTypes
{
    public struct Vector2D : IEquatable<Vector2D>
    {
        private const double Epsilon = 10E-9;

        public double X { get; }
        public double Y { get; }

        public static Vector2D Zero => new Vector2D(0, 0);
        public static Vector2D One => new Vector2D(1, 1);
        public static Vector2D Xa => new Vector2D(1, 0);
        public static Vector2D Ya => new Vector2D(0, 1);

        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Vector2D(double[] a) : this(a[0], a[1]) { }
        public Vector2D(Vector2D v) : this(v.X, v.Y) { }
        public Vector2D(Tuple<double, double> t) : this(t.Item1, t.Item2) { }
        public Vector2D(KeyValuePair<double, double> t) : this(t.Key, t.Value) { }

        public bool Equals(Vector2D v) => IsEqual(v);

        public override string ToString() => $"X:{X}|Y:{Y}";

        public static implicit operator Vector2D(Vector3D v) => new Vector2D(v.X, v.Y);
        public static implicit operator Vector2D(Vector4D v) => new Vector2D(v.X, v.Y);
        public static implicit operator double[] (Vector2D v) => new[] { v.X, v.Y };
        public static implicit operator Tuple<double, double>(Vector2D v) => new Tuple<double, double>(v.X, v.Y);
        public static implicit operator KeyValuePair<double, double>(Vector2D v) => new KeyValuePair<double, double>(v.X, v.Y);

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
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

        public Vector2D Add(Vector2D v) => this + v;
        public Vector2D Add(double s) => this + s;
        public Vector2D Subtract(Vector2D v) => this - v;
        public Vector2D Subtract(double s) => this - s;
        public Vector2D Abs() => +this;
        public Vector2D Negate() => -this;
        public Vector2D Divide(double s) => this / s;
        public Vector2D Divide(Vector2D v) => this / v;

        public Vector2D Multiply(double s) => this * s;
        public Vector2D Multiply(Vector2D v) => this * v;

        public bool IsLessThan(Vector2D v) => this < v;
        public bool IsLessThanOrEqualTo(Vector2D v) => this <= v;
        public bool IsGreaterThan(Vector2D v) => this > v;
        public bool IsGreaterThanOrEqualTo(Vector2D v) => this >= v;

        public Vector2D Round(int precision) => new Vector2D(Math.Round(X, precision), Math.Round(Y, precision));

        public double Length => Math.Sqrt(X * X + Y * Y);

        public bool IsEqual(Vector2D v) => IsEqual(v, Epsilon);
        public bool IsZero => IsEqual(this, Epsilon);

        public bool IsEqual(Vector2D v, double tolerance) => Math.Abs(X - v.X) <= tolerance && Math.Abs(Y - v.Y) <= tolerance;

        public static Vector2D operator +(Vector2D a, Vector2D b) => new Vector2D(a.X + b.X, a.Y + b.Y);
        public static Vector2D operator +(Vector2D v, double s) => new Vector2D(v.X + s, v.Y + s);
        public static Vector2D operator +(double s, Vector2D v) => new Vector2D(s + v.X, s + v.Y);

        public static Vector2D operator -(Vector2D a, Vector2D b) => new Vector2D(a.X - b.X, a.Y - b.Y);
        public static Vector2D operator -(Vector2D v, double s) => new Vector2D(v.X - s, v.Y - s);
        public static Vector2D operator -(double s, Vector2D v) => new Vector2D(s - v.X, s - v.Y);

        public static Vector2D operator +(Vector2D v) => new Vector2D(Math.Abs(v.X), Math.Abs(v.Y));
        public static Vector2D operator -(Vector2D v) => new Vector2D(-v.X, -v.Y);

        public static Vector2D operator *(Vector2D a, Vector2D b) => new Vector2D(a.X * b.X, a.Y * b.Y);
        public static Vector2D operator *(Vector2D v, double s) => new Vector2D(v.X * s, v.Y * s);
        public static Vector2D operator *(double s, Vector2D v) => new Vector2D(s * v.X, s * v.Y);

        public static Vector2D operator /(Vector2D a, Vector2D b) => new Vector2D(a.X / b.X, a.Y / b.Y);
        public static Vector2D operator /(Vector2D v, double s) => new Vector2D(v.X / s, v.Y / s);
        public static Vector2D operator /(double s, Vector2D v) => new Vector2D(s / v.X, s / v.Y);

        public static bool operator ==(Vector2D a, Vector2D b) => a.Equals(b);
        public static bool operator !=(Vector2D a, Vector2D b) => !a.Equals(b);
        public static bool operator >(Vector2D a, Vector2D b) => (a.X > b.X) && (a.Y > b.Y);
        public static bool operator <(Vector2D a, Vector2D b) => (a.X < b.X) && (a.Y < b.Y);
        public static bool operator >=(Vector2D a, Vector2D b) => (a.X >= b.X) && (a.Y >= b.Y);
        public static bool operator <=(Vector2D a, Vector2D b) => (a.X <= b.X) && (a.Y <= b.Y);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            return obj is Vector2D && IsEqual((Vector2D)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X.GetHashCode() * 397) ^ Y.GetHashCode();
            }
        }
    }
}