using System;
using System.Collections.Generic;

namespace SwissKnife.Mathematics.Vector
{
    public struct Vector2I : IEquatable<Vector2I>
    {
        public int X { get; }
        public int Y { get; }

        public static Vector2I Zero => new Vector2I(0, 0);
        public static Vector2I One => new Vector2I(1, 1);
        public static Vector2I Xa => new Vector2I(1, 0);
        public static Vector2I Ya => new Vector2I(0, 1);

        public Vector2I(int x, int y)
        {
            X = x;
            Y = y;
        }

        private Vector2I(double x, double y)
        {
            X = (int)x;
            Y = (int)y;
        }

        public Vector2I(int[] a) : this(a[0], a[1]) { }
        public Vector2I(Vector2I v) : this(v.X, v.Y) { }
        public Vector2I(Tuple<int, int> t) : this(t.Item1, t.Item2) { }
        public Vector2I(KeyValuePair<int, int> kvp) : this(kvp.Key, kvp.Value) { }

        public bool Equals(Vector2I v) => IsEqual(v);

        public override string ToString() => $"X:{X}|Y:{Y}";

        public static implicit operator Vector2I(Vector3I v) => new Vector2I(v.X, v.Y);
        public static implicit operator Vector2I(Vector4I v) => new Vector2I(v.X, v.Y);
        public static implicit operator Vector2I(Vector2D v) => new Vector2I(v.X, v.Y);
        public static implicit operator Vector2I(Vector3D v) => new Vector2I(v.X, v.Y);
        public static implicit operator Vector2I(Vector4D v) => new Vector2I(v.X, v.Y);
        public static implicit operator Vector2I(int[] arr) => new Vector2I(arr);
        public static implicit operator Vector2I(Tuple<int, int> tuple) => new Vector2I(tuple);
        public static implicit operator Vector2I(KeyValuePair<int, int> kvp) => new Vector2I(kvp);
        public static implicit operator int[] (Vector2I v) => new[] { v.X, v.Y };
        public static implicit operator Tuple<int, int>(Vector2I v) => new Tuple<int, int>(v.X, v.Y);
        public static implicit operator KeyValuePair<int, int>(Vector2I v) => new KeyValuePair<int, int>(v.X, v.Y);
        
        public int this[int index]
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

        public Vector2I Add(Vector2I v) => this + v;
        public Vector2I Add(int s) => this + s;
        public Vector2I Subtract(Vector2I v) => this - v;
        public Vector2I Subtract(int s) => this - s;
        public Vector2I Abs() => +this;
        public Vector2I Negate() => -this;
        public Vector2I Divide(int s) => this / s;
        public Vector2I Divide(Vector2I v) => this / v;

        public Vector2I Multiply(int s) => this * s;
        public Vector2I Multiply(Vector2I v) => this * v;

        public bool IsLessThan(Vector2I v) => this < v;
        public bool IsLessThanOrEqualTo(Vector2I v) => this <= v;
        public bool IsGreaterThan(Vector2I v) => this > v;
        public bool IsGreaterThanOrEqualTo(Vector2I v) => this >= v;

        public double Length => Math.Sqrt(X * X + Y * Y);

        public bool IsZero => IsEqual(this);

        public bool IsEqual(Vector2I v) => X == v.X && Y == v.Y;

        public static Vector2I operator +(Vector2I a, Vector2I b) => new Vector2I(a.X + b.X, a.Y + b.Y);
        public static Vector2I operator +(Vector2I v, int s) => new Vector2I(v.X + s, v.Y + s);
        public static Vector2I operator +(int s, Vector2I v) => new Vector2I(s + v.X, s + v.Y);

        public static Vector2I operator -(Vector2I a, Vector2I b) => new Vector2I(a.X - b.X, a.Y - b.Y);
        public static Vector2I operator -(Vector2I v, int s) => new Vector2I(v.X - s, v.Y - s);
        public static Vector2I operator -(int s, Vector2I v) => new Vector2I(s - v.X, s - v.Y);

        public static Vector2I operator +(Vector2I v) => new Vector2I(Math.Abs(v.X), Math.Abs(v.Y));
        public static Vector2I operator -(Vector2I v) => new Vector2I(-v.X, -v.Y);

        public static Vector2I operator *(Vector2I a, Vector2I b) => new Vector2I(a.X * b.X, a.Y * b.Y);
        public static Vector2I operator *(Vector2I v, int s) => new Vector2I(v.X * s, v.Y * s);
        public static Vector2I operator *(int s, Vector2I v) => new Vector2I(s * v.X, s * v.Y);

        public static Vector2I operator /(Vector2I a, Vector2I b) => new Vector2I(a.X / b.X, a.Y / b.Y);
        public static Vector2I operator /(Vector2I v, int s) => new Vector2I(v.X / s, v.Y / s);
        public static Vector2I operator /(int s, Vector2I v) => new Vector2I(s / v.X, s / v.Y);

        public static bool operator ==(Vector2I a, Vector2I b) => a.Equals(b);
        public static bool operator !=(Vector2I a, Vector2I b) => !a.Equals(b);
        public static bool operator >(Vector2I a, Vector2I b) => (a.X > b.X) && (a.Y > b.Y);
        public static bool operator <(Vector2I a, Vector2I b) => (a.X < b.X) && (a.Y < b.Y);
        public static bool operator >=(Vector2I a, Vector2I b) => (a.X >= b.X) && (a.Y >= b.Y);
        public static bool operator <=(Vector2I a, Vector2I b) => (a.X <= b.X) && (a.Y <= b.Y);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            return obj is Vector2I && IsEqual((Vector2I)obj);
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