using System;
using System.Collections.Generic;
using static SwissKnife.Fancy;

namespace SwissKnife.Validating
{
    public abstract class AbstrValidator<TObject> : IValidator<TObject>
    {
        internal readonly IList<ValidationRule<TObject>> Rules = new List<ValidationRule<TObject>>();
        internal readonly IList<IValidationFailure> Failures = new List<IValidationFailure>();

        protected abstract void DefineRules(TObject obj);

        /// <inheritdoc />
        public IValidator<TObject> ShouldBeTrue(Func<TObject, bool> check, string message)
        {
            Rules.Add(new ValidationRule<TObject>(check, new ValidationFailure(message), true));
            return this;
        }

        /// <inheritdoc />
        public IValidator<TObject> ShouldBeFalse(Func<TObject, bool> check, string message)
        {
            Rules.Add(new ValidationRule<TObject>(check, new ValidationFailure(message), false));
            return this;
        }



        /// <inheritdoc />
        public ValidationResult Validate(TObject obj)
        {
            //Rules.Clear();
            Failures.Clear();

            DefineRules(obj);

            foreach (ValidationRule<TObject> rule in Rules)
            {
                if (rule.IsPositive && !rule.Assert(obj))
                {
                    Failures.Add(rule.Failure);
                }
                else if (!rule.IsPositive && rule.Assert(obj))
                {
                    Failures.Add(rule.Failure);
                }
            }

            return new ValidationResult(Failures);
        }

        /// <inheritdoc />
        public void ValidateAndThrow(TObject obj)
        {
            ValidationResult result = Validate(obj);

            if (!result.IsValid)
            {
                guard.Throws<ObjectNotValidException>(result.ToString());
            }
        }

        /// <inheritdoc />
        public IValidator<TObject> Rule(Func<TObject, bool> check, string message) => ShouldBeTrue(check, message);

        /// <inheritdoc />
        public IValidator<TObject> RuleSet<TOther>(AbstrValidator<TOther> other, TOther obj, string message)
        {
            ValidationResult result = other.Validate(obj);
            if (!result.IsValid)
            {
                var failure = new ValidationFailure(message, result.Errors);
                Rules.Add(new ValidationRule<TObject>(o => true, failure, false));
            }

            return this;
        }

        /// <inheritdoc />
        public IValidator<TObject> Include(AbstrValidator<TObject> other)
        {
            foreach (ValidationRule<TObject> rule in other.Rules)
            {
                Rules.Add(rule);
            }

            return this;
        }
    }
}