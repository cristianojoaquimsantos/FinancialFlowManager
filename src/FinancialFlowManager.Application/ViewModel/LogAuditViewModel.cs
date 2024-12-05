using FinancialFlowManager.Domain.Core.Domain;

namespace FinancialFlowManager.Application.ViewModel
{
    public class LogAuditViewModel
    {
        public LogAuditViewModel()
        {

        }

        public Guid? UserId { get; set; }
        public string EventType { get; private set; }
        public DateTime DateTime { get; private set; }
        public string Details { get; private set; }

        public virtual UserViewModel User { get; set; }
    }
}
