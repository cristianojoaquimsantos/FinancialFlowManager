using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Application.ViewModel;
using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;

namespace FinancialFlowManager.Application.AppService.Implementation
{
    public class FinancialAccountAppService : AppServiceBase<FinancialAccount>, IFinancialAccountAppService
    {
        protected readonly IFinancialAccountRepository _financialAccountRepository;

        public FinancialAccountAppService(IFinancialAccountRepository financialAccountRepository) : base(financialAccountRepository)
        {
            _financialAccountRepository = financialAccountRepository;
        }

        public Task<FinancialAccountViewModel?> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FinancialAccountViewModel?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(FinancialAccountViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
