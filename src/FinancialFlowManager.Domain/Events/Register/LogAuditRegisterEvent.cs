using FinancialFlowManager.Domain.Core.Messaging;

namespace FinancialFlowManager.Domain.Events.Register
{
    public class LogAuditRegisterEvent: Event
    {
        public LogAuditRegisterEvent(Guid id,
                                     Guid? userId,
                                     string eventType,
                                     DateTime dateTimeLog,
                                     string details)
        {
            Id = id;
            UserId = userId;
            EventType = eventType;
            DateTimeLog = dateTimeLog;
            Details = details;
        }

        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string EventType { get; private set; }
        public DateTime DateTimeLog { get; private set; }
        public string Details { get; private set; }
    }
}
