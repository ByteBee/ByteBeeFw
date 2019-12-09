using System;
using System.Net;
using System.Web;
using ByteBee.Exceptions.Web;
using ByteBee.Web.Exceptions;

namespace ByteBee.Web.Exceptions
{
    public class ForbiddenException : HttpException
    {
        public ForbiddenException() 
            : base(HttpStatusCode.Forbidden)
        {
        }

        public ForbiddenException(string message) 
            : base(HttpStatusCode.Forbidden, message)
        {
        }

        public ForbiddenException(string message, Exception inner) 
            : base(HttpStatusCode.Forbidden, message, inner)
        {
        }
    }
}