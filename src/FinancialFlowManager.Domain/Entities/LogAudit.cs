using FinancialFlowManager.Domain.Core.Domain;

namespace FinancialFlowManager.Domain.Entities
{
    public class LogAudit: Entity
    {
        public LogAudit(Guid? userId,
                        string eventType,
                        DateTime dateTimeLog,
                        string details)
        {
            UserId = userId;
            EventType = eventType;
            DateTimeLog = dateTimeLog;
            Details = details;
        }

        public Guid? UserId { get; set; }
        public string EventType { get; private set; }
        public DateTime DateTimeLog { get; private set; }
        public string Details { get; private set; }

        public virtual User User { get; set; }
    }
}
