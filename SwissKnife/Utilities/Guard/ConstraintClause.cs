using System;
using System.Collections.Generic;
using SwissKnife.Specifications;
using SwissKnife.Validating;
using static SwissKnife.Fancy;

namespace SwissKnife.Utilities.Guard
{
    internal class ConstraintClause : IConstraintClause
    {
        public void Validator<TObj>(Validator<TObj> validator, TObj obj)
            => validator.Validate(obj);

        public void Specification<TObj>(Specification<TObj> spec, TObj obj)
        {
            if (spec.IsNotSatisfiedBy(obj))
            {
                guard.Throws<ArgumentException>(true, "The object does not fit the requirements.");
            }
        }

        public void Null(object input, string parameterName) => guard.Throws<ArgumentNullException>(input == null, parameterName);

        public void NullOrEmpty(string input, string parameterName)
        {
            Null(input, parameterName);
            guard.Throws<ArgumentException>(
                input == string.Empty,
                $"Required input {parameterName} was empty.");
        }

        public void NullOrWhiteSpace(string input, string parameterName)
        {
            NullOrEmpty(input, parameterName);
            guard.Throws<ArgumentException>(
                string.IsNullOrWhiteSpace(input),
                $"Required input {parameterName} was empty.");
        }

        public void OutOfRange(int input, string parameterName, int rangeFrom, int rangeTo)
            => OutOfRange<int>(input, parameterName, rangeFrom, rangeTo);

        public void OutOfRange(DateTime input, string parameterName, DateTime rangeFrom, DateTime rangeTo)
            => OutOfRange<DateTime>(input, parameterName, rangeFrom, rangeTo);

        public void OutOfSqlDateRange(DateTime input, string parameterName)
        {
            // System.Data is unavailable in .NET Standard so we can't use SqlDateTime.
            const long sqlMinDateTicks = 552877920000000000;
            const long sqlMaxDateTicks = 3155378975999970000;

            OutOfRange<DateTime>(input, parameterName, new DateTime(sqlMinDateTicks), new DateTime(sqlMaxDateTicks));
        }

        private void OutOfRange<T>(T input, string parameterName, T rangeFrom, T rangeTo)
        {
            Comparer<T> comparer = Comparer<T>.Default;

            guard.Throws<ArgumentException>(
                comparer.Compare(rangeFrom, rangeTo) > 0,
                $"{nameof(rangeFrom)} should be less or equal than {nameof(rangeTo)}");

            guard.Throws<ArgumentOutOfRangeException>(
                comparer.Compare(input, rangeFrom) < 0 || comparer.Compare(input, rangeTo) > 0,
                $"Input {parameterName} was out of range");
        }

    }
}
