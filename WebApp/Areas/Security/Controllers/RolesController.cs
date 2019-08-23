using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;
using UserManagement.Infrastructure.Constants;
using UserManagement.Infrastructure.ViewModel;
using UserManagement.Infrastructure.Web.Controllers;
using UserManagement.ViewModel.Security;

namespace UserManagement.WebApp.Areas.Security.Controllers
{
    [Area("Security")]
    public class RolesController : BaseController
    {
        public RolesController(IHttpClientFactory factory, ILogger<RolesController> logger) : base(factory, logger)
        {
           
        }
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(new RoleSearchModel());
        }

        [HttpPost]
        public async Task<IActionResult> Search(RoleSearchModel searchModel)
        {
            var response = await UserManagementHttpClient.PostJsonAsync<GridDataModel<RoleListModel>>(EndpointConstant.Roles.LIST, new RoleSearchModel());
            return Json(response);
        }
    }
}
