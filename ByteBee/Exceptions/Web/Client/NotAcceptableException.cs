using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class NotAcceptableException : HttpException
    {
        public NotAcceptableException()
            : base(HttpStatusCode.NotAcceptable)
        {
        }

        public NotAcceptableException(string message)
            : base(HttpStatusCode.NotAcceptable, message)
        {
        }

        public NotAcceptableException(string message, Exception inner)
            : base(HttpStatusCode.NotAcceptable, message, inner)
        {
        }
    }
}