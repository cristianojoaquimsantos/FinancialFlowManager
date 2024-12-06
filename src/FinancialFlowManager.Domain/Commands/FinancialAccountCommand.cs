using FinancialFlowManager.Domain.Core.Messaging;
using FinancialFlowManager.Domain.Enums;

namespace FinancialFlowManager.Domain.Commands
{
    public abstract class FinancialAccountCommand: Command
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public TypeFinancialAccount Type { get; protected set; }
        public decimal CurrentBalance { get; protected set; }
        public DateTime LastUpdated { get; protected set; }
    }
}
