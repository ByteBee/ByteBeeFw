using System;
using System.Runtime.Serialization;

namespace ByteBee.Exceptions
{
    [Serializable]
    public class InvalidVectorIndexException : Exception
    {
        public InvalidVectorIndexException() { }
        public InvalidVectorIndexException(string message) : base(message) { }
        public InvalidVectorIndexException(string message, Exception inner) : base(message, inner) { }
        protected InvalidVectorIndexException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}