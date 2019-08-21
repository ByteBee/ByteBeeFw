using System;
using System.Collections.Generic;
using ByteBee.Numerics;

namespace ByteBee.MathClause
{
    //public static class FuncMathClamp
    //{
    //    public static T Min<T>(T a, T b) where T : IComparable
    //    {
    //        Comparer<T> comparer = Comparer<T>.Default;

    //        if (comparer.Compare(a, b) < 0)
    //        {
    //            return a;
    //        }
    //        else
    //        {
    //            return b;
    //        }
    //    }

    //    public static T Min<T>(T a, T b, T c) where T : IComparable
    //    {
    //        Comparer<T> comparer = Comparer<T>.Default;

    //        if (comparer.Compare(a, b) < 0)
    //        {
    //            return Math.Min(a, c);
    //        }
    //        else
    //        {
    //            return Math.Min(b, c);
    //        }
    //    }

    //    public static T Max<T>(T a, T b) where T : IComparable
    //    {
    //        Comparer<T> comparer = Comparer<T>.Default;

    //        if (comparer.Compare(a, b) > 0)
    //        {
    //            return a;
    //        }
    //        else
    //        {
    //            return b;
    //        }
    //    }

    //    public static T Max<T>(T a, T b, T c) where T : IComparable
    //    {
    //        Comparer<T> comparer = Comparer<T>.Default;

    //        if (comparer.Compare(a, b) > 0)
    //        {
    //            return Math.Max(a, c);
    //        }
    //        else
    //        {
    //            return Math.Max(b, c);
    //        }
    //    }


    //    public static T Clamp<T>(T value, T min, T max) where T : IComparable
    //    {
    //        Comparer<T> comparer = Comparer<T>.Default;

    //        if (comparer.Compare(value, min) < 0)
    //        {
    //            return min;
    //        }
    //        else if (comparer.Compare(value, max) > 0)
    //        {
    //            return max;
    //        }
    //        else
    //        {
    //            return value;
    //        }
    //    }

    //    public static double ClampAngleDeg(double theta, double min, double max)
    //    {
    //        // convert interval to center/extent - [c-e,c+e]
    //        double c = (min + max) * 0.5;
    //        double e = max - c;

    //        // get rid of extra rotations
    //        theta = theta % 360;

    //        // shift to origin, then convert theta to +- 180
    //        theta -= c;
    //        if (theta < -180)
    //            theta += 360;
    //        else if (theta > 180)
    //            theta -= 360;

    //        // clamp to extent
    //        if (theta < -e)
    //            theta = -e;
    //        else if (theta > e)
    //            theta = e;

    //        // shift back
    //        return theta + c;
    //    }

    //    public static double ClampAngleRad(double theta, double min, double max)
    //    {
    //        // convert interval to center/extent - [c-e,c+e]
    //        double c = (min + max) * 0.5;
    //        double e = max - c;

    //        // get rid of extra rotations
    //        theta = theta % MathConstant.Pi2;

    //        // shift to origin, then convert theta to +- 180
    //        theta -= c;
    //        if (theta < -MathConstant.Pi)
    //            theta += MathConstant.Pi2;
    //        else if (theta > MathConstant.Pi)
    //            theta -= MathConstant.Pi2;

    //        // clamp to extent
    //        if (theta < -e)
    //            theta = -e;
    //        else if (theta > e)
    //            theta = e;

    //        // shift back
    //        return theta + c;
    //    }
    //}
}