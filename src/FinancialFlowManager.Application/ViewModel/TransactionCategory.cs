using FinancialFlowManager.Domain.Core.Domain;

namespace FinancialFlowManager.Application.ViewModel
{
    public class TransactionCategoryViewModel
    {
        public TransactionCategoryViewModel()
        {

        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; } // Credit or Debit

        public virtual ICollection<TransactionViewModel> Transactions { get; set; }
    }
}
