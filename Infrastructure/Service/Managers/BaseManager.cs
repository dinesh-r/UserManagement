using Microsoft.Extensions.Logging;
using UserManagement.Infrastructure.Service.Managers.Contracts;
using UserManagement.Infrastructure.Service.Repositories.Contracts;
using UserManagement.Infrastructure.ViewModel;

namespace UserManagement.Infrastructure.Service.Managers
{
    public class BaseManager : IBaseManager
    {
        private readonly IBaseRepository _repository;
        private UserContextModel _currentUser;

        public BaseManager(IBaseRepository repository, ILogger logger)
        {
            _repository = repository;
            Logger = logger;
        } 

        public UserContextModel CurrentUser
        {
            get
            {
                return _currentUser;
            }
            set
            {
                _currentUser = value;
                if (_repository != null)
                {
                    _repository.CurrentUser = value;
                }
            }
        }

        public ILogger Logger { get; set; }
    }
}
