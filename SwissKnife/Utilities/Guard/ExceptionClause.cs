using System;

namespace SwissKnife.Utilities.Guard
{
    class ExceptionClause : IExceptionClause
    {
        public void ArgumentException(string message) => throw new ArgumentException(message);
        public void NotImplementedException(string message) => throw new NotImplementedException(message);
        public void NotSupportedException(string message) => throw new NotSupportedException(message);
    }
}
