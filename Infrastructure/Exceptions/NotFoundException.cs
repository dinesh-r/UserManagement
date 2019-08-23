using System.Net;

namespace UserManagement.Infrastructure.Exceptions
{
    public class NotFoundException : ServiceException
    {
        public NotFoundException()
            : base(HttpStatusCode.NotFound)
        {
        }

        public NotFoundException(string message)
            : base(HttpStatusCode.NotFound, message)
        {
        }
    }
}
