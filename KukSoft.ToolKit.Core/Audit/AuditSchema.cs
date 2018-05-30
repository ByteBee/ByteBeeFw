using System;

namespace KukSoft.ToolKit.Audit
{
    class AuditSchema<TObject>
    {
        public bool IsPositive { get;  }
        public IAuditFailure Failure { get; }
        public Func<TObject, bool> Assert { get; }

        public AuditSchema(Func<TObject, bool> assert, IAuditFailure failure, bool isPositive)
        {
            Assert = assert;
            Failure = failure;
            IsPositive = isPositive;
        }
    }
}