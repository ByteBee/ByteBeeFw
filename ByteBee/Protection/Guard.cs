using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using ByteBee.Protection;

// ReSharper disable once CheckNamespace
namespace ByteBee
{
    public static class Guard
    {
        public static GuardArgument<T> Ensure<T>(T argument, string name = null)
        {
            return new GuardArgument<T>(argument, name);
        }
        
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

        private static void AgainstDefault<T>(T input, string message)
        {
            if (ThisIsNotOk(input))
            {
                throw new ArgumentException(message);
            }
        }

        private static void AgainstNull(object input, string message)
        {
            if (input == null)
            {
                throw new ArgumentNullException(string.Empty, message);
            }
        }

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

        private static bool ThisIsNotOkay<T>(T input, T from, T until)
        {
            Comparer<T> comparer = Comparer<T>.Default;

            if (comparer.Compare(from, until) > 0)
            {
                T tmp = from;
                from = until;
                until = tmp;
            }

            if (comparer.Compare(input, from) < 0 || comparer.Compare(input, until) > 0)
            {
                return true;
            }

            return false;
        }

        private static void AgainstOutOfRange<T>(T input, T from, T until, string message)
        {
            if (ThisIsNotOkay(input, from, until))
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }

        private static void AgainstWrongType<T>(object input, string message)
        {
            if (!(input is T))
            {
                throw new InvalidCastException(message);
            }
        }

        private static void AgainstZero(int input, string message)
        {
            AgainstZero<int>(input, message);
        }

        private static void AgainstZero(short input, string message)
        {
            AgainstZero<short>(input, message);
        }

        private static void AgainstZero(long input, string message)
        {
            AgainstZero<long>(input, message);
        }

        private static void AgainstZero(decimal input, string message)
        {
            AgainstZero<decimal>(input, message);
        }

        private static void AgainstZero(float input, string message)
        {
            AgainstZero<float>(input, message);
        }

        private static void AgainstZero(double input, string message)
        {
            AgainstZero<double>(input, message);
        }

        private static void AgainstZero<T>(T input, string message)
        {
            if (EqualityComparer<T>.Default.Equals(input, default(T)))
            {
                throw new ArgumentException(message);
            }
        }
    }
}
