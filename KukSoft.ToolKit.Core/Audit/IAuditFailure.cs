using System.Collections.Generic;

namespace KukSoft.ToolKit.Audit
{
    public interface IAuditFailure
    {
        string Message { get; }
        IReadOnlyList<IAuditFailure> Failures { get; }
    }
}