using FinancialFlowManager.Application.ViewModel;
using FinancialFlowManager.Application.ViewModels;
using FinancialFlowManager.Domain.Entities;

namespace FinancialFlowManager.Application.AppService.Interface
{
    public interface IDailyConsolidationAppService: IAppServiceBase<DailyConsolidation>
    {
        Task<DailyConsolidationViewModel?> GetConsolidatedBalanceByDateAsync(DateTime date);
        Task<bool> UpdateConsolidatedBalanceAsync(UpdateDailyConsolidationViewModel viewModel);
        Task<bool> CalculateConsolidatedBalanceAsync();
    }
}
