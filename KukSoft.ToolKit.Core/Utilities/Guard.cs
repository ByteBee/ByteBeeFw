// https://github.com/ardalis/guards
using System;
using System.Collections.Generic;

namespace KukSoft.ToolKit.Utilities
{
    public interface IGuard
    {
    }

    class Guard : IGuard
    {
    }

    public static class GuardExtensions
    {
        /// <exception cref="ArgumentNullException">Throws if <see cref="input" /> is null.</exception>
        public static void AgainstNull(this IGuard guard, object input, string parameterName)
            => Throws<ArgumentNullException>(guard, input == null, parameterName);

        /// <exception cref="ArgumentNullException">Throws if <see cref="input" /> is null.</exception>
        /// <exception cref="ArgumentException">Throws if <see cref="input" /> is an empty string.</exception>
        public static void AgainstNullOrEmpty(this IGuard guard, string input, string parameterName)
        {
            AgainstNull(guard, input, parameterName);
            Throws<ArgumentException>(guard,
                () => input == string.Empty,
                $"Required input {parameterName} was empty.");
        }

        /// <exception cref="ArgumentNullException">Throws if <see cref="input" /> is null.</exception>
        /// <exception cref="ArgumentException">Throws if <see cref="input" /> is an empty or white space string.</exception>
        public static void AgainstNullOrWhiteSpace(this IGuard guard, string input, string parameterName)
        {
            AgainstNullOrEmpty(guard, input, parameterName);
            Throws<ArgumentException>(guard,
                () => string.IsNullOrWhiteSpace(input),
                $"Required input {parameterName} was empty.");
        }

        /// <exception cref="ArgumentException">Throws if <see cref="rangeFrom" /> is less than <see cref="rangeTo" />.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Throws if <see cref="input" /> is less than <see cref="rangeFrom" /> or greater than <see cref="rangeTo" />.</exception>
        public static void AgainstOutOfRange(this IGuard guard, int input, string parameterName, int rangeFrom, int rangeTo)
            => AgainstOutOfRange<int>(guard, input, parameterName, rangeFrom, rangeTo);

        /// <exception cref="ArgumentException">Throws if <see cref="rangeFrom" /> is less than <see cref="rangeTo" />.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Throws if <see cref="input" /> is less than <see cref="rangeFrom" /> or greater than <see cref="rangeTo" />.</exception>
        public static void AgainstOutOfRange(this IGuard guard, DateTime input, string parameterName, DateTime rangeFrom, DateTime rangeTo)
            => AgainstOutOfRange<DateTime>(guard, input, parameterName, rangeFrom, rangeTo);

        /// <exception cref="ArgumentException">Throws if <see cref="rangeFrom" /> is less than <see cref="rangeTo" />.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Throws if <see cref="input" /> is less than <see cref="rangeFrom" /> or greater than <see cref="rangeTo" />.</exception>
        public static void AgainstOutOfSqlDateRange(this IGuard guard, DateTime input, string parameterName)
        {
            // System.Data is unavailable in .NET Standard so we can't use SqlDateTime.
            const long sqlMinDateTicks = 552877920000000000;
            const long sqlMaxDateTicks = 3155378975999970000;

            AgainstOutOfRange<DateTime>(guard, input, parameterName, new DateTime(sqlMinDateTicks), new DateTime(sqlMaxDateTicks));
        }

        private static void AgainstOutOfRange<T>(this IGuard guard, T input, string parameterName, T rangeFrom, T rangeTo)
        {
            Comparer<T> comparer = Comparer<T>.Default;

            Throws<ArgumentException>(guard,
                () => comparer.Compare(rangeFrom, rangeTo) > 0,
                $"{nameof(rangeFrom)} should be less or equal than {nameof(rangeTo)}");

            Throws<ArgumentOutOfRangeException>(guard,
                () => comparer.Compare(input, rangeFrom) < 0 || comparer.Compare(input, rangeTo) > 0,
                $"Input {parameterName} was out of range");
        }

        /// <exception cref="TException"></exception>
        public static void Throws<TException>(this IGuard guard, Func<bool> condition, string message) where TException : Exception
            => Throws<TException>(guard, condition(), message);

        /// <exception cref="TException"></exception>
        public static void Throws<TException>(this IGuard guard, bool condition, string message) where TException : Exception
        {
            if (condition)
            {
                throw (TException)Activator.CreateInstance(typeof(TException), message);
            }
        }
    }
}
