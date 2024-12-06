using FinancialFlowManager.Domain.Entities;

namespace FinancialFlowManager.Domain.Repository.Interface
{
    public interface IDailyConsolidationRepository: IRepositoryBase<DailyConsolidation>
    {
        Task<DailyConsolidation> GetByDateAsync(DateTime date);
    }
}
