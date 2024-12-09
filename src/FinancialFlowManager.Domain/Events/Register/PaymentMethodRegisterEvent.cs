using FinancialFlowManager.Domain.Core.Messaging;

namespace FinancialFlowManager.Domain.Events.Register
{
    public class PaymentMethodRegisterEvent: Event
    {
        public PaymentMethodRegisterEvent(Guid id,
                                          string paymentMethodName,
                                          string? paymentMethodDescrition)
        {
            Id = id;
            PaymentMethodName = paymentMethodName;
            PaymentMethodDescrition = paymentMethodDescrition;
        }

        public Guid Id { get; private set; }
        public string PaymentMethodName { get; private set; }
        public string? PaymentMethodDescrition { get; private set; }
    }
}
