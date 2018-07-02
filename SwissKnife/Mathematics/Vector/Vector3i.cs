using System;

namespace SwissKnife.Mathematics.Vector
{
    public struct Vector3I : IEquatable<Vector3I>
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public static Vector3I Zero => new Vector3I(0, 0, 0);
        public static Vector3I One => new Vector3I(1, 1, 1);
        public static Vector3I Xa => new Vector3I(1, 0, 0);
        public static Vector3I Ya => new Vector3I(0, 1, 0);
        public static Vector3I Za => new Vector3I(0, 0, 1);

        public Vector3I(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        private Vector3I(double x, double y, double z)
        {
            X = (int)x;
            Y = (int)y;
            Z = (int)z;
        }

        public Vector3I(int[] a) : this(a[0], a[1], a[2]) { }
        public Vector3I(Vector3I v) : this(v.X, v.Y, v.Z) { }
        public Vector3I(Tuple<int, int, int> t) : this(t.Item1, t.Item2, t.Item3) { }

        /// <inheritdoc />
        public bool Equals(Vector3I v) => IsEqual(v);

        /// <inheritdoc />
        public override string ToString() => $"X:{X}|Y:{Y}|Z:{Z}";

        public static implicit operator Vector3I(Vector2I v) => new Vector3I(v.X, v.Y, 0);
        public static implicit operator Vector3I(Vector4I v) => new Vector3I(v.X, v.Y, v.Z);
        public static implicit operator Vector3I(Vector2D v) => new Vector3I(v.X, v.Y, 0);
        public static implicit operator Vector3I(Vector3D v) => new Vector3I(v.X, v.Y, 0);
        public static implicit operator Vector3I(Vector4D v) => new Vector3I(v.X, v.Y, v.Z);
        public static implicit operator Vector3I(int[] arr) => new Vector3I(arr);
        public static implicit operator Vector3I(Tuple<int, int, int> tuple) => new Vector3I(tuple);
        public static implicit operator int[] (Vector3I v) => new[] { v.X, v.Y, v.Z };
        public static implicit operator Tuple<int, int, int>(Vector3I v) => new Tuple<int, int, int>(v.X, v.Y, v.Z);

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
                    case 2:
                        return Z;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

        public Vector3I Add(Vector3I v) => this + v;
        public Vector3I Add(int s) => this + s;
        public Vector3I Subtract(Vector3I v) => this - v;
        public Vector3I Subtract(int s) => this - s;
        public Vector3I Abs() => +this;
        public Vector3I Negate() => -this;
        public Vector3I Divide(int s) => this / s;
        public Vector3I Divide(Vector3I v) => this / v;

        public Vector3I Multiply(int s) => this * s;
        public Vector3I Multiply(Vector3I v) => this * v;

        public bool IsLessThan(Vector3I v) => this < v;
        public bool IsLessThanOrEqualTo(Vector3I v) => this <= v;
        public bool IsGreaterThan(Vector3I v) => this > v;
        public bool IsGreaterThanOrEqualTo(Vector3I v) => this >= v;

        public double Length => Math.Sqrt(X * X + Y * Y + Z * Z);

        public bool IsZero => IsEqual(this);

        public bool IsEqual(Vector3I v) => X == v.X && Y == v.Y && Z == v.Z;

        public static Vector3I operator +(Vector3I a, Vector3I b) => new Vector3I(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        public static Vector3I operator +(Vector3I v, int s) => new Vector3I(v.X + s, v.Y + s, v.Z * s);
        public static Vector3I operator +(int s, Vector3I v) => new Vector3I(s + v.X, s + v.Y, s + v.Z);

        public static Vector3I operator -(Vector3I a, Vector3I b) => new Vector3I(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        public static Vector3I operator -(Vector3I v, int s) => new Vector3I(v.X - s, v.Y - s, v.Z - s);
        public static Vector3I operator -(int s, Vector3I v) => new Vector3I(s - v.X, s - v.Y, s - v.Z);

        public static Vector3I operator +(Vector3I v) => new Vector3I(Math.Abs(v.X), Math.Abs(v.Y), Math.Abs(v.Z));
        public static Vector3I operator -(Vector3I v) => new Vector3I(-v.X, -v.Y, -v.Z);

        public static Vector3I operator *(Vector3I a, Vector3I b) => new Vector3I(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        public static Vector3I operator *(Vector3I v, int s) => new Vector3I(v.X * s, v.Y * s, v.Z * s);
        public static Vector3I operator *(int s, Vector3I v) => new Vector3I(s * v.X, s * v.Y, s * v.Z);

        public static Vector3I operator /(Vector3I a, Vector3I b) => new Vector3I(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        public static Vector3I operator /(Vector3I v, int s) => new Vector3I(v.X / s, v.Y / s, v.Z / s);
        public static Vector3I operator /(int s, Vector3I v) => new Vector3I(s / v.X, s / v.Y, s / v.Z);

        public static bool operator ==(Vector3I a, Vector3I b) => a.Equals(b);
        public static bool operator !=(Vector3I a, Vector3I b) => !a.Equals(b);
        public static bool operator >(Vector3I a, Vector3I b) => (a.X > b.X) && (a.Y > b.Y) && (a.Z > b.Z);
        public static bool operator <(Vector3I a, Vector3I b) => (a.X < b.X) && (a.Y < b.Y) && (a.Z < b.Z);
        public static bool operator >=(Vector3I a, Vector3I b) => (a.X >= b.X) && (a.Y >= b.Y) && (a.Z >= b.Z);
        public static bool operator <=(Vector3I a, Vector3I b) => (a.X <= b.X) && (a.Y <= b.Y) && (a.Z <= b.Z);

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            return obj is Vector3I && Equals((Vector3I)obj);
        }

        /// <inheritdoc />
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