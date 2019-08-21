using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace ByteBee
{
    public static partial class Guard
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

        public static void AgainstDefault<T>(T input, string message)
        {
            if (ThisIsNotOk(input))
            {
                throw new ArgumentException(message);
            }
        }
    }
}