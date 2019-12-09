using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class UpgradeRequiredException : HttpException
    {
        public UpgradeRequiredException()
            : base(HttpStatusCode.UpgradeRequired)
        {
        }

        public UpgradeRequiredException(string message) 
            : base(HttpStatusCode.UpgradeRequired, message)
        {
        }

        public UpgradeRequiredException(string message, Exception inner) 
            : base(HttpStatusCode.UpgradeRequired, message, inner)
        {
        }
    }
}