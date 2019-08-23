using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.Infrastructure.Service.Repositories.Contracts;
using UserManagement.ViewModel.Common;

namespace UserManagement.Service.Security.V1.Repositories.Contracts
{
    public interface ICommonRepository : IBaseRepository
    {        
        Task<IList<ListItemModel>> GetCountriesAsync();

        Task<IList<ListItemModel>> GetStatesAsync(int countryId);
    }
}