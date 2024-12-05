using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;
using FinancialFlowManager.Infrastructure.Context;

namespace FinancialFlowManager.Infrastructure.Repository
{
    public class TransactionCategoryRepository : RepositoryBase<TransactionCategory>, ITransactionCategoryRepository
    {
        protected new readonly FinancialFlowContext Db;

        public TransactionCategoryRepository(FinancialFlowContext context) : base(context)
        {
            Db = context;
        }
    }
}
