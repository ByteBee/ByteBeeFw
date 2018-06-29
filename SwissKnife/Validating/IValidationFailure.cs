using System.Collections.Generic;

namespace SwissKnife.Validating
{
    public interface IValidationFailure
    {
        string Message { get; }
        IReadOnlyList<IValidationFailure> Failures { get; }
    }
}