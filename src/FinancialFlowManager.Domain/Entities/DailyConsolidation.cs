using FinancialFlowManager.Domain.Core.Domain;

namespace FinancialFlowManager.Domain.Entities
{
    public class DailyConsolidation: Entity
    {
        public DailyConsolidation(Guid consolidationId,
                                  DateTime date,
                                  decimal openingBalance,
                                  decimal totalCredits,
                                  decimal totalDebits,
                                  decimal closingBalance)
        {
            ConsolidationId = consolidationId;
            Date = date;
            OpeningBalance = openingBalance;
            TotalCredits = totalCredits;
            TotalDebits = totalDebits;
            ClosingBalance = closingBalance;
            LastUpdated = DateTime.Now;
        }

        public Guid ConsolidationId { get; private set; }
        public DateTime Date { get; private set; }
        public decimal OpeningBalance { get; private set; }
        public decimal TotalCredits { get; private set; }
        public decimal TotalDebits { get; private set; }
        public decimal ClosingBalance { get; private set; }
        public DateTime? LastUpdated { get; private set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
