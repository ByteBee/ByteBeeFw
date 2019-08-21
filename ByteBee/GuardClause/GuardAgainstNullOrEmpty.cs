using System;

// ReSharper disable once CheckNamespace
namespace ByteBee
{
    public static partial class Guard
    {
        public static void AgainstNullOrEmpty(string input, string message)
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