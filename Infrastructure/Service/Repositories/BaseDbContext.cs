using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UserManagement.Infrastructure.ViewModel;

namespace UserManagement.Infrastructure.Service.Repositories
{
    public class BaseDbContext<T> : DbContext where T : DbContext
    {
        private readonly IOptions<DatabaseSetting> _dbSettings;

        public BaseDbContext(DbContextOptions<T> options, IOptionsSnapshot<DatabaseSetting> dbSettings) : base(options)
        {
            _dbSettings = dbSettings;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbSettings.Value.ConnectionString);
        }
    }
}
