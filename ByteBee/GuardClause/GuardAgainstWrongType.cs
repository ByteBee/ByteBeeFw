using System;

// ReSharper disable once CheckNamespace
namespace ByteBee
{
    public static partial class Guard
    {
        public static void AgainstWrongType<T>(object input, string message)
        {
            if (!(input is T))
            {
                throw new InvalidCastException(message);
            }
        }
    }
}