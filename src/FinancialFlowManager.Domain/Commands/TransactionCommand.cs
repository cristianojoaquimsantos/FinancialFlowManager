using FinancialFlowManager.Domain.Core.Messaging;

namespace FinancialFlowManager.Domain.Commands
{
    public abstract class TransactionCommand: Command
    {
        public Guid Id { get; protected set; }
        public Guid UserId { get; protected set; }
        public Guid AssociatedAccountId { get; protected set; }
        public Guid ConsolidationId { get; protected set; }
        public Guid CategoryId { get; protected set; }
        public string Description { get; protected set; }
        public decimal Amount { get; protected set; }
        public DateTime DateTimeTransaction { get; protected set; }
        public Guid PaymentMethodId { get; protected set; }
        public string? SourceIdentifier { get; protected set; }
        public string Status { get; protected set; }
    }
}
