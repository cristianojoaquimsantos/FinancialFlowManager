using FinancialFlowManager.Domain.Core.Domain;

namespace FinancialFlowManager.Domain.Entities
{
    public class TransactionCategory: Entity
    {
        public TransactionCategory()
        {
            
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; } // Credit or Debit

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
