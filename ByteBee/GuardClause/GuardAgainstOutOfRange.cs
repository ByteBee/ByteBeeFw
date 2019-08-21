using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace ByteBee
{
    public static partial class Guard
    {
        private static bool ThisIsNotOkay<T>(T input, T from, T until)
        {
            Comparer<T> comparer = Comparer<T>.Default;

            if (comparer.Compare(from, until) > 0)
            {
                T tmp = from;
                from = until;
                until = tmp;
            }

            if (comparer.Compare(input, from) < 0 || comparer.Compare(input, until) > 0)
            {
                return true;
            }

            return false;
        }

        public static void AgainstOutOfRange<T>(T input, T from, T until, string message)
        {
            if (ThisIsNotOkay(input, from, until))
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }
    }
}