using System;
using System.Threading.Tasks;
using UserManagement.Infrastructure.Service.Repositories.Contracts;
using UserManagement.Infrastructure.ViewModel;
using UserManagement.ViewModel.Security;

namespace UserManagement.Service.Security.V1.Repositories.Contracts
{
    public interface IRolesRepository : IBaseRepository
    {       
        Task CreateAsync(RoleModel model);

        Task DeleteAsync(int roleId);

        Task<bool> DoesRoleNameExistsAsync(string roleName);

        Task<bool> DoesRoleNameExistsAsync(int roleId, string roleName);

        Task<GridDataModel<RoleListModel>> GetAllAsync(RoleSearchModel searchModel);

        Task<RoleModel> GetAsync(int roleId);

        Task UpdateAsync(int roleId, RoleModel model);
    }
}