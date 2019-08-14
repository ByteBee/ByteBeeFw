using System.Collections.Generic;

namespace ByteBee.Core.Validating
{
    public interface IValidationFailure
    {
        string Message { get; }
        IReadOnlyList<IValidationFailure> Failures { get; }
    }
}