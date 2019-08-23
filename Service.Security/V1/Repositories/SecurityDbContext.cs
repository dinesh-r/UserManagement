using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UserManagement.Entity;
using UserManagement.Infrastructure.Service.Repositories;
using UserManagement.Infrastructure.ViewModel;

namespace UserManagement.Service.Security.V1.Repositories
{
    public partial class SecurityDbContext : BaseDbContext<SecurityDbContext>
    {
        public SecurityDbContext(DbContextOptions<SecurityDbContext> options, IOptionsSnapshot<DatabaseSetting> dbSettings) : base(options, dbSettings)
        {
        }

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).ValueGeneratedNever();
            });
        }
    }
}
