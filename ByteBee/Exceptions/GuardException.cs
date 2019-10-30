using System;

namespace ByteBee.Exceptions
{
    public class GuardException : ByteBeeException
    {
        public GuardException(string message) : base(message)
        {
        }

        public GuardException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}