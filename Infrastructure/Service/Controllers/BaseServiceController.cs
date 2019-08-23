using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserManagement.Infrastructure.Service.Managers.Contracts;
using UserManagement.Infrastructure.ViewModel;

namespace UserManagement.Infrastructure.Service.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest), ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class BaseServiceController : ControllerBase
    {
        private readonly IBaseManager _baseManager;

        public BaseServiceController(IBaseManager baseManager, ILogger logger)
        {
            _baseManager = baseManager;
            Logger = logger;

            // TODO: Should be removed hard coded value.
            _baseManager.CurrentUser = new UserContextModel
            {
                UserId = 1,
                Username = "Admin"

            };
        }

        public ILogger Logger { get; set; }
    }
}
