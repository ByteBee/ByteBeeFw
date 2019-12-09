using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class HttpGoneException : HttpException
    {
        public HttpGoneException() 
            : base(HttpStatusCode.Gone)
        {
        }

        public HttpGoneException(string message) 
            : base(HttpStatusCode.Gone, message)
        {
        }

        public HttpGoneException(string message, Exception inner) 
            : base(HttpStatusCode.Gone, message, inner)
        {
        }
    }
}