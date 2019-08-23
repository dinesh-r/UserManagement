using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using UserManagement.Infrastructure.Service.Repositories.Contracts;
using UserManagement.Infrastructure.ViewModel;

namespace UserManagement.Infrastructure.Service.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        private readonly DbContext _dbContext;

        public BaseRepository(DbContext dbContext, ILogger logger)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException("dbContext");
            Logger = logger;
        }

        public UserContextModel CurrentUser { get; set; }

        public ILogger Logger { get; set; }

        public virtual async Task<int> SaveAync()
        {
            if (_dbContext != null)
            {
                return await _dbContext.SaveChangesAsync();
            }

            return 0;
        }

        public void Dispose()
        {

        }
    }
}
