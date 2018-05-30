using System;
using System.Runtime.Serialization;

namespace KukSoft.ToolKit.Audit
{
    [Serializable]
    public class AuditException : Exception
    {
        public AuditException() { }
        public AuditException(string message) : base(message) { }
        public AuditException(string message, Exception inner) : base(message, inner) { }
        protected AuditException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}