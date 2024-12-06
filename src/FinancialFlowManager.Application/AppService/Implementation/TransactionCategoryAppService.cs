using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Application.ViewModel;
using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;

namespace FinancialFlowManager.Application.AppService.Implementation
{
    public class TransactionCategoryAppService : AppServiceBase<TransactionCategory>, ITransactionCategoryAppService
    {
        protected readonly ITransactionCategoryRepository _transactionCategoryRepository;

        public TransactionCategoryAppService(ITransactionCategoryRepository transactionCategoryRepository) : base(transactionCategoryRepository)
        {
            _transactionCategoryRepository = transactionCategoryRepository;
        }

        public Task<TransactionCategoryViewModel?> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(TransactionCategoryViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
