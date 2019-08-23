using System;
using System.Net;

namespace UserManagement.Infrastructure.Exceptions
{
    public class ServiceException : Exception
    {
        public HttpStatusCode StatusCode { get; private set; }

        public ServiceException(HttpStatusCode statusCode) : base() => StatusCode = statusCode;

        public ServiceException(HttpStatusCode statusCode, string message) : base(message)
        {
        }
    }
}
