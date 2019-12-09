using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class RequestUriTooLongException : HttpException
    {
        public RequestUriTooLongException()
            : base(HttpStatusCode.RequestUriTooLong)
        {
        }

        public RequestUriTooLongException(string message) 
            : base(HttpStatusCode.RequestUriTooLong, message)
        {
        }

        public RequestUriTooLongException(string message, Exception inner) 
            : base(HttpStatusCode.RequestUriTooLong, message, inner)
        {
        }
    }
}