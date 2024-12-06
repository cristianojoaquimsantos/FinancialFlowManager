using FinancialFlowManager.Domain.Core.Messaging;

namespace FinancialFlowManager.Domain.Commands
{
    public abstract class PaymentMethodCommand: Command
    {
        public Guid Id { get; set; }
        public string PaymentMethodName { get; private set; }
        public string? PaymentMethodDescrition { get; private set; }
    }
}
