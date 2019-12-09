using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class BadRequestException : HttpException
    {
        public BadRequestException()
            : base(HttpStatusCode.BadRequest)
        {
        }

        public BadRequestException(string message)
            : base(HttpStatusCode.BadRequest, message)
        {
        }

        public BadRequestException(string message, Exception inner)
            : base(HttpStatusCode.BadRequest, message, inner)
        {
        }
    }
}