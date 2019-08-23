using System.Threading.Tasks;
using UserManagement.Infrastructure.Service.Managers.Contracts;
using UserManagement.Infrastructure.ViewModel;
using UserManagement.ViewModel.Security;

namespace UserManagement.Service.Security.V1.Managers.Contracts
{
    public interface IRolesManager : IBaseManager
    {
        Task CreateAsync(RoleModel model);

        Task DeleteAsync(int roleId);

        Task<GridDataModel<RoleListModel>> GetAllAsync(RoleSearchModel searchViewModel);

        Task<RoleModel> GetAsync(int roleId);

        Task UpdateAsync(int roleId, RoleModel model);
    }
}