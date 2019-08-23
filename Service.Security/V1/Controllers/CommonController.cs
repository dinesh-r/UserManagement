using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.Infrastructure.Service.Controllers;
using UserManagement.Service.Security.V1.Managers.Contracts;
using UserManagement.ViewModel.Common;

namespace UserManagement.Service.Security.V1.Controllers
{
    public class CommonController : BaseServiceController
    {
        private ICommonManager _manager;

        public CommonController(ICommonManager manager, ILogger<CommonController> logger) : base(manager, logger)
        {
            _manager = manager;
        }

        [HttpGet("Countries"), ProducesResponseType(200)]
        [Produces(typeof(IList<ListItemModel>))]
        public async Task<IList<ListItemModel>> GetCountriesAsync()
        {
            var result = await _manager.GetCountriesAsync();
            return result;
        }

        [HttpGet("Countries/{countryId}/States"), ProducesResponseType(200), ProducesResponseType(400)]
        [Produces(typeof(IList<ListItemModel>))]
        public async Task<IList<ListItemModel>> GetStatesAsync(int countryId)
        {
            var result = await _manager.GetStatesAsync(countryId);
            return result;
        }
    }
}