using FinancialFlowManager.Domain.Core.Domain;

namespace FinancialFlowManager.Application.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel()
        {

        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Role { get; private set; }

        public virtual ICollection<TransactionViewModel> Transactions { get; set; }
        public virtual ICollection<LogAuditViewModel> LogAudit { get; set; }
    }
}
