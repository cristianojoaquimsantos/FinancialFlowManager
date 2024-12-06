using FinancialFlowManager.Application.ViewModel;
using FinancialFlowManager.Domain.Entities;

namespace FinancialFlowManager.Application.AppService.Interface
{
    public interface IFinancialAccountAppService: IAppServiceBase<FinancialAccount>
    {
        Task<FinancialAccountViewModel?> GetAllAsync();
        Task<FinancialAccountViewModel?> GetByIdAsync(Guid id);
        Task<bool> CreateAsync(FinancialAccountViewModel viewModel);
    }
}
