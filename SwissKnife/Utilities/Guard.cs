// https://github.com/ardalis/guards
using System;
using System.Collections.Generic;
using SwissKnife.Specifications;
using SwissKnife.Validating;

namespace SwissKnife.Utilities
{
    public interface IGuard
    {
        /// <exception cref="ObjectNotValidException"></exception>
        void AgainstAnAudit<TObj>(StandardValidator<TObj> auditor, TObj obj);

        /// <exception cref="ArgumentException"></exception>
        void AgainstAnSpecification<TObj>(Specification<TObj> spec, TObj obj);

        /// <exception cref="ArgumentNullException"></exception>
        void AgainstNull(object input, string parameterName);

        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        void AgainstNullOrEmpty(string input, string parameterName);

        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        void AgainstNullOrWhiteSpace(string input, string parameterName);

        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        void AgainstOutOfRange(int input, string parameterName, int rangeFrom, int rangeTo);

        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        void AgainstOutOfRange(DateTime input, string parameterName, DateTime rangeFrom, DateTime rangeTo);

        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        void AgainstOutOfSqlDateRange(DateTime input, string parameterName);

        /// <exception cref="TException"></exception>
        void Throws<TException>(Func<bool> condition, string message) where TException : Exception;

        /// <exception cref="TException"></exception>
        void Throws<TException>(bool condition, string message) where TException : Exception;

        /// <exception cref="TException"></exception>
        void Throws<TException>(string message) where TException : Exception;
    }

    internal class GuardImpl : IGuard
    {
        public void AgainstAnAudit<TObj>(StandardValidator<TObj> auditor, TObj obj)
            => auditor.Validate(obj);

        public void AgainstAnSpecification<TObj>(Specification<TObj> spec, TObj obj)
        {
            if (spec.IsNotSatisfiedBy(obj))
            {
                Throws<ArgumentException>(true, "The object does not fit the requirements.");
            }
        }

        public void AgainstNull(object input, string parameterName)
            => Throws<ArgumentNullException>(input == null, parameterName);

        public void AgainstNullOrEmpty(string input, string parameterName)
        {
            AgainstNull(input, parameterName);
            Throws<ArgumentException>(
                () => input == string.Empty,
                $"Required input {parameterName} was empty.");
        }

        public void AgainstNullOrWhiteSpace(string input, string parameterName)
        {
            AgainstNullOrEmpty(input, parameterName);
            Throws<ArgumentException>(
                () => string.IsNullOrWhiteSpace(input),
                $"Required input {parameterName} was empty.");
        }

        public void AgainstOutOfRange(int input, string parameterName, int rangeFrom, int rangeTo)
            => AgainstOutOfRange<int>(input, parameterName, rangeFrom, rangeTo);

        public void AgainstOutOfRange(DateTime input, string parameterName, DateTime rangeFrom, DateTime rangeTo)
            => AgainstOutOfRange<DateTime>(input, parameterName, rangeFrom, rangeTo);

        public void AgainstOutOfSqlDateRange(DateTime input, string parameterName)
        {
            // System.Data is unavailable in .NET Standard so we can't use SqlDateTime.
            const long sqlMinDateTicks = 552877920000000000;
            const long sqlMaxDateTicks = 3155378975999970000;

            AgainstOutOfRange<DateTime>(input, parameterName, new DateTime(sqlMinDateTicks), new DateTime(sqlMaxDateTicks));
        }

        private void AgainstOutOfRange<T>(T input, string parameterName, T rangeFrom, T rangeTo)
        {
            Comparer<T> comparer = Comparer<T>.Default;

            Throws<ArgumentException>(
                () => comparer.Compare(rangeFrom, rangeTo) > 0,
                $"{nameof(rangeFrom)} should be less or equal than {nameof(rangeTo)}");

            Throws<ArgumentOutOfRangeException>(
                () => comparer.Compare(input, rangeFrom) < 0 || comparer.Compare(input, rangeTo) > 0,
                $"Input {parameterName} was out of range");
        }

        public void Throws<TException>(Func<bool> condition, string message) where TException : Exception
            => Throws<TException>(condition(), message);

        public void Throws<TException>(bool condition, string message) where TException : Exception
        {
            if (condition)
            {
                Throws<TException>(message);
            }
        }
        public void Throws<TException>(string message) where TException : Exception
        {
            throw (TException)Activator.CreateInstance(typeof(TException), message);
        }
    }
}
