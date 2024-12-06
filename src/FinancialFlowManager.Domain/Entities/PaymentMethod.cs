using FinancialFlowManager.Domain.Core.Domain;

namespace FinancialFlowManager.Domain.Entities;

public class PaymentMethod: Entity
{
    public PaymentMethod(string paymentMethodName,
                         string? paymentMethodDescrition)
    {
        PaymentMethodName = paymentMethodName;
        PaymentMethodDescrition = paymentMethodDescrition;
    }

    public string PaymentMethodName { get; private set; }
    public string? PaymentMethodDescrition { get; private set; }
    
    public virtual ICollection<Transaction> Transaction { get; set; }
}