using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using UserManagement.Infrastructure.Exceptions;
using UserManagement.Infrastructure.Service.Managers;
using UserManagement.Infrastructure.ViewModel;
using UserManagement.Service.Security.V1.Managers.Contracts;
using UserManagement.Service.Security.V1.Repositories.Contracts;
using UserManagement.ViewModel.Security;

namespace UserManagement.Service.Security.V1.Managers
{
    public class RolesManager : BaseManager, IRolesManager
    {
        private readonly IRolesRepository _repository;

        public RolesManager(IRolesRepository repository, ILogger<RolesManager> logger) : base(repository, logger)
        {
            _repository = repository;
        }

        public async Task CreateAsync(RoleModel model)
        {
            if (await _repository.DoesRoleNameExistsAsync(model.Name))
            {
                throw new ConflictException("Name:Role already exists.");
            }

            await _repository.CreateAsync(model);
        }

        public async Task DeleteAsync(int roleId)
        {
            if (roleId == 0)
            {
                throw new BadRequestException("Invalid Role Id");
            }

            await _repository.DeleteAsync(roleId);
        }

        public async Task<GridDataModel<RoleListModel>> GetAllAsync(RoleSearchModel searchModel)
        {
            return await _repository.GetAllAsync(searchModel);
        }

        public async Task<RoleModel> GetAsync(int roleId)
        {
            if (roleId == 0)
            {
                throw new BadRequestException("Invalid Role Id");
            }

            var model = await _repository.GetAsync(roleId);
            if (model == null)
            {
                throw new NotFoundException("Role not found");
            }

            return model;
        }

        public async Task UpdateAsync(int roleId, RoleModel model)
        {
            if (roleId == 0)
            {
                throw new ConflictException("Name:Role already exists.");
            }

            if (await _repository.DoesRoleNameExistsAsync(model.RoleId, model.Name))
            {
                throw new BadRequestException("Invalid Role Id");
            }

            await _repository.UpdateAsync(roleId, model);
        }
    }
}