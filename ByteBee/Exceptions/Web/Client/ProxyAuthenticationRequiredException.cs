using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class ProxyAuthenticationRequiredException : HttpException
    {
        public ProxyAuthenticationRequiredException()
            : base(HttpStatusCode.ProxyAuthenticationRequired)
        {
        }

        public ProxyAuthenticationRequiredException(string message)
            : base(HttpStatusCode.ProxyAuthenticationRequired, message)
        {
        }

        public ProxyAuthenticationRequiredException(string message, Exception inner)
            : base(HttpStatusCode.ProxyAuthenticationRequired, message, inner)
        {
        }
    }
}