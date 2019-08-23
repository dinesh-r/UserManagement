using Microsoft.Extensions.Logging;
using UserManagement.Infrastructure.ViewModel;

namespace UserManagement.Infrastructure.Service.Managers.Contracts
{
    public interface IBaseManager
    {
        UserContextModel CurrentUser { get; set; }

        ILogger Logger { get; set; }
    }
}
