using FinancialFlowManager.Domain.Core.Domain;
using FinancialFlowManager.Domain.Enums;

namespace FinancialFlowManager.Application.ViewModel
{
    public class TransactionViewModel
    {
        public TransactionViewModel()
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


        public virtual FinancialAccountViewModel AssociatedAccount { get; set; }
        public virtual TransactionCategoryViewModel TransactionCategory { get; set; }
        public virtual DailyConsolidationViewModel DailyConsolidation { get; set; }
        public virtual UserViewModel UserViewModel { get; set; }
    }
}
