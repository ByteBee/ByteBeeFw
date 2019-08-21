using System;
using ByteBee.Numerics;

namespace ByteBee.MathClause
{
    //public static class ArithmeticFunctions
    //{
    //    public static decimal Truncate(decimal d)
    //    {
    //        return System.Math.Truncate(d);
    //    }

    //    public static double Truncate(double d)
    //    {
    //        return System.Math.Truncate(d);
    //    }

    //    public static double Remainder(double x, double y)
    //    {
    //        return System.Math.IEEERemainder(x, y);
    //    }

    //    public static long DivRem(long a, long b, out long result)
    //    {
    //        return System.Math.DivRem(a, b, out result);
    //    }

    //    public static double Sqrt(double d)
    //    {
    //        return System.Math.Sqrt(d);
    //    }

    //    public static bool IsFinite(double d)
    //    {
    //        return double.IsInfinity(d) == false && double.IsNaN(d) == false;
    //    }

    //    public static bool IsFinite(float d)
    //    {
    //        return float.IsInfinity(d) == false && float.IsNaN(d) == false;
    //    }

    //    public static bool Approx(double a, double b)
    //    {
    //        return Math.Approx(a, b, MathConstant.Epsilon);
    //    }

    //    public static bool Approx(double a, double b, double epsilon)
    //    {
    //        if (double.IsPositiveInfinity(a) && double.IsPositiveInfinity(b))
    //            return true;
    //        if (double.IsNegativeInfinity(a) && double.IsNegativeInfinity(b))
    //            return true;
    //        if (double.IsNaN(a) && double.IsNaN(b))
    //            return true;
    //        if (System.Math.Abs(a - b) <= epsilon)
    //            return true;

    //        return false;
    //    }

    //    public static bool IsBetween(float value, float low, float high)
    //    {
    //        return value >= low && value <= high;
    //    }

    //    public static bool IsBetween(double value, double low, double high)
    //    {
    //        return value >= low && value <= high;
    //    }

    //    public static bool IsBetween(int value, int low, int high)
    //    {
    //        return value >= low && value <= high;
    //    }

    //    public static long BigMul(int a, int b)
    //    {
    //        return System.Math.BigMul(a, b);
    //    }

    //    public static int DivRem(int a, int b, out int result)
    //    {
    //        return System.Math.DivRem(a, b, out result);
    //    }

    //    public static double InvSqrt(double f)
    //    {
    //        return f / System.Math.Sqrt(f);
    //    }
    //}
}