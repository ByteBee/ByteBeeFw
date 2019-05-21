using System;
using System.Collections.Generic;

namespace ByteBee.GuardClause
{
    public static class GuardAgainstOutOfRange
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

        public static void OutOfRange<T>(this IGuardAgainstClause clause, T input, T from, T until, string message)
        {
            if (ThisIsNotOkay(input, from, until))
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }
    }
}