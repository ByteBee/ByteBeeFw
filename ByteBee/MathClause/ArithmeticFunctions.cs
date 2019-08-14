namespace ByteBee.Core.MathClause
{
    public static class ArithmeticFunctions
    {
        public static decimal Truncate(this IMathClause math, decimal d)
        {
            return System.Math.Truncate(d);
        }

        public static double Truncate(this IMathClause math, double d)
        {
            return System.Math.Truncate(d);
        }

        public static double Remainder(this IMathClause math, double x, double y)
        {
            return System.Math.IEEERemainder(x, y);
        }

        public static long DivRem(this IMathClause math, long a, long b, out long result)
        {
            return System.Math.DivRem(a, b, out result);
        }

        public static double Sqrt(this IMathClause math, double d)
        {
            return System.Math.Sqrt(d);
        }

        public static bool IsFinite(this IMathClause math, double d)
        {
            return double.IsInfinity(d) == false && double.IsNaN(d) == false;
        }

        public static bool IsFinite(this IMathClause math, float d)
        {
            return float.IsInfinity(d) == false && float.IsNaN(d) == false;
        }

        public static bool Approx(this IMathClause math, double a, double b)
        {
            return math.Approx(a, b, math.Epsilon);
        }

        public static bool Approx(this IMathClause math, double a, double b, double epsilon)
        {
            if (double.IsPositiveInfinity(a) && double.IsPositiveInfinity(b))
                return true;
            if (double.IsNegativeInfinity(a) && double.IsNegativeInfinity(b))
                return true;
            if (double.IsNaN(a) && double.IsNaN(b))
                return true;
            if (System.Math.Abs(a - b) <= epsilon)
                return true;

            return false;
        }

        public static bool IsBetween(this IMathClause math, float value, float low, float high)
        {
            return value >= low && value <= high;
        }

        public static bool IsBetween(this IMathClause math, double value, double low, double high)
        {
            return value >= low && value <= high;
        }

        public static bool IsBetween(this IMathClause math, int value, int low, int high)
        {
            return value >= low && value <= high;
        }

        public static long BigMul(this IMathClause math, int a, int b)
        {
            return System.Math.BigMul(a, b);
        }

        public static int DivRem(this IMathClause math, int a, int b, out int result)
        {
            return System.Math.DivRem(a, b, out result);
        }

        public static double InvSqrt(this IMathClause math, double f)
        {
            return f / System.Math.Sqrt(f);
        }
    }
}