using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class MethodNotAllowedException : HttpException
    {
        public MethodNotAllowedException()
            : base(HttpStatusCode.MethodNotAllowed)
        {
        }

        public MethodNotAllowedException(string message)
            : base(HttpStatusCode.MethodNotAllowed, message)
        {
        }

        public MethodNotAllowedException(string message, Exception inner)
            : base(HttpStatusCode.MethodNotAllowed, message, inner)
        {
        }
    }
}