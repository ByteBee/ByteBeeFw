using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class ServiceUnavailableException : HttpException
    {
        public ServiceUnavailableException()
            : base(HttpStatusCode.ServiceUnavailable)
        {
        }

        public ServiceUnavailableException(string message) 
            : base(HttpStatusCode.ServiceUnavailable, message)
        {
        }

        public ServiceUnavailableException(string message, Exception inner) 
            : base(HttpStatusCode.ServiceUnavailable, message, inner)
        {
        }
    }
}