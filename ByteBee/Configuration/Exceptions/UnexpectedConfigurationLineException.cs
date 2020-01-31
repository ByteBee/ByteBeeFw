using System;
using System.Runtime.Serialization;

namespace ByteBee.Configuration.Exceptions
{
    [Serializable]
    public class UnexpectedConfigurationLineException : Exception
    {
        public UnexpectedConfigurationLineException()
        {
        }

        public UnexpectedConfigurationLineException(string message) : base(message)
        {
        }

        public UnexpectedConfigurationLineException(string message, Exception inner) : base(message, inner)
        {
        }

        protected UnexpectedConfigurationLineException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}