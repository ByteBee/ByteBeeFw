using System.Collections.Generic;

namespace SwissKnife.Audit
{
    public interface IAuditFailure
    {
        string Message { get; }
        IReadOnlyList<IAuditFailure> Failures { get; }
    }
}