using System;

namespace ByteBee.GuardClause
{
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