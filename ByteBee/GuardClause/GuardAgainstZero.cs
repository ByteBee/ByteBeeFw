using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace ByteBee
{
    public static partial class Guard
    {
        public static void AgainstZero(int input, string message)
        {
            AgainstZero<int>(input, message);
        }

        public static void AgainstZero(short input, string message)
        {
            AgainstZero<short>(input, message);
        }

        public static void AgainstZero(long input, string message)
        {
            AgainstZero<long>(input, message);
        }

        public static void AgainstZero(decimal input, string message)
        {
            AgainstZero<decimal>(input, message);
        }

        public static void AgainstZero(float input, string message)
        {
            AgainstZero<float>(input, message);
        }

        public static void AgainstZero(double input, string message)
        {
            AgainstZero<double>(input, message);
        }

        public static void AgainstZero<T>(T input, string message)
        {
            if (EqualityComparer<T>.Default.Equals(input, default(T)))
            {
                throw new ArgumentException(message);
            }
        }
    }
}