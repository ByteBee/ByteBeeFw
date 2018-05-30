using System;
using System.Collections.Generic;

namespace KukSoft.ToolKit.Audit.Public
{
    public abstract class Auditor<TObject> : IAuditor<TObject>
    {
        private IAuditor<TObject> _auditor;

        public Auditor()
            => _auditor = new Audit.Auditor<TObject>();

        protected abstract void Checklist(TObject obj);

        public void Audit(TObject obj)
        {
            Checklist(obj);
            _auditor.Audit(obj);
        }

        public void Audit(TObject obj, bool crashOnError)
        {
            Checklist(obj);
            _auditor.Audit(obj, crashOnError);
        }

        public IAuditor<TObject> MustFail(Func<TObject, bool> check, string message)
            => _auditor.MustFail(check, message);

        public IAuditor<TObject> MustPass(Func<TObject, bool> check, string message)
            => _auditor.MustPass(check, message);

        public IAuditor<TObject> SubSequence<TOther>(IAuditor<TOther> other, TOther obj, string message)
            => _auditor.SubSequence(other, obj, message);

        public IReadOnlyList<IAuditFailure> GetFailures()
            => _auditor.GetFailures();

        
    }
}
