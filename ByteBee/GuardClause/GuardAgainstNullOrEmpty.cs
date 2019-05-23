using System;

namespace ByteBee.GuardClause
{
    public static class GuardAgainstNullOrEmpty
    {
        public static void NullOrEmpty(this IGuardClause guard, string input, string message)
        {
            if (input == null)
            {
                throw new ArgumentNullException(message);
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException(message);
            }
        }
    }
}