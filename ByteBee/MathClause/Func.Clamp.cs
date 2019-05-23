using System;
using System.Collections.Generic;

namespace ByteBee.MathClause
{
    public static class FuncMathClamp
    {
        public static T Min<T>(this IMathClause max, T a, T b) where T : IComparable
        {
            Comparer<T> comparer = Comparer<T>.Default;

            if (comparer.Compare(a, b) < 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public static T Min<T>(this IMathClause math, T a, T b, T c) where T : IComparable
        {
            Comparer<T> comparer = Comparer<T>.Default;

            if (comparer.Compare(a, b) < 0)
            {
                return math.Min(a, c);
            }
            else
            {
                return math.Min(b, c);
            }
        }

        public static T Max<T>(this IMathClause max, T a, T b) where T : IComparable
        {
            Comparer<T> comparer = Comparer<T>.Default;

            if (comparer.Compare(a, b) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public static T Max<T>(this IMathClause math, T a, T b, T c) where T : IComparable
        {
            Comparer<T> comparer = Comparer<T>.Default;

            if (comparer.Compare(a, b) > 0)
            {
                return math.Max(a, c);
            }
            else
            {
                return math.Max(b, c);
            }
        }


        public static T Clamp<T>(this IMathClause math, T value, T min, T max) where T : IComparable
        {
            Comparer<T> comparer = Comparer<T>.Default;

            if (comparer.Compare(value, min) < 0)
            {
                return min;
            }
            else if (comparer.Compare(value, max) > 0)
            {
                return max;
            }
            else
            {
                return value;
            }
        }

        public static double ClampAngleDeg(this IMathClause math, double theta, double min, double max)
        {
            // convert interval to center/extent - [c-e,c+e]
            double c = (min + max) * 0.5;
            double e = max - c;

            // get rid of extra rotations
            theta = theta % 360;

            // shift to origin, then convert theta to +- 180
            theta -= c;
            if (theta < -180)
                theta += 360;
            else if (theta > 180)
                theta -= 360;

            // clamp to extent
            if (theta < -e)
                theta = -e;
            else if (theta > e)
                theta = e;

            // shift back
            return theta + c;
        }

        public static double ClampAngleRad(this IMathClause math, double theta, double min, double max)
        {
            // convert interval to center/extent - [c-e,c+e]
            double c = (min + max) * 0.5;
            double e = max - c;

            // get rid of extra rotations
            theta = theta % math.Pi2;

            // shift to origin, then convert theta to +- 180
            theta -= c;
            if (theta < -math.Pi)
                theta += math.Pi2;
            else if (theta > math.Pi)
                theta -= math.Pi2;

            // clamp to extent
            if (theta < -e)
                theta = -e;
            else if (theta > e)
                theta = e;

            // shift back
            return theta + c;
        }
    }
}