using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class HttpException : ByteBeeException
    {
        public HttpStatusCode StatusCode { get; set; }

        public HttpException(HttpStatusCode code) : this(code, string.Empty)
        {
        }

        public HttpException(HttpStatusCode code, string message) : this(code, message, null)
        {
        }

        public HttpException(HttpStatusCode code, string message, Exception inner) : base(message, inner)
        {
            StatusCode = code;
        }
    }
}