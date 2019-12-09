using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class HttpVersionNotSupportedException : HttpException
    {
        public HttpVersionNotSupportedException() 
            : base(HttpStatusCode.HttpVersionNotSupported)
        {
        }

        public HttpVersionNotSupportedException(string message) 
            : base(HttpStatusCode.HttpVersionNotSupported, message)
        {
        }

        public HttpVersionNotSupportedException(string message, Exception inner) 
            : base(HttpStatusCode.HttpVersionNotSupported, message, inner)
        {
        }
    }
}