using FinancialFlowManager.Domain.Core.Domain;
using FinancialFlowManager.Domain.Enums;

namespace FinancialFlowManager.Domain.Entities
{
    public class FinancialAccount: Entity
    {
        public FinancialAccount(string name,
                                Guid typeId,
                                decimal currentBalance)
        {
            Name = name;
            TypeId = typeId;
            CurrentBalance = currentBalance;
            LastUpdated = DateTime.Now;
        }

        public string Name { get; private set; }
        public Guid TypeId { get; private set; }
        public decimal CurrentBalance { get; private set; }
        public DateTime LastUpdated { get; private set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual TypeFinancialAccount TypeFinancialAccount { get; set; }
    }
}
