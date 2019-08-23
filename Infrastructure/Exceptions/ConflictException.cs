using System.Net;

namespace UserManagement.Infrastructure.Exceptions
{
    public class ConflictException : ServiceException
    {
        public ConflictException()
            : base(HttpStatusCode.Conflict)
        {
        }


        public ConflictException(string message)
            : base(HttpStatusCode.Conflict, message)
        {
        }
    }
}
