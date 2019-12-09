using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class NotFoundException : HttpException
    {
        public NotFoundException() 
            : base(HttpStatusCode.NotFound)
        {
        }

        public NotFoundException(string message) 
            : base(HttpStatusCode.NotFound, message)
        {
        }

        public NotFoundException(string message, Exception inner) 
            : base(HttpStatusCode.NotFound, message, inner)
        {
        }
    }
}