using System;
using System.Net;

namespace demoapi.Exceptions{
    public class HttpException : Exception
    {
        public int StatusCode { get; }
 
        public HttpException(HttpStatusCode httpStatusCode)
            : base(httpStatusCode.ToString())
        {
            this.StatusCode = (int)httpStatusCode;
        }
    }
}