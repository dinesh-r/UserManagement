using System.Net;

namespace UserManagement.Infrastructure.Exceptions
{
    public class BadRequestException : ServiceException
    {
        public BadRequestException()
            : base(HttpStatusCode.BadRequest)
        {
        }


        public BadRequestException(string message)
            : base(HttpStatusCode.BadRequest, message)
        {
        }
    }
}
