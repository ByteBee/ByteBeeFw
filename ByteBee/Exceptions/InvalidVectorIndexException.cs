using System;

namespace ByteBee.Exceptions
{
    public class InvalidVectorIndexException : ByteBeeException
    {
        public InvalidVectorIndexException(string message) : base(message)
        {
        }

        public InvalidVectorIndexException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}