using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class UnauthorizedException : HttpException
    {
        public UnauthorizedException()
            : base(HttpStatusCode.Unauthorized)
        {
        }

        public UnauthorizedException(string message)
            : base(HttpStatusCode.Unauthorized, message)
        {
        }

        public UnauthorizedException(string message, Exception inner)
            : base(HttpStatusCode.Unauthorized, message, inner)
        {
        }
    }
}