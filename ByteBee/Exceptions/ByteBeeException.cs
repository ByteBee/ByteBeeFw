using System;

namespace ByteBee.Exceptions
{
    [Serializable]
    public class ByteBeeException : Exception
    {
        public ByteBeeException(string message) : base(message)
        {
        }

        public ByteBeeException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}