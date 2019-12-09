using System;
using System.Collections.Generic;

namespace ByteBee.Numerics
{
    public static class MathRange
    {
        public static T Min<T>(T a, T b) where T : IComparable
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

        public static T Min<T>(T a, T b, T c) where T : IComparable
        {
            Comparer<T> comparer = Comparer<T>.Default;

            if (comparer.Compare(a, b) < 0)
            {
                return Min(a, c);
            }
            else
            {
                return Min(b, c);
            }
        }

        public static T Max<T>(T a, T b) where T : IComparable
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

        public static T Max<T>(T a, T b, T c) where T : IComparable
        {
            Comparer<T> comparer = Comparer<T>.Default;

            if (comparer.Compare(a, b) > 0)
            {
                return Max(a, c);
            }
            else
            {
                return Max(b, c);
            }
        }
        
        public static T Clamp<T>(T value, T min, T max) where T : IComparable
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
    }
}