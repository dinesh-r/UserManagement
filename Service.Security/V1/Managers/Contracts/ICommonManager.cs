using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.Infrastructure.Service.Managers.Contracts;
using UserManagement.ViewModel.Common;

namespace UserManagement.Service.Security.V1.Managers.Contracts
{

    public interface ICommonManager : IBaseManager
    {
        Task<IList<ListItemModel>> GetCountriesAsync();

        Task<IList<ListItemModel>> GetStatesAsync(int countryId);
    }
}