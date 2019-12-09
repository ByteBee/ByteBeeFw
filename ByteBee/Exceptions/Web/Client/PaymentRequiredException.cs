using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class PaymentRequiredException : HttpException
    {
        public PaymentRequiredException()
            : base(HttpStatusCode.PaymentRequired)
        {
        }

        public PaymentRequiredException(string message)
            : base(HttpStatusCode.PaymentRequired, message)
        {
        }

        public PaymentRequiredException(string message, Exception inner)
            : base(HttpStatusCode.PaymentRequired, message, inner)
        {
        }
    }
}