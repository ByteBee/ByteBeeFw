using System;

namespace ByteBee.Core.Validating
{
    internal class ValidationRule<TObject>
    {
        public IValidationFailure Failure { get; }
        public Func<TObject, bool> Assert { get; }

        public ValidationRule(Func<TObject, bool> assert, IValidationFailure failure)
        {
            Assert = assert;
            Failure = failure;
        }
    }
}