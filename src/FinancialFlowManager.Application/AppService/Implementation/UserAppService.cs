using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;

namespace FinancialFlowManager.Application.AppService.Implementation
{
    public class UserAppService : AppServiceBase<User>, IUserAppService
    {
        protected readonly IUserRepository _userRepository;

        public UserAppService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
