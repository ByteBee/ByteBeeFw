using System;
using System.Runtime.Serialization;

namespace ByteBee.Exceptions
{
    [Serializable]
    public class EnumNotFoundException : Exception
    {
        public EnumNotFoundException() { }
        public EnumNotFoundException(string message) : base(message) { }
        public EnumNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected EnumNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}