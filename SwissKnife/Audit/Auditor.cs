using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissKnife.Audit
{
    public abstract class Auditor<TObject> : IAuditor<TObject>
    {
        private readonly IList<AuditSchema<TObject>> _checkList = new List<AuditSchema<TObject>>();
        private readonly IList<IAuditFailure> _failures = new List<IAuditFailure>();

        public IAuditor<TObject> MustPass(Func<TObject, bool> check, string message)
        {
            _checkList.Add(new AuditSchema<TObject>(check, new AuditFailure(message), true));
            return this;
        }

        public IAuditor<TObject> MustFail(Func<TObject, bool> check, string message)
        {
            _checkList.Add(new AuditSchema<TObject>(check, new AuditFailure(message), false));
            return this;
        }

        protected abstract void Checklist(TObject obj);

        public void Audit(TObject obj) => Audit(obj, true);

        public void Audit(TObject obj, bool crashOnError)
        {
            Checklist(obj);

            foreach (AuditSchema<TObject> schema in _checkList)
            {
                if (schema.IsPositive && !schema.Assert(obj))
                {
                    _failures.Add(schema.Failure);
                }
                else if (!schema.IsPositive && schema.Assert(obj))
                {
                    _failures.Add(schema.Failure);
                }
            }

            if (crashOnError && _failures.Any())
            {
                string msg = _failures.Aggregate(string.Empty, (c, f) => c + f).TrimEnd();
                throw new AuditException(msg);
            }
        }

        public IAuditor<TObject> SubSequence<TOther>(IAuditor<TOther> other, TOther obj, string message)
        {
            other.Audit(obj, false);

            IReadOnlyList<IAuditFailure> fails = other.GetFailures();
            if (fails.Any())
            {
                var failure = new AuditFailure(message, fails);

                _checkList.Add(new AuditSchema<TObject>(o => true, failure, false));
            }

            return this;
        }

        public IReadOnlyList<IAuditFailure> GetFailures()
            => new List<IAuditFailure>(_failures);
    }
}