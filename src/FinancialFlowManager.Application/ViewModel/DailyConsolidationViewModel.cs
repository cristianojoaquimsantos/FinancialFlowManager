namespace FinancialFlowManager.Application.ViewModel
{
    public class DailyConsolidationViewModel
    {
        public DailyConsolidationViewModel()
        {

        }

        public Guid ConsolidationId { get; private set; }
        public DateTime Date { get; private set; }
        public decimal OpeningBalance { get; private set; }
        public decimal TotalCredits { get; private set; }
        public decimal TotalDebits { get; private set; }
        public decimal ClosingBalance { get; private set; }
        public DateTime LastUpdated { get; private set; }

        public virtual ICollection<TransactionViewModel> Transactions { get; set; }
    }
}
