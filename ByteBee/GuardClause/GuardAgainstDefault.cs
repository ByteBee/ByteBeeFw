using System;
using System.Collections.Generic;

namespace ByteBee.Core.GuardClause
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

        public static void Default<T>(this IGuardClause clause, T input, string message)
        {
            if (ThisIsNotOk(input))
            {
                throw new ArgumentException(message);
            }
        }
    }
}