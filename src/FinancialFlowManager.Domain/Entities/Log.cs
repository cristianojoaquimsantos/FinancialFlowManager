using FinancialFlowManager.Domain.Core.Domain;

namespace FinancialFlowManager.Domain.Entities
{
    public class LogAudit: Entity
    {
        public LogAudit()
        {
                
        }

        public Guid? UserId { get; set; }
        public string EventType { get; private set; }
        public DateTime DateTime { get; private set; }
        public string Details { get; private set; }

        public virtual User User { get; set; }
    }
}
