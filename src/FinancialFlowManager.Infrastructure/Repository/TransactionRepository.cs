using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;
using FinancialFlowManager.Infrastructure.Context;

namespace FinancialFlowManager.Infrastructure.Repository
{
    public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
    {
        protected new readonly FinancialFlowContext Db;

        public TransactionRepository(FinancialFlowContext context) : base(context)
        {
            Db = context;
        }
    }
}
