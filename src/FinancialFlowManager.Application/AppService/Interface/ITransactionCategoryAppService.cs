using FinancialFlowManager.Application.ViewModel;
using FinancialFlowManager.Domain.Entities;

namespace FinancialFlowManager.Application.AppService.Interface
{
    public interface ITransactionCategoryAppService: IAppServiceBase<TransactionCategory>
    {
        Task<TransactionCategoryViewModel?> GetAllAsync();
        Task<bool> CreateAsync(TransactionCategoryViewModel viewModel);
    }
}
