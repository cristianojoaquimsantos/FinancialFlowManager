using FinancialFlowManager.Domain.Core.Messaging;

namespace FinancialFlowManager.Domain.Commands
{
    public abstract class TransactionCategoryCommand: Command
    {
        public string Name { get; protected set; }
        public string Type { get; protected set; }
    }
}
