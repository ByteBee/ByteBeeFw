using System;

// ReSharper disable once CheckNamespace
namespace ByteBee
{
    public static partial class Guard
    {
        public static void AgainstNull(object input, string message)
        {
            if (input == null)
            {
                throw new ArgumentNullException(string.Empty, message);
            }
        }
    }
}