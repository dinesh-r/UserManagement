using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using UserManagement.Infrastructure.ViewModel;

namespace UserManagement.Infrastructure.Service.Repositories.Contracts
{
    public interface IBaseRepository : IDisposable
    {
        UserContextModel CurrentUser { get; set; }

        ILogger Logger { get; set; }

        Task<int> SaveAync();
    }
}
