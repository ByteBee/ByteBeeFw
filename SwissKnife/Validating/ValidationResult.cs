using System.Collections.Generic;
using System.Linq;

namespace SwissKnife.Validating
{
    public sealed class ValidationResult
    {
        public IReadOnlyList<IValidationFailure> Errors { get; set; }
        public bool IsValid => Errors.Count == 0;

        internal ValidationResult(IEnumerable<IValidationFailure> errors)
        {
            Errors = new List<IValidationFailure>(errors);
        }

        public override string ToString() => Errors.Aggregate(string.Empty, (c, f) => c + f).TrimEnd();
    }
}