using FinancialFlowManager.Domain.Core.Messaging;

namespace FinancialFlowManager.Domain.Events.Register
{
    public class DailyConsolidationRegisterEvent: Event
    {
        public DailyConsolidationRegisterEvent(Guid id,
                                               Guid consolidationId,
                                               DateTime date,
                                               decimal openingBalance,
                                               decimal totalCredits,
                                               decimal totalDebits,
                                               decimal closingBalance,
                                               DateTime lastUpdate)
        {
            Id = id;
            ConsolidationId = consolidationId;
            Date = date;
            OpeningBalance = openingBalance;
            TotalCredits = totalCredits;
            TotalDebits = totalDebits;
            ClosingBalance = closingBalance;
            LastUpdated = lastUpdate;
        }

        public Guid Id { get; set; }
        public Guid ConsolidationId { get; private set; }
        public DateTime Date { get; private set; }
        public decimal OpeningBalance { get; private set; }
        public decimal TotalCredits { get; private set; }
        public decimal TotalDebits { get; private set; }
        public decimal ClosingBalance { get; private set; }
        public DateTime? LastUpdated { get; private set; }
    }
}
