using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class RequestTimeoutException : HttpException
    {
        public RequestTimeoutException()
            : base(HttpStatusCode.RequestTimeout)
        {
        }

        public RequestTimeoutException(string message)
            : base(HttpStatusCode.RequestTimeout, message)
        {
        }

        public RequestTimeoutException(string message, Exception inner)
            : base(HttpStatusCode.RequestTimeout, message, inner)
        {
        }
    }
}