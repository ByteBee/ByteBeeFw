using System;

namespace ByteBee.GuardClause
{
    public static class GuardAgainstNullOrEmpty
    {
        public static void NullOrEmpty(this IGuardAgainstClause guard, string input, string message)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException(message);
            }
        }
    }
}