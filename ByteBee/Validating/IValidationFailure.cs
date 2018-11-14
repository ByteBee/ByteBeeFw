using System.Collections.Generic;

namespace ByteBee.Validating
{
    public interface IValidationFailure
    {
        string Message { get; }
        IReadOnlyList<IValidationFailure> Failures { get; }
    }
}