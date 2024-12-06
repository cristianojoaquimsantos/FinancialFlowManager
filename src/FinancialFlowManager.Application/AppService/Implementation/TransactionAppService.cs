using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Application.ViewModel;
using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;

namespace FinancialFlowManager.Application.AppService.Implementation
{
    public class TransactionAppService : AppServiceBase<Transaction>, ITransactionAppService
    {
        protected readonly ITransactionRepository _transactionRepository;

        public TransactionAppService(ITransactionRepository transactionRepository) : base(transactionRepository)
        {
        }

        public Task CreateAsync(TransactionViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transaction>> GetAllAsync(DateTime? startDate, DateTime? endDate)
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Guid id, TransactionViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
