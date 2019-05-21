using System;
using System.Collections.Generic;

namespace ByteBee.GuardClause
{
    public static class GuardAgainstDefault
    {
        private static bool ThisIsNotOk<T>(T input)
        {
            if (default(T) == null)
            {
                return true;
            }

            if (EqualityComparer<T>.Default.Equals(input, default(T)))
            {
                return true;
            }

            return false;
        }

        public static void Default<T>(this IGuardAgainstClause clause, T input, string message)
        {
            if (ThisIsNotOk(input))
            {
                throw new ArgumentException(message);
            }
        }
    }

    public static class GuardAgainstWrongType
    {
        public static void WrongType<T>(this IGuardAgainstClause clause, object input, string message)
        {
            if (!(input is T))
            {
                throw new InvalidCastException(message);
            }
        }
    }
}