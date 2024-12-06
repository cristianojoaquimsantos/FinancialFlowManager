namespace FinancialFlowManager.Application.ViewModels
{
    public class UpdateDailyConsolidationViewModel
    {
        public DateTime Date { get; set; }
        public decimal TotalCredits { get; set; }
        public decimal TotalDebits { get; set; }
        public decimal ClosingBalance { get; set; }
    }
}