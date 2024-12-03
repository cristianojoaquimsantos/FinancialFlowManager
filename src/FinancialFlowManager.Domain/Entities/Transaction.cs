using FinancialFlowManager.Domain.Core.Domain;
using FinancialFlowManager.Domain.Enums;

namespace FinancialFlowManager.Domain.Entities
{
    public class Transaction: Entity
    {
        public Transaction()
        {
            
        }

        public Guid UserId { get; private set; }
        public Guid AssociatedAccountId { get; private set; }
        public Guid ConsolidationId { get; private set; }
        public Guid CategoryId { get; private set; } // Credit or Debit
        public string Description { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime DateTime { get; private set; }
        public string Category { get; private set; }
        public string PaymentMethod { get; private set; }
        public string? SourceIdentifier { get; private set; }
        public string Status { get; private set; }

                
        public virtual FinancialAccount AssociatedAccount { get; set; }
        public virtual TransactionCategory TransactionCategory { get; set; }
        public virtual DailyConsolidation DailyConsolidation { get; set; }
        public virtual User User { get; set; }
    }
}
