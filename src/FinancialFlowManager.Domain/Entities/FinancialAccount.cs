using FinancialFlowManager.Domain.Core.Domain;
using FinancialFlowManager.Domain.Enums;

namespace FinancialFlowManager.Domain.Entities
{
    public class FinancialAccount: Entity
    {
        public FinancialAccount(string name,
                                TypeFinancialAccount type,
                                decimal currentBalance)
        {
            Name = name;
            Type = type;
            CurrentBalance = currentBalance;
            LastUpdated = DateTime.Now;
        }

        public string Name { get; private set; }
        public TypeFinancialAccount Type { get; private set; }
        public decimal CurrentBalance { get; private set; }
        public DateTime LastUpdated { get; private set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
