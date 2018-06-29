using System;
using System.Collections.Generic;

namespace SwissKnife.Audit
{
    public interface IAuditor<TObject>
    {
        void Audit(TObject obj);
        void Audit(TObject obj, bool crashOnError);
        IAuditor<TObject> MustPass(Func<TObject, bool> check, string message);
        IAuditor<TObject> MustFail(Func<TObject, bool> check, string message);

        IAuditor<TObject> SubSequence<TOther>(IAuditor<TOther> other, TOther obj, string message);
        IReadOnlyList<IAuditFailure> GetFailures();
    }
}