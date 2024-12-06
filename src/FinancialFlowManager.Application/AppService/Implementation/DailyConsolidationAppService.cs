using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;

namespace FinancialFlowManager.Application.AppService.Implementation
{
    public class DailyConsolidationAppService : AppServiceBase<DailyConsolidation>, IDailyConsolidationAppService
    {
        protected readonly IDailyConsolidationRepository _dailyConsolidationRepository;

        public DailyConsolidationAppService(IDailyConsolidationRepository dailyConsolidationRepository) : base(dailyConsolidationRepository)
        {
            _dailyConsolidationRepository = dailyConsolidationRepository;
        }
    }
}
