using FinancialFlowManager.Domain.Enums;

namespace FinancialFlowManager.Application.ViewModel
{
    public class FinancialAccountViewModel
    {
        public FinancialAccountViewModel()
        {

        }

        public string Name { get; private set; }
        public TypeFinancialAccount Type { get; private set; }
        public decimal CurrentBalance { get; private set; }
        public DateTime LastUpdated { get; private set; }

        public virtual ICollection<TransactionViewModel> Transactions { get; set; }
    }
}
