using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class BadGatewayException : HttpException
    {
        public BadGatewayException() 
            : base(HttpStatusCode.BadGateway)
        {
        }

        public BadGatewayException(string message) 
            : base(HttpStatusCode.BadGateway, message)
        {
        }

        public BadGatewayException(string message, Exception inner) 
            : base(HttpStatusCode.BadGateway, message, inner)
        {
        }
    }
}