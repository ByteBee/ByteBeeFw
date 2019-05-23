using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ByteBee.GuardClause
{
    public static class GuardAgainstZero
    {
        public static void Zero(this IGuardClause clause, int input, string message)
        {
            Zero<int>(clause, input, message);
        }

        public static void Zero(this IGuardClause clause, short input, string message)
        {
            Zero<short>(clause, input, message);
        }

        public static void Zero(this IGuardClause clause, long input, string message)
        {
            Zero<long>(clause, input, message);
        }

        public static void Zero(this IGuardClause clause, decimal input, string message)
        {
            Zero<decimal>(clause, input, message);
        }

        public static void Zero(this IGuardClause clause, float input, string message)
        {
            Zero<float>(clause, input, message);
        }

        public static void Zero(this IGuardClause clause, double input, string message)
        {
            Zero<double>(clause, input, message);
        }

        public static void Zero<T>(this IGuardClause clause, T input, string message)
        {
            if (EqualityComparer<T>.Default.Equals(input, default(T)))
            {
                throw new ArgumentException(message);
            }
        }
    }
}