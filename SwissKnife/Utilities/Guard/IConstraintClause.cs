using System;
using SwissKnife.Specifications;
using SwissKnife.Validating;

namespace SwissKnife.Utilities.Guard
{
    public interface IConstraintClause
    {
        /// <exception cref="ObjectNotValidException"></exception>
        void Validator<TObj>(StandardValidator<TObj> auditor, TObj obj);

        /// <exception cref="ArgumentException"></exception>
        void Specification<TObj>(Specification<TObj> spec, TObj obj);

        /// <exception cref="ArgumentNullException"></exception>
        void Null(object input, string parameterName);

        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        void NullOrEmpty(string input, string parameterName);

        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        void NullOrWhiteSpace(string input, string parameterName);

        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        void OutOfRange(int input, string parameterName, int rangeFrom, int rangeTo);

        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        void OutOfRange(DateTime input, string parameterName, DateTime rangeFrom, DateTime rangeTo);

        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        void OutOfSqlDateRange(DateTime input, string parameterName);
    }
}
