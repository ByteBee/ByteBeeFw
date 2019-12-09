using System;

namespace ByteBee.Exceptions
{
    public sealed class GuardArgumentIsNotEmptyException : GuardException
    {
        public GuardArgumentIsNotEmptyException(string message) : base(message)
        {
        }

        public GuardArgumentIsNotEmptyException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}