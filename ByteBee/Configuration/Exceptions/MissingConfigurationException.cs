using System;
using System.Runtime.Serialization;

namespace ByteBee.Configuration.Exceptions
{
    [Serializable]
    public class MissingConfigurationException : Exception
    {
        public MissingConfigurationException()
        {
        }

        public MissingConfigurationException(string message) : base(message)
        {
        }

        public MissingConfigurationException(string message, Exception inner) : base(message, inner)
        {
        }

        protected MissingConfigurationException(SerializationInfo info,StreamingContext context) : base(info, context)
        {
        }
    }
}