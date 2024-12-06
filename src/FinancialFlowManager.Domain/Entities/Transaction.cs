using FinancialFlowManager.Domain.Core.Domain;
using FinancialFlowManager.Domain.Enums;

namespace FinancialFlowManager.Domain.Entities
{
    public class Transaction: Entity
    {
        public Transaction(Guid userId,
                           Guid associatedAccountId,
                           Guid consolidationId,
                           Guid categoryId,
                           string description,
                           decimal amount,
                           DateTime dateTimeTransaction,
                           Guid paymentMethodId,
                           string? sourceIdentifier,
                           string status)
        {
            UserId = userId;
            AssociatedAccountId = associatedAccountId;
            ConsolidationId = consolidationId;
            CategoryId = categoryId;
            Description = description;
            Amount = amount;
            DateTimeTransaction = dateTimeTransaction;
            PaymentMethodId = paymentMethodId;
            SourceIdentifier = sourceIdentifier;
            Status = status;
        }

        public Guid UserId { get; private set; }
        public Guid AssociatedAccountId { get; private set; }
        public Guid ConsolidationId { get; private set; }
        public Guid CategoryId { get; private set; } // Credit or Debit
        public string Description { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime DateTimeTransaction { get; private set; }
        public Guid PaymentMethodId { get; private set; }
        public string? SourceIdentifier { get; private set; }
        public string Status { get; private set; }

                
        public virtual FinancialAccount AssociatedAccount { get; set; }
        public virtual TransactionCategory TransactionCategory { get; set; }
        public virtual DailyConsolidation DailyConsolidation { get; set; }
        public virtual User User { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
