using FinancialFlowManager.Domain.Core.Domain;

namespace FinancialFlowManager.Domain.Entities
{
    public class User: Entity
    {
        public User()
        {
            
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Role { get; private set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<LogAudit> LogAudit { get; set; }
    }
}
