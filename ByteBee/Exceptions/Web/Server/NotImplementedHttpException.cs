using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class NotImplementedHttpException : HttpException
    {
        public NotImplementedHttpException()
            : base(HttpStatusCode.NotImplemented)
        {
        }

        public NotImplementedHttpException(string message)
            : base(HttpStatusCode.NotImplemented, message)
        {
        }

        public NotImplementedHttpException(string message, Exception inner)
            : base(HttpStatusCode.NotImplemented, message, inner)
        {
        }
    }
}