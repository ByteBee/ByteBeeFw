using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace KukSoft.ToolKit.Audit
{
    class Auditor<TObject> : IAuditor<TObject>
    {
        private IList<AuditSchema<TObject>> _checkList = new List<AuditSchema<TObject>>();
        private IList<IAuditFailure> _failures = new List<IAuditFailure>();

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

        public void Audit(TObject obj) => Audit(obj, true);

        public void Audit(TObject obj, bool crashOnError)
        {
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

            var fails = other.GetFailures();
            if (fails.Any())
            {
                _failures.Add(new AuditFailure(message, fails));
            }

            return this;
        }

        public IReadOnlyList<IAuditFailure> GetFailures()
            => new List<IAuditFailure>(_failures);
    }
}