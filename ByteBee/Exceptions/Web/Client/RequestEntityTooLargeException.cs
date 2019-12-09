using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class RequestEntityTooLargeException : HttpException
    {
        public RequestEntityTooLargeException()
            : base(HttpStatusCode.RequestEntityTooLarge)
        {
        }

        public RequestEntityTooLargeException(string message)
            : base(HttpStatusCode.RequestEntityTooLarge, message)
        {
        }

        public RequestEntityTooLargeException(string message, Exception inner)
            : base(HttpStatusCode.RequestEntityTooLarge, message, inner)
        {
        }
    }
}