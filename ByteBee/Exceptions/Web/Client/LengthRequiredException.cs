using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class LengthRequiredException : HttpException
    {
        public LengthRequiredException()
            : base(HttpStatusCode.LengthRequired)
        {
        }

        public LengthRequiredException(string message)
            : base(HttpStatusCode.LengthRequired, message)
        {
        }

        public LengthRequiredException(string message, Exception inner)
            : base(HttpStatusCode.LengthRequired, message, inner)
        {
        }
    }
}