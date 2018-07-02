using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissKnife.Validating
{
    public abstract class StandardValidator<TObject> : IValidator<TObject>
    {
        private readonly IList<ValidationRule<TObject>> _checkList = new List<ValidationRule<TObject>>();
        private readonly IList<IValidationFailure> _failures = new List<IValidationFailure>();

        /// <inheritdoc />
        public IValidator<TObject> MustPass(Func<TObject, bool> check, string message)
        {
            _checkList.Add(new ValidationRule<TObject>(check, new ValidationFailure(message), true));
            return this;
        }
        /// <inheritdoc />
        public IValidator<TObject> MustFail(Func<TObject, bool> check, string message)
        {
            _checkList.Add(new ValidationRule<TObject>(check, new ValidationFailure(message), false));
            return this;
        }

        protected abstract void Checklist(TObject obj);

        /// <inheritdoc />
        public void Validate(TObject obj) => Validate(obj, true);

        /// <inheritdoc />
        public void Validate(TObject obj, bool crashOnError)
        {
            Checklist(obj);

            foreach (ValidationRule<TObject> schema in _checkList)
            {
                if (schema.IsPositive && !schema.Assert(obj))
                {
                    _failures.Add(schema.Failure);
                }
                else if (!schema.IsPositive && schema.Assert(obj))
                {
                    _failures.Add(schema.Failure);
                }
            }

            if (crashOnError && _failures.Any())
            {
                string msg = _failures.Aggregate(string.Empty, (c, f) => c + f).TrimEnd();
                throw new ObjectNotValidException(msg);
            }
        }

        /// <inheritdoc />
        public IValidator<TObject> SubSequence<TOther>(IValidator<TOther> other, TOther obj, string message)
        {
            other.Validate(obj, false);

            IReadOnlyList<IValidationFailure> fails = other.GetFailures();
            if (fails.Any())
            {
                var failure = new ValidationFailure(message, fails);

                _checkList.Add(new ValidationRule<TObject>(o => true, failure, false));
            }

            return this;
        }

        public IReadOnlyList<IValidationFailure> GetFailures()
            => new List<IValidationFailure>(_failures);
    }
}