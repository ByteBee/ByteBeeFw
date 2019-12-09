using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class PreconditionFailedException : HttpException
    {
        public PreconditionFailedException()
            : base(HttpStatusCode.PreconditionFailed)
        {
        }

        public PreconditionFailedException(string message)
            : base(HttpStatusCode.PreconditionFailed, message)
        {
        }

        public PreconditionFailedException(string message, Exception inner)
            : base(HttpStatusCode.PreconditionFailed, message, inner)
        {
        }
    }
}