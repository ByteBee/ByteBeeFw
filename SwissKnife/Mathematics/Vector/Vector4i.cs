using System;

namespace SwissKnife.Mathematics.Vector
{
    public struct Vector4I
    {
        public int W { get; }
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public static Vector4I Zero => new Vector4I(0, 0, 0, 0);
        public static Vector4I One => new Vector4I(1, 1, 1, 0);
        public static Vector4I Wa => new Vector4I(1, 0, 0, 0);
        public static Vector4I Xa => new Vector4I(0, 1, 0, 0);
        public static Vector4I Ya => new Vector4I(0, 0, 1, 0);
        public static Vector4I Za => new Vector4I(0, 0, 0, 1);

        public Vector4I(int w, int x, int y, int z)
        {
            W = w;
            X = x;
            Y = y;
            Z = z;
        }

        private Vector4I(double w, double x, double y, double z)
        {
            W = (int)w;
            X = (int)x;
            Y = (int)y;
            Z = (int)z;
        }

        public Vector4I(int[] a) : this(a[0], a[1], a[2], a[3]) { }
        public Vector4I(Vector4I v) : this(v.W, v.X, v.Y, v.Z) { }
        public Vector4I(Tuple<int, int, int, int> t) : this(t.Item1, t.Item2, t.Item3, t.Item4) { }

        public bool Equals(Vector4I v) => IsEqual(v);

        public override string ToString() => $"W:{W}|X:{X}|Y:{Y}|Z:{Z}";

        public static implicit operator Vector4I(Vector2I v) => new Vector4I(0, v.X, v.Y, 0);
        public static implicit operator Vector4I(Vector3I v) => new Vector4I(0, v.X, v.Y, v.Z);
        public static implicit operator Vector4I(Vector2D v) => new Vector4I(0, v.X, v.Y, 0);
        public static implicit operator Vector4I(Vector3D v) => new Vector4I(0, v.X, v.Y, v.Z);
        public static implicit operator Vector4I(Vector4D v) => new Vector4I(0, v.X, v.Y, v.Z);
        public static implicit operator int[] (Vector4I v) => new[] { v.W, v.X, v.Y, v.Z };
        public static implicit operator Tuple<int, int, int, int>(Vector4I v) => new Tuple<int, int, int, int>(v.W, v.X, v.Y, v.Z);
        public static implicit operator Vector4I(int[] arr) => new Vector4I(arr);
        public static implicit operator Vector4I(Tuple<int, int, int, int> tuple) => new Vector4I(tuple);

        public int this[int index]
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

        public Vector4I Add(Vector4I v) => this + v;
        public Vector4I Add(int s) => this + s;
        public Vector4I Subtract(Vector4I v) => this - v;
        public Vector4I Subtract(int s) => this - s;
        public Vector4I Abs() => +this;
        public Vector4I Negate() => -this;
        public Vector4I Divide(int s) => this / s;
        public Vector4I Divide(Vector4I v) => this / v;

        public Vector4I Multiply(int s) => this * s;
        public Vector4I Multiply(Vector4I v) => this * v;

        public bool IsLessThan(Vector4I v) => this < v;
        public bool IsLessThanOrEqualTo(Vector4I v) => this <= v;
        public bool IsGreaterThan(Vector4I v) => this > v;
        public bool IsGreaterThanOrEqualTo(Vector4I v) => this >= v;

        public double Length => Math.Sqrt(W * W + X * X + Y * Y + Z * Z);

        public bool IsZero => IsEqual(this);

        public bool IsEqual(Vector4I v)
            => W == v.W && X == v.X && Y == v.Y && Z == v.Z;

        public static Vector4I operator +(Vector4I a, Vector4I b) => new Vector4I(a.W + b.W, a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        public static Vector4I operator +(Vector4I v, int s) => new Vector4I(v.W + s, v.X + s, v.Y + s, v.Z * s);
        public static Vector4I operator +(int s, Vector4I v) => new Vector4I(s + v.W, s + v.X, s + v.Y, s + v.Z);

        public static Vector4I operator -(Vector4I a, Vector4I b) => new Vector4I(a.W - b.W, a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        public static Vector4I operator -(Vector4I v, int s) => new Vector4I(v.W - s, v.X - s, v.Y - s, v.Z - s);
        public static Vector4I operator -(int s, Vector4I v) => new Vector4I(s - v.W, s - v.X, s - v.Y, s - v.Z);

        public static Vector4I operator +(Vector4I v) => new Vector4I(Math.Abs(v.W), Math.Abs(v.X), Math.Abs(v.Y), Math.Abs(v.Z));
        public static Vector4I operator -(Vector4I v) => new Vector4I(-v.W, -v.X, -v.Y, -v.Z);

        public static Vector4I operator *(Vector4I a, Vector4I b) => new Vector4I(a.W * b.W, a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        public static Vector4I operator *(Vector4I v, int s) => new Vector4I(v.W * s, v.X * s, v.Y * s, v.Z * s);
        public static Vector4I operator *(int s, Vector4I v) => new Vector4I(s * v.W, s * v.X, s * v.Y, s * v.Z);

        public static Vector4I operator /(Vector4I a, Vector4I b) => new Vector4I(a.W / b.W, a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        public static Vector4I operator /(Vector4I v, int s) => new Vector4I(v.W / s, v.X / s, v.Y / s, v.Z / s);
        public static Vector4I operator /(int s, Vector4I v) => new Vector4I(s / v.W, s / v.X, s / v.Y, s / v.Z);

        public static bool operator ==(Vector4I a, Vector4I b) => a.Equals(b);
        public static bool operator !=(Vector4I a, Vector4I b) => !a.Equals(b);
        public static bool operator >(Vector4I a, Vector4I b) => (a.W > b.W) && (a.X > b.X) && (a.Y > b.Y) && (a.Z > b.Z);
        public static bool operator <(Vector4I a, Vector4I b) => (a.W < b.W) && (a.X < b.X) && (a.Y < b.Y) && (a.Z < b.Z);
        public static bool operator >=(Vector4I a, Vector4I b) => (a.W >= b.W) && (a.X >= b.X) && (a.Y >= b.Y) && (a.Z >= b.Z);
        public static bool operator <=(Vector4I a, Vector4I b) => (a.W <= b.W) && (a.X <= b.X) && (a.Y <= b.Y) && (a.Z <= b.Z);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            return obj is Vector4I && Equals((Vector4I)obj);
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