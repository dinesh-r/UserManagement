using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using UserManagement.Infrastructure.Service.Controllers;
using UserManagement.Infrastructure.ViewModel;
using UserManagement.Service.Security.V1.Managers.Contracts;
using UserManagement.ViewModel.Security;

namespace UserManagement.Service.Security.V1.Controllers
{
    public class RolesController : BaseServiceController
    {
        private IRolesManager _manager;

        public RolesController(IRolesManager manager, ILogger<RolesController> logger) : base(manager, logger)
        {
            _manager = manager;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<RoleModel>> CreateAsync([FromBody]RoleModel model)
        {
            await _manager.CreateAsync(model);
            return CreatedAtRoute("GetRoleAsync", new { model.RoleId }, model);
        }


        [HttpDelete("{roleId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent), ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteAsync(int roleId)
        {
            await _manager.DeleteAsync(roleId);
            return NoContent();
        }

       
        [HttpPost("Paged")]
        [Produces(typeof(GridDataModel<RoleListModel>))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<GridDataModel<RoleListModel>> GetAllAsync(RoleSearchModel searchModel)
        {
            return await _manager.GetAllAsync(searchModel);
        }

        [HttpGet("{roleId}", Name = "GetRoleAsync")]
        [ProducesResponseType(StatusCodes.Status200OK), ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<RoleModel>> GetAsync(int roleId)
        {
            var result = await _manager.GetAsync(roleId);
            return result;
        }

        [HttpPut("{roleId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent), ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateAsync(int roleId, [FromBody]RoleModel model)
        {
            await _manager.UpdateAsync(roleId, model);
            return NoContent();
        }
    }
}