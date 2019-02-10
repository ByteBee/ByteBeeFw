using System;
using ByteBee.Mathematics.Functions;

namespace ByteBee.Mathematics.Functions
{
    public partial interface IMathFunctions : ITrinogometryFunctions
    {
        double E { get; }
        double Epsilon { get; }
        double ZeroTolerance { get; }
        double Deg2Rad { get; }
        double Rad2Deg { get; }
        double Pi { get; }
        double Pi2 { get; }
        double Pi4 { get; }
        double PiO2 { get; }

        MathConstant Const { get; }

        decimal Truncate(decimal d);
        double Truncate(double d);

        double IeeeRemainder(double x, double y);

        long BigMul(int a, int b);
        int DivRem(int a, int b, out int result);
        long DivRem(long a, long b, out long result);
        double Sqrt(double d);
        bool IsFinite(double d);
        bool IsFinite(float d);

        bool IsBetween(float value, float low, float high);
        bool IsBetween(double value, double low, double high);
        bool IsBetween(int value, int low, int high);

        double InvSqrt(double f);
        bool Approx(double a, double b);
        bool Approx(double a, double b, double epsilon);
    }

    internal partial class MathFunctions : IMathFunctions
    {
        public double E { get; } = Math.E;
        public double Epsilon { get; } = 2.2204460492503131E-13;
        public double ZeroTolerance { get; } = 1E-08;
        public double Deg2Rad { get; } = Math.PI / 180;
        public double Rad2Deg { get; } = 180 / Math.PI;
        public double Pi { get; } = Math.PI;
        public double Pi2 { get; } = Math.PI * 2;
        public double Pi4 { get; } = Math.PI * 4;
        public double PiO2 { get; } = Math.PI / 2;

        public MathConstant Const { get; } = new MathConstant();

        public decimal Truncate(decimal d) => Math.Truncate(d);
        public double Truncate(double d) => Math.Truncate(d);

        public double IeeeRemainder(double x, double y) => Math.IEEERemainder(x, y);

        public long DivRem(long a, long b, out long result) => Math.DivRem(a, b, out result);
        public double Sqrt(double d) => Math.Sqrt(d);
        public bool IsFinite(double d) => double.IsInfinity(d) == false && double.IsNaN(d) == false;
        public bool IsFinite(float d) => float.IsInfinity(d) == false && float.IsNaN(d) == false;
        public bool Approx(double a, double b) => Approx(a, b, Epsilon);
        public bool Approx(double a, double b, double epsilon)
        {
            if (double.IsPositiveInfinity(a) && double.IsPositiveInfinity(b))
                return true;
            if (double.IsNegativeInfinity(a) && double.IsNegativeInfinity(b))
                return true;
            if (double.IsNaN(a) && double.IsNaN(b))
                return true;
            if (Math.Abs(a - b) <= epsilon)
                return true;

            return false;
        }

        public bool IsBetween(float value, float low, float high) => value >= low && value <= high;
        public bool IsBetween(double value, double low, double high) => value >= low && value <= high;
        public bool IsBetween(int value, int low, int high) => value >= low && value <= high;

        public long BigMul(int a, int b) => Math.BigMul(a, b);
        public int DivRem(int a, int b, out int result) => Math.DivRem(a, b, out result);

        public double InvSqrt(double f) => f / Math.Sqrt(f);
    }
}