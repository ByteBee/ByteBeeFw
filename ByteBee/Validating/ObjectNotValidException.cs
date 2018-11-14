using System;
using System.Runtime.Serialization;

namespace ByteBee.Validating
{
    [Serializable]
    public class ObjectNotValidException : Exception
    {
        /// <inheritdoc />
        public ObjectNotValidException() { }
        /// <inheritdoc />
        public ObjectNotValidException(string message) : base(message) { }
        /// <inheritdoc />
        public ObjectNotValidException(string message, Exception inner) : base(message, inner) { }
        /// <inheritdoc />
        protected ObjectNotValidException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}