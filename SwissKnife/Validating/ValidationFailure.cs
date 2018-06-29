using System.Collections.Generic;

namespace SwissKnife.Validating
{
    internal class ValidationFailure : IValidationFailure
    {
        public string Message { get; }
        public IReadOnlyList<IValidationFailure> Failures { get; }

        private readonly ValidationFailureFormater _formatter;

        public ValidationFailure(string message) : this(message, new IValidationFailure[0])
        {
        }

        public ValidationFailure(string message, IReadOnlyList<IValidationFailure> failures)
        {
            Message = message;
            Failures = failures;
            _formatter = new ValidationFailureFormater();
        }

        public override string ToString() => _formatter.Format(this);
    }
}