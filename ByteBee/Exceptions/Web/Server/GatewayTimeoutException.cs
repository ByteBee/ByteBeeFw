using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class GatewayTimeoutException : HttpException
    {
        public GatewayTimeoutException()
            : base(HttpStatusCode.GatewayTimeout)
        {
        }

        public GatewayTimeoutException(string message)
            : base(HttpStatusCode.GatewayTimeout, message)
        {
        }

        public GatewayTimeoutException(string message, Exception inner)
            : base(HttpStatusCode.GatewayTimeout, message, inner)
        {
        }
    }
}