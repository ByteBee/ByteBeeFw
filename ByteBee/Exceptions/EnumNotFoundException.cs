using System;

namespace ByteBee.Exceptions
{
    [Serializable]
    public class EnumNotFoundException : ByteBeeException
    {
        public EnumNotFoundException(string message) : base(message)
        {
        }

        public EnumNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}