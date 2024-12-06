using FinancialFlowManager.Domain.Core.Messaging;

namespace FinancialFlowManager.Domain.Commands
{
    public abstract class LogAuditCommand: Command
    {
        public Guid Id { get; protected set; }
        public Guid? UserId { get; protected set; }
        public string EventType { get; protected set; }
        public DateTime DateTimeLog { get; protected set; }
        public string Details { get; protected set; }
    }
}
