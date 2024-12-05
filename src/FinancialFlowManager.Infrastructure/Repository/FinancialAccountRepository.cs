using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;
using FinancialFlowManager.Infrastructure.Context;

namespace FinancialFlowManager.Infrastructure.Repository
{
    public class FinancialAccountRepository : RepositoryBase<FinancialAccount>, IFinancialAccountRepository
    {
        protected new readonly FinancialFlowContext Db;

        public FinancialAccountRepository(FinancialFlowContext context) : base(context)
        {
            Db = context;
        }
    }
}
