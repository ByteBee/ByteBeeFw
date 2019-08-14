using System;

namespace ByteBee.Core.GuardClause
{
    public static class GuardAgainstNull
    {
        public static void Null(this IGuardClause clause, object input, string message)
        {
            if (input == null)
            {
                throw new ArgumentNullException(string.Empty, message);
            }
        }
    }
}