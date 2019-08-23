using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using UserManagement.Infrastructure.Constants;

namespace UserManagement.Infrastructure.Web.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(IHttpClientFactory factory, ILogger logger)
        {
            UserManagementHttpClient = factory.CreateClient(ServiceConstant.USER_MANAGEMENT_SYSTEM_SERVICE);
            Logger = logger;
        }

        public ILogger Logger { get; set; }

        public HttpClient UserManagementHttpClient { get; set; }
    }
}
