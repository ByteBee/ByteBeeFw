using System;
using System.Runtime.Serialization;

namespace SwissKnife.Validating
{
    [Serializable]
    public class ObjectNotValidException : Exception
    {
        public ObjectNotValidException() { }
        public ObjectNotValidException(string message) : base(message) { }
        public ObjectNotValidException(string message, Exception inner) : base(message, inner) { }
        protected ObjectNotValidException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}