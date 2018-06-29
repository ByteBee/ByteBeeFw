using System;

namespace SwissKnife.Validating
{
    internal class ValidationRule<TObject>
    {
        public bool IsPositive { get;  }
        public IValidationFailure Failure { get; }
        public Func<TObject, bool> Assert { get; }

        public ValidationRule(Func<TObject, bool> assert, IValidationFailure failure, bool isPositive)
        {
            Assert = assert;
            Failure = failure;
            IsPositive = isPositive;
        }
    }
}