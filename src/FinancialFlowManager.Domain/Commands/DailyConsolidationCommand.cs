using FinancialFlowManager.Domain.Core.Messaging;

namespace FinancialFlowManager.Domain.Commands
{
    public abstract class DailyConsolidationCommand: Command
    {
        public Guid Id { get; protected set; }
        public Guid ConsolidationId { get; protected set; }
        public DateTime Date { get; protected set; }
        public decimal OpeningBalance { get; protected set; }
        public decimal TotalCredits { get; protected set; }
        public decimal TotalDebits { get; protected set; }
        public decimal ClosingBalance { get; protected set; }
        public DateTime? LastUpdated { get; protected set; }
    }
}
