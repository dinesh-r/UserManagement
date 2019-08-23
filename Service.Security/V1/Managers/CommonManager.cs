using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.Infrastructure.Service.Managers;
using UserManagement.Service.Security.V1.Managers.Contracts;
using UserManagement.Service.Security.V1.Repositories.Contracts;
using UserManagement.ViewModel.Common;

namespace UserManagement.Service.Security.V1.Managers
{
    /// <summary>
    /// Service Manager class for Configuring Common.
    /// </summary>
    public class CommonManager : BaseManager, ICommonManager
    {
        private readonly ICommonRepository _repository;

        public CommonManager(ICommonRepository repository, ILogger<CommonManager> logger) : base(repository, logger)
        {
            _repository = repository;
        }

        public async Task<IList<ListItemModel>> GetCountriesAsync()
        {
            return await _repository.GetCountriesAsync();
        }

        public async Task<IList<ListItemModel>> GetStatesAsync(int countryId)
        {
            if (countryId == 0)
            {
                throw new System.Exception(); //BadRequest();
            }

            return await _repository.GetStatesAsync(countryId);
        }
    }
}