using System;
using System.Net;
using ByteBee.Exceptions.Web;

namespace ByteBee.Web.Exceptions
{
    public class ExpectationFailedException : HttpException
    {
        public ExpectationFailedException() 
            : base(HttpStatusCode.ExpectationFailed)
        {
        }

        public ExpectationFailedException(string message) 
            : base(HttpStatusCode.ExpectationFailed, message)
        {
        }

        public ExpectationFailedException(string message, Exception inner) 
            : base(HttpStatusCode.ExpectationFailed, message, inner)
        {
        }
    }
}