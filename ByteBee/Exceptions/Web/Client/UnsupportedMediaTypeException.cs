using System;
using System.Net;

namespace ByteBee.Exceptions.Web
{
    public class UnsupportedMediaTypeException : HttpException
    {
        public UnsupportedMediaTypeException()
            : base(HttpStatusCode.UnsupportedMediaType)
        {
        }

        public UnsupportedMediaTypeException(string message) 
            : base(HttpStatusCode.UnsupportedMediaType, message)
        {
        }

        public UnsupportedMediaTypeException(string message, Exception inner) 
            : base(HttpStatusCode.UnsupportedMediaType, message, inner)
        {
        }
    }
}