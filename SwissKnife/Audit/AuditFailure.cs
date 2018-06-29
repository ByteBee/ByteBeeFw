using System.Collections.Generic;

namespace SwissKnife.Audit
{
    class AuditFailure : IAuditFailure
    {
        public string Message { get; }
        public IReadOnlyList<IAuditFailure> Failures { get; }

        private readonly AuditFailureFormater _formatter;

        public AuditFailure(string message) : this(message, new IAuditFailure[0])
        {
        }

        public AuditFailure(string message, IReadOnlyList<IAuditFailure> failures)
        {
            Message = message;
            Failures = failures;
            _formatter = new AuditFailureFormater();
        }

        public override string ToString() => _formatter.Format(this);
    }
}