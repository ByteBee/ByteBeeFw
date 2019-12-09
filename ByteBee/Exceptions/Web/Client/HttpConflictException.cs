using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class HttpConflictException : HttpException
    {
        public HttpConflictException() 
            : base(HttpStatusCode.Conflict)
        {
        }

        public HttpConflictException(string message) 
            : base(HttpStatusCode.Conflict, message)
        {
        }

        public HttpConflictException(string message, Exception inner) 
            : base(HttpStatusCode.Conflict, message, inner)
        {
        }
    }
}