using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;
using FinancialFlowManager.Infrastructure.Context;

namespace FinancialFlowManager.Infrastructure.Repository
{
    public class DailyConsolidationRepository : RepositoryBase<DailyConsolidation>, IDailyConsolidationRepository
    {
        protected new readonly FinancialFlowContext Db;

        public DailyConsolidationRepository(FinancialFlowContext context) : base(context)
        {
            Db = context;
        }

        public async Task<DailyConsolidation> GetByDateAsync(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
