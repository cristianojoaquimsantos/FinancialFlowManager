using FinancialFlowManager.Application.AppService.Interface;
using FinancialFlowManager.Domain.Entities;
using FinancialFlowManager.Domain.Repository.Interface;

namespace FinancialFlowManager.Application.AppService.Implementation
{
    public class LogAuditAppService : AppServiceBase<LogAudit>, ILogAuditAppService
    {
        protected readonly ILogAuditRepository _logAuditRepository;

        public LogAuditAppService(ILogAuditRepository logAuditRepository) : base(logAuditRepository)
        {
            _logAuditRepository = logAuditRepository;
        }
    }
}
