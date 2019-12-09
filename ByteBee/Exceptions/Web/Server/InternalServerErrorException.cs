using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class InternalServerErrorException : HttpException
    {
        public InternalServerErrorException()
            : base(HttpStatusCode.InternalServerError)
        {
        }

        public InternalServerErrorException(string message)
            : base(HttpStatusCode.InternalServerError, message)
        {
        }

        public InternalServerErrorException(string message, Exception inner)
            : base(HttpStatusCode.InternalServerError, message, inner)
        {
        }
    }
}