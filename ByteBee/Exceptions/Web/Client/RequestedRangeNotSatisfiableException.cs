using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class RequestedRangeNotSatisfiableException : HttpException
    {
        public RequestedRangeNotSatisfiableException()
            : base(HttpStatusCode.RequestedRangeNotSatisfiable)
        {
        }

        public RequestedRangeNotSatisfiableException(string message)
            : base(HttpStatusCode.RequestedRangeNotSatisfiable, message)
        {
        }

        public RequestedRangeNotSatisfiableException(string message, Exception inner)
            : base(HttpStatusCode.RequestedRangeNotSatisfiable, message, inner)
        {
        }
    }
}