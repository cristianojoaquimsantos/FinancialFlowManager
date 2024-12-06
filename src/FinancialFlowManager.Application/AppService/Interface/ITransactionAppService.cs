using FinancialFlowManager.Application.ViewModel;
using FinancialFlowManager.Domain.Entities;
using FluentValidation.Results;

namespace FinancialFlowManager.Application.AppService.Interface
{
    public interface ITransactionAppService : IAppServiceBase<Transaction>
    {
        Task CreateAsync(TransactionViewModel viewModel);
        Task<bool> DeleteAsync(Guid id);
        Task<IEnumerable<Transaction>> GetAllAsync(DateTime? startDate, DateTime? endDate);
        Task<Transaction> GetByIdAsync(Guid id);
        Task<bool> UpdateAsync(Guid id, TransactionViewModel viewModel);
    }
}
