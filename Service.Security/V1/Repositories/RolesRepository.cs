using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Entity;
using UserManagement.Infrastructure.Extensions;
using UserManagement.Infrastructure.Service.Repositories;
using UserManagement.Infrastructure.ViewModel;
using UserManagement.Service.Security.V1.Repositories.Contracts;
using UserManagement.ViewModel.Security;

namespace UserManagement.Service.Security.V1.Repositories
{
    public class RolesRepository : BaseRepository, IRolesRepository
    {
        private SecurityDbContext _dbContext;

        public RolesRepository(SecurityDbContext dbContext, ILogger<RolesRepository> logger) : base(dbContext, logger)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(RoleModel model)
        {
            var role = new Role
                        {
                            RoleId      = model.RoleId,
                            Name        = model.Name,
                            Description = model.Description
                        };
            _dbContext.Role.Add(role);
            await _dbContext.SaveChangesAsync();
            model.RoleId = role.RoleId;
        }
                
        public async Task DeleteAsync(int roleId)
        {
            var role = await _dbContext.Role.FirstOrDefaultAsync(r => r.RoleId == roleId && !r.IsDeleted);
            if (role != null)
            {
                role.IsDeleted      = true;
                role.UpdatedBy      = CurrentUser.UserId;
                role.UpdatedDate    = DateTime.Now;

                _dbContext.Role.Update(role);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<bool> DoesRoleNameExistsAsync(string roleName)
        {
            return await _dbContext.Role.AnyAsync(r => r.Name == roleName && !r.IsDeleted);
        }

        public async Task<bool> DoesRoleNameExistsAsync(int roleId, string roleName)
        {
            return await _dbContext.Role.AnyAsync(r => r.RoleId != roleId && r.Name == roleName && !r.IsDeleted);
        }

        public async Task<GridDataModel<RoleListModel>> GetAllAsync(RoleSearchModel searchModel)
        {
            var results = from roles in _dbContext.Role
                          where !roles.IsDeleted
                          select new RoleListModel
                          {
                              Name = roles.Name,
                              Description = roles.Description,
                              RoleId = roles.RoleId
                          };

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
            {
                results = results.Where(e => EF.Functions.Like(e.Name, $"%{ searchModel.Name }%"));
            }

            return await results.ToGridDataAsync(searchModel);
        }

        public async Task<RoleModel> GetAsync(int roleId)
        {
            return await _dbContext.Role
                .Where(r => r.RoleId == roleId && !r.IsDeleted)
                .Select(r => new RoleModel
                {
                    RoleId      = r.RoleId,
                    Name        = r.Name,
                    Description = r.Description
                }).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(int roleId, RoleModel model)
        {
            var role = await _dbContext.Role.FirstOrDefaultAsync(r => r.RoleId == roleId && !r.IsDeleted);
            if (role != null)
            {
                role.Name           = model.Name;
                role.Description    = model.Description;
                role.UpdatedBy      = CurrentUser.UserId;
                role.UpdatedDate    = DateTime.Now;

                _dbContext.Role.Update(role);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}