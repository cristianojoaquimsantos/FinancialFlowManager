using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;
using FinancialFlowManager.Infrastructure.Context;

namespace FinancialFlowManager.Infrastructure.Repository
{
    public class LogAuditRepository : RepositoryBase<LogAudit>, ILogAuditRepository
    {
        protected new readonly FinancialFlowContext Db;

        public LogAuditRepository(FinancialFlowContext context) : base(context)
        {
            Db = context;
        }
    }
}
