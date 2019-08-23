using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Infrastructure.Service.Repositories;
using UserManagement.Service.Security.V1.Repositories.Contracts;
using UserManagement.ViewModel.Common;

namespace UserManagement.Service.Security.V1.Repositories
{

    public class CommonRepository : BaseRepository, ICommonRepository
    {
        private SecurityDbContext _dbContext;

        public CommonRepository(SecurityDbContext dbContext, ILogger<CommonRepository> logger) : base(dbContext, logger)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<ListItemModel>> GetCountriesAsync()
        {
            var counties = await (from t in _dbContext.Country
                                  select new ListItemModel
                                  {
                                      Text = t.Name,
                                      Value = t.CountryId.ToString()
                                  }).OrderBy(x => x.Text).ToListAsync();

            return counties;
        }

        public async Task<IList<ListItemModel>> GetStatesAsync(int countryId)
        {
            var states = await (from t in _dbContext.State
                                  where t.CountryId == countryId
                                  select new ListItemModel
                                  {
                                      Text = t.Name,
                                      Value = t.Code
                                  }).ToListAsync();

            return states;
        }
    }
}