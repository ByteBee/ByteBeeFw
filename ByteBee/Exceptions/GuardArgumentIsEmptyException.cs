using System;

namespace ByteBee.Exceptions
{
    public class GuardArgumentIsEmptyException : GuardException
    {
        public GuardArgumentIsEmptyException(string message) : base(message)
        {
        }

        public GuardArgumentIsEmptyException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}