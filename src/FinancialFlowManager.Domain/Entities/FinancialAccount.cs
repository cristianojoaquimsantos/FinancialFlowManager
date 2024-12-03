using FinancialFlowManager.Domain.Core.Domain;
using FinancialFlowManager.Domain.Enums;

namespace FinancialFlowManager.Domain.Entities
{
    public class FinancialAccount: Entity
    {
        public FinancialAccount()
        {
            
        }

        public string Name { get; private set; }
        public TypeFinancialAccount Type { get; private set; }
        public decimal CurrentBalance { get; private set; }
        public DateTime LastUpdated { get; private set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
